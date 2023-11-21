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
// IoC Container - Inversion of Control - De�i�imin Kontrol� :
//// builder.Services.AddSingleton<IProductService, ProductManager>();
// Constructor'da IProductService isteyen bir ba��ml�l�k g�r�rse arkaplanda onun yerine ProductManager new'lemesi yapar.
// Singleton t�m bellekte sadece 1 tane ProductManager tutar, istedi�i kadar client gelsin, hepsine ayn� instance'� verir.
// Hepsi ayn� referans� tutar. (tabi bunu sadece "i�erisinde data tutmad���n" durumlarda kullanabilirsin.)
//// builder.Services.AddSingleton<IProductDal, EfProductDal>();
// ayn�s�n� IProductDal ba��ml�l�klar� i�in de yap�yoruz.

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
