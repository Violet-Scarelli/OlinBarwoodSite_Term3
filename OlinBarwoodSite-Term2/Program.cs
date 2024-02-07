using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OlinBarwoodSite_Term2.Data;
using OlinBarwoodSite_Term2.Models;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("LocalDb");
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddTransient<IMessageRepository, MessageRepository>();
builder.Services.AddTransient<IMessageRepository, MessageRepository>();
builder.Services.AddIdentity<User, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();
builder.Services.AddDbContext<AppDbContext>(options =>
       options.UseSqlServer(connectionString));
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<IMessageRepository, MessageRepository>();
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
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    await ConfigureIdentity.CreateAdminUserAsync(scope.ServiceProvider);
    var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    AppDbInitializer.Seed(context, scope.ServiceProvider);
}

app.Run();
