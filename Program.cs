// References:
// Troelsen, A. & Japikse, P., 2022. Pro C# 10 with .NET 6: Foundational Principles and Practices in Programming. 11th ed. New York: Apress.
// Microsoft, 2024. Get started with Razor Pages in ASP.NET Core. [online] Available at: < https://learn.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/razor-pages-start?view=aspnetcore-9.0> [Accessed 25 June 2025
// Microsoft, 2024. DbContext configuration. [online] Available at: < https://learn.microsoft.com/en-us/ef/core/dbcontext-configuration/> [Accessed 25 June 2025].
// IliyanTodorov, 2022. EventHub. [code repository] GitHub.Available at: < https://github.com/IliyanTodorov/EventHub> [Accessed 25 June 2025].
// abhie7, 2021. Event Management System - ASP.NET Core. [code repository] GitHub.Available at: < https://github.com/abhie7/event-management-system-net-core> [Accessed 25 June 2025].
// W3Schools, 2025. CSS Tutorial. [online] Available at: <https://www.w3schools.com/css/> [Accessed 25 June 2025].
// Bootstrap, 2025. Introduction · Bootstrap. [online] Available at: <https://getbootstrap.com/> [Accessed 25 June 2025].


using CLDV6211_ST10294003.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddRazorPages();

// Register your DbContext with EF Core
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();
app.MapRazorPages();
app.Run();
