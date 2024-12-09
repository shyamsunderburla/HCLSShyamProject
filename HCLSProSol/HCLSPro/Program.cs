using HCLSPro.DataAcces.IRepositories;
using HCLSPro.DataAcces.Repositories;
using HCLSPro.DBContext;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<HclsDbContext>(Options => Options.UseSqlServer(builder.Configuration.GetConnectionString("constrlocal")));
//builder.Services.AddTransient<IAdminRepository, AdminRepository>();
//builder.Services.AddScoped<IAdminRepository, AdminRepository>();
builder.Services.AddSingleton<IAdminRepository, AdminRepository>();
//builder.Services.AddTransient<IAdminTypesRepository, AdminTypesRepository>();
//builder.Services.AddScoped<IAdminTypesRepository, AdminTypesRepository>();
builder.Services.AddSingleton<IAdminTypesRepository, AdminTypesRepository>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
