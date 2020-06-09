using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace databaseConnecties
{
    public class WeatherForcast
    {
        public string plaats { get; set; }
        public int interval { get; set; }
        public int temperatuur { get; set; }
        public int luchtvochtigheid { get; set; }
        public string windRichting { get; set; }
        public int windSnelheid { get; set; }
        public string voorspelling { get; set; }
        public string lastUpdate { get; set; }
    }

    public class MainDBContext : DbContext
    {
        public DbSet<WeatherForcast> Forcast { get; set; }
    }
}
