using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pet_shop.Models;
using Pet_shop.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pet_shop.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PetsController : ControllerBase
    {
        JsonPetFileServices PetService { get; }
        public PetsController(JsonPetFileServices petService)
        {
            this.PetService = petService;
        }
        public IEnumerable<pet> Get()
        {
           return PetService.getPetsRecords();
        }
    }
}
