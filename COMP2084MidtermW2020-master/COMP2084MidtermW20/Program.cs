using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace COMP2084MidtermW20
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
.ConfigureWebHostDefaults(webBuilder => webBuilder.UseStartup<Startup>());
        }
    }
    
}
namespace MVC_BasicTutorials.Models
{
    public class Party
    {
        public int Pregnum { get; set; }
        public string PartyHead { get; set; }
    }
}
namespace MVC_BasicTutorials.Models
{
    public class Election
    {
        public int ElectionId { get; set; }
        public string Enames { get; set; }
        public int Electionyear { get; set; }
    }
}

