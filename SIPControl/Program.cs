using Blazorise;
using Blazorise.Bootstrap5;
using Blazorise.Icons.FontAwesome;
using SIPControl.Components;
using SIPControl.Shared;
using SIPControl.Shared.Data;
using SIPControl.Shared.Data.PbxOnline;
using SIPControl.Shared.Data.Yealink;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddSingleton<IDeviceStore, JsonDeviceStore>();
builder.Services
    .AddBlazorise( options =>
    {
        options.Immediate = true;
    } )
    .AddBootstrap5Providers()
    .AddFontAwesomeIcons();

builder.Services.Configure<LoginOptions>(builder.Configuration.GetSection("Login"));
builder.Services.Configure<PbxLoginOptions>(builder.Configuration.GetSection("PbxLogin"));
builder.Services.AddScoped<IPhoneClientFactory, PhoneClientFactory>();
builder.Services.AddScoped<IPbxOnlineFactory, PbxOnlineFactory>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();


app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();
app.Run();