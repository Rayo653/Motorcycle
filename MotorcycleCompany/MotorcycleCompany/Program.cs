using Microsoft.AspNetCore.HttpOverrides;
using MotorcycleCompany.Extensions;
using NLog;
using System.Text.Json.Serialization;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        LogManager.LoadConfiguration(string.Concat(Directory.GetCurrentDirectory(), "/nlog.config"));
        builder.Services.ConfigureCors();
        builder.Services.ConfigureIISIntegration();
        builder.Services.ConfigureLoggerService();




        // Add services to the container.
        builder.Services.ConfigureRepositoryManager();
        builder.Services.ConfigureServiceManager();
        builder.Services.ConfigureContext(builder.Configuration);
        builder.Services.AddControllers()
            .AddApplicationPart(typeof(Presentation.AssemblyReference).Assembly)
            .AddJsonOptions(x =>
            x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
        builder.Services.AddAutoMapper(typeof(Program));


        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();



        var app = builder.Build();


        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        //if (app.Environment.IsDevelopment())
        //    app.UseDeveloperExceptionPage();
        //else
        //    app.UseHsts();

        //// Configure the HTTP request pipeline.

        //app.UseHttpsRedirection();
        //app.UseStaticFiles();
        //app.UseForwardedHeaders(new ForwardedHeadersOptions
        //{
        //    ForwardedHeaders = ForwardedHeaders.All
        //});

        app.UseCors("corsPolicy");

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}