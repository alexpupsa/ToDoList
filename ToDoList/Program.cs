using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using ToDoList.Model;
using ToDoList.Utils;

namespace ToDoList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().MigrateDatabase<ToDoContext>().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
