using Autofac;
using Autofac.Extensions.DependencyInjection;
using Business.Abstracts;
using Business.Concretes;
using Business.DependencyResolvers.Autofac;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
//builder.Services.AddSingleton<ICourseService, CourseManager>();
//builder.Services.AddSingleton<ICourseDal, EfCourseDal>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Host.UseServiceProviderFactory(services => new AutofacServiceProviderFactory())
    .ConfigureContainer<ContainerBuilder>(builder =>
    { builder.RegisterModule(new AutofacBusinessModule()); });

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
