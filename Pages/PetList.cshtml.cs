using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pet_shop.Models;
using Pet_shop.services;

namespace Pet_shop.Pages
{
    public class PetListModel : PageModel
    {
        JsonPetFileServices PetService;
       public IEnumerable<pet> Pets;
        public PetListModel(JsonPetFileServices petService)
        {
            this.PetService = petService;
        }
        public void OnGet()
        {
            Pets = PetService.getPetsRecords();
        }
    }
}
