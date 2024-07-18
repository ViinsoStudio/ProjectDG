using BusinessLogicSAPP.BL;
using DataAccessSAPP.Context;
using DataAccessSAPP.Queries;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//Creación de la variable para la cadena de conexión
var connectionString = builder.Configuration.GetConnectionString("ConnectionDB_SAPP");
//Registro del servicio para la conexión a la base de datos
builder.Services.AddDbContext<AppDbContext>(
    options => options.UseSqlServer(connectionString)
);
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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


//DataAccessSAPP Queries
builder.Services.AddScoped<UsersQueries>();

//BussinesLogic BL
builder.Services.AddScoped<UsersBL>();
