using DotnetMinimalApiStarter.WebApi.Common.Interfaces;
using DotnetMinimalApiStarter.WebApi.Data;
using DotnetMinimalApiStarter.WebApi.Extensions;
using DotnetMinimalApiStarter.WebApi.Filters;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<AppDbContext>(
    options => options.UseSqlite(
        builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddTransient<IDatabaseSeeder, DatabaseSeeder>();

builder.Services.AddAutoMapper(typeof(Program));

builder.Services.AddLazyCache();
builder.Services.AddRepositories();

builder.Services.RegisterModules();

builder.Services
    .AddCors();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddValidatorsFromAssembly(typeof(Program).Assembly);

var app = builder.Build();

SeedData(app);

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(x => x
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader());

app.UseHttpsRedirection();

app.MapEndpoints();

app.Run();

void SeedData(IHost app)
{
    var scopefactory = app.Services.GetService<IServiceScopeFactory>();

    var scope = scopefactory?.CreateScope();

    var service = scope?.ServiceProvider.GetService<IDatabaseSeeder>();
    service ?.Initialize();
}