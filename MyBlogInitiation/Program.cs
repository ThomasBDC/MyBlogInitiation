global using MyBlogInitiation.ViewModels;
using Microsoft.EntityFrameworkCore;
using MyBlogInitiation.Models;
using MyBlogInitiation.Repository.Context;
using Microsoft.Extensions.DependencyInjection;
using MyBlogInitiation.Data;
using MyBlogInitiation.Repository.DAL;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using MyBlogInitiation.Services;

var builder = WebApplication.CreateBuilder(args);


//Add Entity Framework 
builder.Services.AddDbContext<DbBlogContext>(options =>
  options.UseSqlServer(builder.Configuration.GetConnectionString("BlogDbContext")));


///Solution -> Changer la classe IdentityUser dans le code behind de la page cr��e
builder.Services.AddDefaultIdentity<MyBlogInitiationUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<DbBlogContext>();



builder.Services.AddTransient<ArticlesPublicDAL>();

// Add services to the container.
builder.Services.AddControllersWithViews();

var mvcBuilder = builder.Services.AddRazorPages();
//builder.Services.AddDbContext<MyBlogInitiationContext>(options =>
    //options.UseSqlServer(builder.Configuration.GetConnectionString("MyBlogInitiationContext") ?? throw new InvalidOperationException("Connection string 'MyBlogInitiationContext' not found.")));

if (builder.Environment.IsDevelopment())
{
    mvcBuilder.AddRazorRuntimeCompilation();
}

builder.Services.AddTransient<IEmailSender, EmailSender>();
builder.Services.Configure<AuthMessageSenderOptions>(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//using (var scope = app.Services.CreateScope())
//{
//    var services = scope.ServiceProvider;

//    var context = services.GetRequiredService<DbBlogContext>();
//    context.Database.EnsureCreated();
//    // DbInitializer.Initialize(context);
//}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();;

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
