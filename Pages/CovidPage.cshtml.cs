using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Scycare.Web.Interfaces;
using Scycare.Web.Pages.Models;

namespace Scycare.Web.Pages
{
    public class CovidPageModel : PageModel
    {

        public List<CoronaVirusModel> TestCenters = new List<CoronaVirusModel>();

        private IItemsService _itemsService { get; }

        public CovidPageModel(IItemsService itemsService)
        {
            _itemsService = itemsService;
        }


        public void OnGet()
        {
               _itemsService.GetTestCenterList();
            
        }
         
        public int GetTotalTestCenters()
        {
            return _itemsService.GetTestCenterCount();
        }
       
    }
}
