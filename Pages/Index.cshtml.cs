using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Pet_shop.Models;
using Pet_shop.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pet_shop.Pages
{
    public class IndexModel : PageModel
    {
        public IEnumerable<pet> Pets { get; private set; }
      

        private JsonPetFileServices PetService;
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(
            ILogger<IndexModel> logger,
            JsonPetFileServices petService)
        {
            _logger = logger;
            PetService = petService;
        }

        public void OnGet()
        {
            
        }
    }
}



