using AspNetCore.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //CreateHostBuilder(args).Build().Run();
            //Nos aseguramos de que se ejecute la base de datos antes de consultar los datos
            var host = CreateHostBuilder(args).Build();
            //Se crea el scope para que traiga los servicios 
            //para que scope no quede en memoria usamos using, de ese modo termina su ciclo de vida
            using (var scope = host.Services.CreateScope())
            {

                var services = scope.ServiceProvider;
                //Se pide que asegure por lo cual invorara en EscuelaContext el metodo para aseegurar que todo funcione en este orden
                //Este context puede fallar si no se tiene conexion a la base de datos, para eso el try
                try
                {
                    var context = services.GetRequiredService<EscuelaContext>();
                    context.Database.EnsureCreated();
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred creating the DB.");
                }
            }

            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
