using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace labf
{
    public class Config
    {
        public static string ConnectionString(string name)
        {
            string projectBase = AppContext.BaseDirectory.Substring(0, AppContext.BaseDirectory.IndexOf("bin"));

            var builder = new ConfigurationBuilder()
                .SetBasePath(projectBase)
                .AddJsonFile("appsettings.json");
            IConfiguration configuration = builder.Build();
            string Connectionstring = configuration.GetConnectionString(name);
            return Connectionstring;
        }
    }

}