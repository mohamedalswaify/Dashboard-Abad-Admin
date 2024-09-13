using Microsoft.EntityFrameworkCore;
using WebApplicationAbad.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using WebApplicationAbad.Models;
using WebApplicationAbad.Repository.RepositoryInterface;
using WebApplicationAbad.Repository;
using WebApplicationAbad.Areas.AdminCoursesData.Models;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.AspNetCore.Http.Features;

var builder = WebApplication.CreateBuilder(args);



var connectionString = builder.Configuration.GetConnectionString("DataConnection") ?? throw new InvalidOperationException("Connection string 'DBCon' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseLazyLoadingProxies().UseSqlServer(connectionString));

builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultUI()
    .AddDefaultTokenProviders();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
});
//builder.Services.AddScoped<SignInManager<IdentityUser>>();

builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();

var provider = new FileExtensionContentTypeProvider();
provider.Mappings[".zip"] = "application/zip";
provider.Mappings[".rar"] = "application/x-rar-compressed";
builder.Services.AddSingleton(provider);





// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSession();

builder.Services.Configure<FormOptions>(options =>
{
    options.MultipartBodyLengthLimit = 500 * 1024 * 1024;
});

builder.WebHost.ConfigureKestrel(serverOptions =>
{
    serverOptions.Limits.MaxRequestBodySize = 500 * 1024 * 1024;
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseSession();
app.UseRouting();
app.UseAuthorization();
app.UseAuthentication();
app.UseEndpoints(endpoints => endpoints.MapRazorPages());

app.MapControllerRoute(
    name: "Areas",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");


//app.MapControllerRoute(
//    name: "AdminCoursesData",
//    pattern: "{area:exists}/{controller=Article}/{action=ArticleIndex}/{id?}",
//    defaults: new { area = "AdminCoursesData" }
//);

app.MapControllerRoute(
    name: "default2",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "AdminCoursesData",
    pattern: "{area:exists}/{controller=Employee}/{action=HomePageIndex}/{id?}",
    defaults: new { area = "AdminManageData" }
);






app.Run();
