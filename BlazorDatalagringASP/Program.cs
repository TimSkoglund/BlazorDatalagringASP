using BlazorDatalagringASP.Components;
using Data.Context;
using Data.Entities.Projects;
using Data.Repositories;
using Data.Repositories.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

using var db = new BlazorDatalagringContext();

Console.WriteLine($"Database path: {db.DbPath}.");


// Repositories
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<IProjectRepository, ProjectRepository>();

// DB Context
builder.Services.AddDbContext<BlazorDatalagringContext>();

// Seed managers
using (var context = new BlazorDatalagringContext())
{
    // Skapar databasen om den inte finns. Returnerar true om databasen skapades just nu.
    if (context.Database.EnsureCreated())
    {
        context.Manager.AddRange(
            new Manager
            {
                Name = "Lars Larsson",
                Email = "lasse@byggkonsult.se",
                HourPrice = 1500,
            },
            new Manager
            {
                Name = "Per Persson",
                Email = "pelle@pellekonsult.se",
                HourPrice = 1800,
            },
            new Manager
            {
                Name = "Anna Andersson",
                Email = "anna.andersson@vinnarbolaget.se",
                HourPrice = 2300
            }
        );
        
        context.SaveChanges();
    }
}

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();