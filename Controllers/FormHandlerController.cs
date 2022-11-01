using Microsoft.AspNetCore.Mvc;
using Pet_shop.Models;
using Pet_shop.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Pet_shop.Controllers
{
    [Route("[controller]")]
    public class FormHandlerController : Controller
    {
        JsonPetFileServices PetService;
       public FormHandlerController(JsonPetFileServices petService)
        {
            this.PetService = petService;
        }
        [HttpGet]
        public string Get(int id, string name, string image)
        {
            
                pet obj = new pet();
            obj.pet_id = id;
            obj.pet_name = name;
            obj.pet_image = image;

            IEnumerable<pet> petsData = PetService.getPetsRecords();
            List<pet> ListOfPets = petsData.ToList();
            ListOfPets.Add(obj);

            return JsonSerializer.Serialize<List<pet>>(ListOfPets);




        }

    }
}
