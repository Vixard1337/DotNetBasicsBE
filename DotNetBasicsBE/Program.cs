using DotNetBasicsBE.Application;
using DotNetBasicsBE.Components;
using DotNetBasicsBE.Data;
using DotNetBasicsBE.DTOs;
using DotNetBasicsBE.Infrastructure;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<ICarRepository, CarRepository>();
builder.Services.AddScoped<ICarService, CarService>();
builder.Services.AddScoped<AppStateService>();
builder.Services.AddScoped<EducationalSandboxService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
app.UseHttpsRedirection();

app.UseAntiforgery();

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    dbContext.Database.EnsureCreated();
}

app.MapGet("/cars", async (ICarService carService) =>
{
    var cars = await carService.GetAllAsync();
    return Results.Ok(cars);
});

app.MapGet("/cars/{id:int}", async (int id, ICarService carService) =>
{
    var car = await carService.GetByIdAsync(id);
    return car is null ? Results.NotFound() : Results.Ok(car);
});

app.MapPost("/cars", async (UpsertCarDto dto, ICarService carService) =>
{
    var created = await carService.CreateAsync(dto);
    return Results.Created($"/cars/{created.Id}", created);
});

app.MapPut("/cars/{id:int}", async (int id, UpsertCarDto dto, ICarService carService) =>
{
    var updated = await carService.UpdateAsync(id, dto);
    return updated ? Results.NoContent() : Results.NotFound();
});

app.MapDelete("/cars/{id:int}", async (int id, ICarService carService) =>
{
    var deleted = await carService.DeleteAsync(id);
    return deleted ? Results.NoContent() : Results.NotFound();
});

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(DotNetBasicsBE.Client._Imports).Assembly);

app.Run();
