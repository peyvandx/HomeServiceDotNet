using App.Domain.AppServices.Admin;
using App.Domain.AppServices.Customer;
using App.Domain.AppServices.Expert;
using App.Domain.Core.Admin.AppServices;
using App.Domain.Core.Admin.Data;
using App.Domain.Core.Admin.Entities;
using App.Domain.Core.Admin.Entities.Configs;
using App.Domain.Core.Admin.Services;
using App.Domain.Core.Customer.AppServices;
using App.Domain.Core.Customer.Data;
using App.Domain.Core.Customer.Services;
using App.Domain.Core.Expert.AppServices;
using App.Domain.Core.Expert.Data;
using App.Domain.Core.Expert.Services;
using App.Domain.Services.Admin;
using App.Domain.Services.Customer;
using App.Domain.Services.Expert;
using App.EndPoints.UI.RazorPages.Infrastructure;
using App.Infra.Data.Repos.Ef.Admin;
using App.Infra.Data.Repos.Ef.Customer;
using App.Infra.Data.Repos.Ef.Expert;
using App.Infra.Db.SqlServer.Ef.DbContext;
using Framework;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Serilog;
using Serilog.Events;
using System;

var builder = WebApplication.CreateBuilder(args);


#region DI
#region AdminDI
builder.Services.AddScoped<IAdminRepository, AdminRepository>();
builder.Services.AddScoped<IAdminService, AdminService>();
builder.Services.AddScoped<IAdminAppService, AdminAppService>();

builder.Services.AddScoped<IBaseAppService, BaseAppService>();
builder.Services.AddScoped<IBaseService, BaseService>();
#endregion

#region AddressDI
builder.Services.AddScoped<IAddressRepository, AddressRepository>();
builder.Services.AddScoped<IAddressService, AddressService>();
builder.Services.AddScoped<IAddressAppService, AddressAppService>();
#endregion

#region CityDI
builder.Services.AddScoped<ICityRepository, CityRepository>();
builder.Services.AddScoped<ICityService, CityService>();
builder.Services.AddScoped<ICityAppService, CityAppService>();
#endregion

#region CommentDI
builder.Services.AddScoped<ICommentRepository, CommentRepository>();
builder.Services.AddScoped<ICommentService, CommentService>();
builder.Services.AddScoped<ICommentAppService, CommentAppService>();
#endregion

#region CustomerDI
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<ICustomerService, CustomerService>();
builder.Services.AddScoped<ICustomerAppService, CustomerAppService>();
#endregion

#region ProvinceDI
builder.Services.AddScoped<IProvinceRepository, ProvinceRepository>();
builder.Services.AddScoped<IProvinceService, ProvinceService>();
builder.Services.AddScoped<IProvinceAppService, ProvinceAppService>();
#endregion

#region ServiceRequestDI
builder.Services.AddScoped<IServiceRequestRepository, ServiceRequestRepository>();
builder.Services.AddScoped<IServiceRequestService, ServiceRequestService>();
builder.Services.AddScoped<IServiceRequestAppService, ServiceRequestAppService>();
#endregion

#region CategoryDI
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ICategoryAppService, CategoryAppService>();
#endregion

#region ExpertDI
builder.Services.AddScoped<IExpertRepository, ExpertRepository>();
builder.Services.AddScoped<IExpertService, ExpertService>();
builder.Services.AddScoped<IExpertAppService, ExpertAppService>();
#endregion

#region ProposalDI
builder.Services.AddScoped<IProposalRepository, ProposalRepository>();
builder.Services.AddScoped<IProposalService, ProposalService>();
builder.Services.AddScoped<IProposalAppService, ProposalAppService>();
#endregion

#region ServiceDI
builder.Services.AddScoped<IServiceRepository, ServiceRepository>();
builder.Services.AddScoped<IServiceService, ServiceService>();
builder.Services.AddScoped<IServiceAppService, ServiceAppService>();
#endregion

#region SkillDI
builder.Services.AddScoped<ISkillRepository, SkillRepository>();
builder.Services.AddScoped<ISkillService, SkillService>();
builder.Services.AddScoped<ISkillAppService, SkillAppService>();
#endregion

builder.Services.AddScoped<IAccountAppService, AccountAppService>();

#region IdentityConfiguration

builder.Services.AddIdentity<ApplicationUser, IdentityRole<int>>
    (options =>
    {
        options.SignIn.RequireConfirmedAccount = false;
        options.Password.RequireDigit = false;
        options.Password.RequiredLength = 6;
        options.Password.RequireNonAlphanumeric = false;
        options.Password.RequireUppercase = false;
        options.Password.RequireLowercase = false;
    })
    .AddRoles<IdentityRole<int>>()
    .AddEntityFrameworkStores<HomeServiceDbContext>()
    .AddErrorDescriber<PersianIdentityErrorDescriber>();

#endregion

#endregion


builder.Services.AddRazorPages()
    .AddRazorRuntimeCompilation();

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

app.CustomExceptionHandlingMiddleware();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();

app.Run();
