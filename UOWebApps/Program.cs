using UOWebApps.Client.Pages;
using UOWebApps.Client.Services;
using UOWebApps.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveWebAssemblyComponents();  // Ensure this matches your setup for WebAssembly

builder.Services.AddSingleton<GoldTrackerService>();
builder.Services.AddSingleton<XPTrackerService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(UOWebApps.Client._Imports).Assembly);  // Ensure imports are correctly added

app.Run();
