using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Scycare.Web.Interfaces;
using Scycare.Web.Pages.Models;
using System.Diagnostics;

namespace Scycare.Web.Pages
{

    public class CheckoutPageModel : PageModel
    {

        public List<LabTestModel> CheckoutItems = new List<LabTestModel>();


        private IItemsService _itemsService { get; }

        public CheckoutPageModel(IItemsService itemsService)
        {
            _itemsService = itemsService;
        }


        public void OnGet()
        {
            var item = CheckoutItems.Take(2);
            CheckoutItems = _itemsService.CheckoutTestList;
        }

        public void OnPost([FromBody] string[] ids)
        {
            //do something with the person class
        }


        public decimal? GetPriceSum()
        {
            return _itemsService.GetTotalPriceOfTests();
        }


        public int GetTotalTestCount()
        {
            return _itemsService.GetTestCount();
        }

    }
}
