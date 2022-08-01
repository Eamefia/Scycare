using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PayStack.Net;

namespace Scycare.Web.Pages
{
    public class VerifyPaymentModel : PageModel
    {

        private readonly IConfiguration _configuration;
        private readonly string token;

        public string Success { get; set; }

        private PayStackApi PayStack { get; set; }
        public VerifyPaymentModel(IConfiguration configuration)
        {
            _configuration = configuration;
            token = _configuration["Payment:PaystackSK"];
            PayStack = new PayStackApi(token);
        }
        public void OnGet( string reference)
        {
            TransactionVerifyResponse response = PayStack.Transactions.Verify(reference);
            if (response.Data.Status == "success")
            {
                Success = "Your order has been completed successfully.A confirmation email has been sent to you.";
            }
            else
            {
                Success = "Your payment could not go through";
            }
        }
    }
}
