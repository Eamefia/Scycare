using Microsoft.AspNetCore.Mvc;

namespace Scycare.Web.Pages.Models
{
    public class Payment { 
    
        [BindProperty]
        public string Name { get; set; }
        [BindProperty]
        public string Email { get; set; }   

        [BindProperty]
        public int Amount { get; set; }
    }
}
