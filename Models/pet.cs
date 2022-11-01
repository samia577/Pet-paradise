using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Pet_shop.Models
{
    public class pet
    {
        [JsonPropertyName("id")]
        public int pet_id { get; set; }
        [JsonPropertyName("name")]
        public string pet_name { get; set; }
        [JsonPropertyName("image")]
        public string pet_image { get; set; }

        public override string ToString()
        {
           return JsonSerializer.Serialize<pet>(this);
        }
    }
    
}
