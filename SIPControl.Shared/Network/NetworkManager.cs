using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;

namespace SIPControl.Shared.Network;

public class NetworkManager
{
    public static async IAsyncEnumerable<string> PingAliveHostsAsync(
        string baseIp,
        int timeout = 100,
        int maxConcurrent = 50,
        [EnumeratorCancellation] CancellationToken cancellationToken = default)
    {
        var throttler = new SemaphoreSlim(maxConcurrent);
        var tasks = new List<Task<string?>>();

        for (int i = 1; i < 255; i++)
        {
            string ip = $"{baseIp}.{i}";
            await throttler.WaitAsync(cancellationToken);

            tasks.Add(Task.Run(async () =>
            {
                try
                {
                    using var ping = new Ping();
                    var reply = await ping.SendPingAsync(ip, timeout);
                    return reply.Status == IPStatus.Success ? ip : null;
                }
                catch
                {
                    return null;
                }
                finally
                {
                    throttler.Release();
                }
            }, cancellationToken));
        }

        while (tasks.Count > 0)
        {
            var finished = await Task.WhenAny(tasks);
            tasks.Remove(finished);

            var ip = await finished;
            if (ip is not null) yield return ip;
        }
    }

    public static async Task<PingReply> Ping(string ip)
    {
        var ping = new Ping();
        return await ping.SendPingAsync(ip);
    }
}