using Microsoft.EntityFrameworkCore;
using WepApiKamo.Models;
var builder = WebApplication.CreateBuilder(args);

var connectionstring = builder.Configuration.GetConnectionString("defaultconnection");
builder.Services.AddDbContext<NwuTechTrendsContext>(options => options.UseSqlServer(connectionstring));
//Adding authentication


// Add services to the container.

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
else {
    app.UseSwagger();
    app.UseSwaggerUI(options =>
        {
            options.SwaggerEndpoint("/swagger/v1/swagger.json", "WepApiKamo20240809123142");
            options.RoutePrefix =string.Empty;
        });


}
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
