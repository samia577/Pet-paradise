using Microsoft.AspNetCore.Hosting;
using Pet_shop.Models;
using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pet_shop.services
{
    
    public class JsonPetFileServices 
    {
        public JsonPetFileServices(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }
        public IWebHostEnvironment WebHostEnvironment { get; }
        public string JsonFilePath { get
            {
                return Path.Combine(WebHostEnvironment.WebRootPath, "data", "pets.json");
            } 
        }
        public IEnumerable<pet>getPetsRecords()
        {
            using(var json_file=File.OpenText(JsonFilePath))
            {
                return JsonSerializer.Deserialize<pet[]>(json_file.ReadToEnd());
            }
        }
    }

}

