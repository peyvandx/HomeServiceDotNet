using App.Domain.Core.Admin.Entities.Configs;
using App.Infra.Db.SqlServer.Ef.DbContext;
using Microsoft.EntityFrameworkCore;
using Serilog;
using Serilog.Events;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddMemoryCache();


var configuration = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .Build();

var siteSettings = configuration.GetSection(nameof(SiteSettings)).Get<SiteSettings>();

builder.Services.AddSingleton(siteSettings);

builder.Host.ConfigureLogging(loggingBuilder =>
{
loggingBuilder.ClearProviders();

}).UseSerilog((context, config) =>
//builder.Logging.ClearProviders().UseSerilog((context, config) =>
{
    config.WriteTo.Console();
    config.WriteTo.Seq(siteSettings.LogConfiguration.SeqAddress, LogEventLevel.Information, apiKey: siteSettings.LogConfiguration.SeqApiKey);
});

builder.Services.AddDbContext<HomeServiceDbContext>(options
    => options.UseSqlServer(siteSettings.SqlConfiguration.ConnectionsString));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
