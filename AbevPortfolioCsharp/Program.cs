using AbevPortfolioCsharp;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
// new
builder.Services.AddScoped(Span => new HttpClient());
builder.Services.AddScoped<AbevPortfolioCsharp.Services.IContactService,
                            AbevPortfolioCsharp.Services.ApiContactService>();


builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
