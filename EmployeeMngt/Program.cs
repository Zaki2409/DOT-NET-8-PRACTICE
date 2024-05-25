using EmployeeMngt.Application.Services.EmployeeService;
using EmployeeMngt.Infrastructure.Data;
using EmployeeMngt.Infrastructure.Repository.EmployeeRepository;
using EmployeeMngt.Infrastructure.Repository.GenericRepository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//Db Context Configuration 
builder.Services.AddDbContext<ApplicationDbContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
    ); ;
//builder.Services.AddScoped<IEmployeeRepository, IEmployeeRepository>();
builder.Services.AddScoped<EmployeeMngt.Infrastructure.Repository.EmployeeRepository.IEmployeeRepository, EmployeeRepository>();
builder.Services.AddScoped<IEmployeeInterface, EmployeeInterface>();
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));



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
