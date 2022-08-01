using Microsoft.AspNetCore.Mvc;
using System;

namespace Scycare.Web.Pages.Models
{
    public class CheckoutItem
    {
        [BindProperty]
        public string Name { get; set; }

        [BindProperty]
        public string Email { get; set; }

        [BindProperty]
        public int Amount { get; set; }
    }
}