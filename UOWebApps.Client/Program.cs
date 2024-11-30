using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using UOWebApps.Client.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddSingleton<GoldTrackerService>();
builder.Services.AddSingleton<XPTrackerService>();

await builder.Build().RunAsync();
