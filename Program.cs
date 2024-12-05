using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using muja.Data;
using muja.entity;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<DbContext>(Options => Options.UseSqlServer(builder.Configuration.GetConnectionString("MujaConnection")));
builder.Services.AddRazorPages();

builder.Services.AddIdentity<Persona, Role>(options =>
{
    options.SignIn.RequireConfirmedAccount = false;
    options.SignIn.RequireConfirmedEmail = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireUppercase = false;
    options.Password.RequiredLength = 8;
    options.User.RequireUniqueEmail = false;

}).AddRoles<Role>()
  .AddEntityFrameworkStores<MujaDbContext>()
  .AddDefaultTokenProviders();
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

app.UseRouting();


app.UseAuthorization();
app.MapRazorPages();
app.MapControllerRoute(
    name: "area",
    pattern: "{area:Identity}/{controller=Account}/{action=Login}/{id?}");

app.Run();
