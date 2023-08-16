// =============================================
// Author: Dennis Serrano Barquero
// =============================================

using BackEnd.Middleware;
using Entities.Entities;
using Entities.Utilities;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

#region Connection String
builder.Services.AddDbContext<SchoolContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
string connString = builder.Configuration.GetConnectionString("DefaultConnection");
Util.ConnectionString = connString;
#endregion

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseMiddleware<ApiKeyMiddleware>();
app.UseAuthorization();
app.MapControllers();
app.Run();