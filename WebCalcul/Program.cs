using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using WebCalcul.Data;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("FirebirdDb");

builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");


// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

//TODO
// builder.Services.AddDbContext<YourDbContext>(options => options.UseFirebird(connectionString));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseRequestLocalization(new RequestLocalizationOptions()
	.AddSupportedCultures(new[] { "en-US", "cz-CZ", "sk-SK" })
	.AddSupportedUICultures(new[] { "en-US", "cz-CZ", "sk-SK" }));

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
 