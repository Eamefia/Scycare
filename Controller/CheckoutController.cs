using Microsoft.AspNetCore.Mvc;
using PayStack.Net;
using Scycare.Web.Interfaces;
using Scycare.Web.Pages.Models;
using System.Diagnostics;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Scycare.Web.Controller
{

    [Route("api/[controller]")]
    [ApiController]
    public class CheckoutController : ControllerBase
    {


        private IItemsService _itemsService;
        public CheckoutController(IItemsService itemService)
        {
            _itemsService = itemService;

        }
        // GET: api/<CheckoutController>
        [HttpGet]
        public List<LabTestModel> Get()
        {
            var itm = _itemsService.GetSelectedCheckoutItems();
            Console.WriteLine("items" + itm);
            return (itm).Take(1).ToList();

        }

        // GET api/<CheckoutController>/5
        [HttpGet("{id}")]
        public dynamic Get(string id)
        {

            var data = _itemsService.GetCheckoutItem(id);
            return Ok(data);
        }



        // POST api/<CheckoutController>
        [HttpPost]
        public void Post([FromBody] string[] value)
        {
            _itemsService.PostCheckoutItems(value);

        }

        // PUT api/<CheckoutController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CheckoutController>/5
        [HttpDelete("{id}")]
        public dynamic Delete(string id)
        {
            var data = _itemsService.GetCheckoutItem(id);
            _itemsService.DeleteCheckoutItems(id);
            return Ok(data);


        }


    }
}
