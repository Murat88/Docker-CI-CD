using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace DockerJenkinsCalismasi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseUrls("http://*:1000");
                    webBuilder.UseStartup<Startup>();
                });
    }
}
