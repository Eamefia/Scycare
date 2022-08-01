using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PayStack.Net;
using Scycare.Web.Interfaces;
using Scycare.Web.Pages.Models;

namespace Scycare.Web.Pages
{
    public class CheckoutPaymentModel : PageModel
    {
        public List<LabTestModel> CheckoutItems = new List<LabTestModel>();

        private IItemsService _itemsService { get; }


        private readonly IConfiguration _configuration;
        private readonly string token;

        private PayStackApi PayStack { get; set; }

        [BindProperty]
        public Payment paymentDetails { get; set; }
        [BindProperty]
        public AddressModel address { get; set; }
        public string? pickuptime { get; set; } = null;

        public CheckoutPaymentModel(IItemsService itemsService, IConfiguration configuration)
        {
            _itemsService = itemsService;
            _configuration = configuration;
            token = _configuration["Payment:PaystackSK"];
            PayStack = new PayStackApi(token);
        }


        public void OnGet()
        {
            CheckoutItems = _itemsService.CheckoutTestList;
        }


        public decimal? GetPriceSum()
        {
            return _itemsService.GetTotalPriceOfTests();
        }


        public int GetTotalTestCount()
        {
            return _itemsService.GetTestCount();
        }


        public IActionResult OnPost(Payment paymentDetails)
        {
            TransactionInitializeRequest request = new()
            {
                AmountInKobo = paymentDetails.Amount * 100,
                Email = paymentDetails.Email,
                Reference = Generate().ToString(),
                Currency = "GHS",
                CallbackUrl = "https://dev.scycare.com/verifypayment"
            };

            TransactionInitializeResponse response = PayStack.Transactions.Initialize(request);
            if (response.Status)
            {
                return Redirect(response.Data.AuthorizationUrl);
            }
            return Redirect("https://dev.scycare.com/checkoutpayment");

        }
        public void OnPostAddAddress([FromBody]string[] address)
        {
            DateTime pickupDate = DateTime.UtcNow.AddSeconds(10800);
            if(address != null)
            {
                pickuptime = pickupDate.ToString();
            }    
        }

        public static int Generate()
        {
            Random random = new Random((int)DateTime.Now.Ticks);
            return random.Next(100000000, 999999999);
        }
    }
}
