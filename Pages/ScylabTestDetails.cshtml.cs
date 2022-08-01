using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Scycare.Web.Pages.Models;
using Scycare.Web.Interfaces;

namespace Scycare.LandingPage.Pages
{
    public class ScylabTestDetailsModel : PageModel
    {

        private IItemsService _itemsService { get; }

        public ScylabTestDetailsModel(IItemsService itemsService)
        {
            _itemsService = itemsService;
        }

        public List<LabTestModel> labtests { get; set; }
        public LabTestModel labTest { get; set; } = new LabTestModel();

        public void OnGet()
        {

        }

        public void OnGetLabTest(string id)
        {
            labtests = _itemsService.GetTestsList();
            labTest = _itemsService.GetCheckoutItem(id);

        }
    }
}