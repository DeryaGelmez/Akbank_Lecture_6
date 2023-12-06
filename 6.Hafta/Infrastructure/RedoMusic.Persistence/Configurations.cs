using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConfigurationManager = Microsoft.Extensions.Configuration.ConfigurationManager;

namespace RedoMusic.Persistence
{
    public static class Configurations
    {

        public static string GetString(string key)
        {
            ConfigurationManager configurationManager = new();

            string path = $"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName}\\Week_6_4\\Infrastructure\\Week_6_4.Persistence";

            configurationManager.SetBasePath(path);
            configurationManager.AddJsonFile("Private_Informations.json");
            return configurationManager.GetSection("ConnectionStrings:PostgreSQL").Value;
        }

    }
}
