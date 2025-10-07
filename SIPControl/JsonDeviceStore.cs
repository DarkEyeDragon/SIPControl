using SIPControl.Models;

namespace SIPControl.Shared;

using System.Collections.Concurrent;
using System.Text.Json;

public interface IDeviceStore
{
    Task<IReadOnlyCollection<PhoneDto>> GetAllAsync();
    Task UpsertAsync(PhoneDto device);
    Task<PhoneDto> GetAsync(string id);
}

public sealed class JsonDeviceStore : IDeviceStore
{
    private readonly string _path;
    private readonly ConcurrentDictionary<string, PhoneDto> _devices = new();
    private readonly JsonSerializerOptions _json = new(JsonSerializerDefaults.Web){WriteIndented=true};
    private readonly SemaphoreSlim _io = new(1,1);

    public JsonDeviceStore(IHostEnvironment env)
    {
        var dir = Path.Combine(env.ContentRootPath, "data");
        Directory.CreateDirectory(dir);
        _path = Path.Combine(dir, "devices.json");
        _ = LoadAsync();
    }

    private async Task LoadAsync()
    {
        if (!File.Exists(_path))
        {
            return;
        }
        var json = await File.ReadAllTextAsync(_path);
        var items = JsonSerializer.Deserialize<List<PhoneDto>>(json,_json) ?? new();
        foreach (var d in items) _devices[d.Id] = d;
    }

    public Task<IReadOnlyCollection<PhoneDto>> GetAllAsync()
        => Task.FromResult((IReadOnlyCollection<PhoneDto>)_devices.Values.OrderBy(x=>x.IpAddress).ToList());

    public Task<PhoneDto> GetAsync(string id)
    {
        _devices.TryGetValue(id, out var device);
        return Task.FromResult(device);
    }

    public async Task UpsertAsync(PhoneDto device)
    {
        _devices[device.Id] = device;
        await PersistAsync();
    }

    private async Task PersistAsync()
    {
        await _io.WaitAsync();
        try
        {
            var list = _devices.Values.OrderBy(x=>x.IpAddress).ToList();
            var json = JsonSerializer.Serialize(list,_json);
            await File.WriteAllTextAsync(_path, json);
        }
        finally { _io.Release(); }
    }
}
