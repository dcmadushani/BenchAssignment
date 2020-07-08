using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace OnlineStore.DataAccess.DataContract
{
    public class AppConfiguration
    {
        public string sqlConnectionString { get; set; }

        //Constructor
        public AppConfiguration()
        {
            var configBuilder = new ConfigurationBuilder();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            configBuilder.AddJsonFile(path, false);
            var root = configBuilder.Build();
            var appSetting = root.GetSection("ConnectionString:DefaultConnection");
            sqlConnectionString = appSetting.Value;
        }
        
    }
}
