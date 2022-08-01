using Microsoft.AspNetCore.Mvc.RazorPages;
using Scycare.Web.Pages.Models;
using Scycare.Web.Interfaces;

namespace Scycare.Web.Pages.Shared.Partials
{
    public class _ScylabHeroModel : PageModel
    {
        private IItemsService _itemsService { get; }

        public _ScylabHeroModel(IItemsService itemsService)
        {
            _itemsService = itemsService;
        }

        public List<LabTestModel> labtests { get; set; }

        public void OnGet()
        {
            labtests = _itemsService.GetTestsList();

        }
    }
}
