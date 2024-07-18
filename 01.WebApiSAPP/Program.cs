using BusinessLogicSAPP.BL;
using DataAccessSAPP.Context;
using DataAccessSAPP.Queries;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;


var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("ConnectionDB_SAPP");

builder.Services.AddDbContext<AppDbContext>(
    options => options.UseSqlServer(connectionString)
);
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//DataAccessSAPP Queries
builder.Services.AddScoped<UsersQueries>();

//BussinesLogic BL
builder.Services.AddScoped<UsersBL>();

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


