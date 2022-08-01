using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Scycare.Web.Interfaces;
using Scycare.Web.Pages.Models;

namespace Scycare.Web.Pages
{
    public class ScylabModel : PageModel
    {
        private IItemsService _itemsService { get; }

        public ScylabModel(IItemsService itemsService)
        {
            _itemsService = itemsService;
        }

        public List<LabTestModel> labtests { get; set; }

        public dynamic groupedByLetter { get; set; }
        public void OnGet()
        {
            labtests = _itemsService.GetTestsList();


        }
    }
}
