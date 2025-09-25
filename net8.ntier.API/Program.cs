using net8.ntier.Business.Services.Base;
using net8.ntier.Business.Services.Users;
using net8.ntier.Domain.Contracts;
using net8.ntier.Domain.Repositories;
using net8.ntier.Domain.Services;
using net8.ntier.Persistence;
using net8.ntier.Persistence.Repositories;
using net8.ntier.Persistence.UoW;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddPersistenceServices(builder.Configuration); //verificar si dejamos el dependency injection de persistence

builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

// Add Business Services
builder.Services.AddScoped<IUserService, UserService>();

// Generic repository and unit of work registrations
builder.Services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped(typeof(IBaseService<>), typeof(BaseService<>));

//Repository registrations
builder.Services.AddScoped<IUserRepository, UserRepository>();


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
