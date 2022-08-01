using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Scycare.Web.Pages.Models;
using Scycare.Web.Interfaces;
using Microsoft.AspNetCore.Components;

namespace Scycare.Web.Pages
{
    public class AllLabTestModel : PageModel
    {
        private IItemsService _itemsService { get; }

        public AllLabTestModel(IItemsService itemsService)
        {
            _itemsService = itemsService;
        }

        public List<LabTestModel> labtests { get; set; }
        public List<LabTestModel> CheckoutItems = new List<LabTestModel>();

        public dynamic groupedByLetter { get; set; }

        public void OnGet()
        {
            labtests = _itemsService.GetTestsList();
            labtests.Sort((x, y) => x.PackageName.CompareTo(y.PackageName));
            groupedByLetter = labtests.GroupBy(test => test.PackageName[0]);

            CheckoutItems = _itemsService.CheckoutTestList;

        }

        public void OnPost()
        {

        }

    }
}
