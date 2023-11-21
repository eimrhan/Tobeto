using Autofac;
using Autofac.Extensions.DependencyInjection;
using Business.Abstract;
using Business.Concrete;
using Business.DependencyResolvers.Autofac;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// IoC Container - Inversion of Control - Deðiþimin Kontrolü :
//// builder.Services.AddSingleton<IProductService, ProductManager>();
// Constructor'da IProductService isteyen bir baðýmlýlýk görürse arkaplanda onun yerine ProductManager new'lemesi yapar.
// Singleton tüm bellekte sadece 1 tane ProductManager tutar, istediði kadar client gelsin, hepsine ayný instance'ý verir.
// Hepsi ayný referansý tutar. (tabi bunu sadece "içerisinde data tutmadýðýn" durumlarda kullanabilirsin.)
//// builder.Services.AddSingleton<IProductDal, EfProductDal>();
// aynýsýný IProductDal baðýmlýlýklarý için de yapýyoruz.

// AOP - Aspect Oriented Programming

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
