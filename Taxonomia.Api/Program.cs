using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Taxonomia.Api.Extensions;
using Taxonomia.Data.DbContexts.SqlContext;
using Taxonomia.Data.IoC;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddListAutoMapperCustom();

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.Configure<ApiBehaviorOptions>(options => {

    options.SuppressModelStateInvalidFilter = true;
});

builder.Services.AddDbContext<SqlContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Sql"))
);

builder.Services.ResolveDependencies();

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
