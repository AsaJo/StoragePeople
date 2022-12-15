using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using StoragePeople.Data;
using StoragePeople.Models.Enterties;
using StoragePeople.Models.Repos;
using StoragePeople.Models.Services;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddMvc();  

builder.Services.AddIdentity<AppUser, IdentityRole>()
.AddEntityFrameworkStores<PeopleDbContext>()
.AddDefaultTokenProviders();

//builder.Services.Configure<IdentityOptions>(options =>
//{ });

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<PeopleDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IPeopleRepo, DatabasePeopleRepo>();// IoC & DI
builder.Services.AddScoped<IPeopleService, PeopleService>();// IoC & DI

builder.Services.AddScoped<ICityRepo, DatabaseCityRepo>();// IoC & DI
builder.Services.AddScoped<ICityService, CityService>();// IoC & DI

builder.Services.AddScoped<ICountryRepo, DatabaseCountryRepo>();// IoC & DI
builder.Services.AddScoped<ICountryService, CountryService>();// IoC & DI

//builder.Services.AddScoped<ILanguageRepo, DatabaseLanguageRepo>();// IoC & DI
//builder.Services.AddScoped<ILanguageService, LanguageService>();// IoC & DI



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


app.UseAuthentication();// ? Add this
app.UseAuthorization();

app.UseEndpoints(endpoints =>
    {
        endpoints.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");
    });

app.Run();
