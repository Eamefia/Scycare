using Scycare.Web.Pages.Models;

namespace Scycare.Web.Interfaces
{
    public interface IItemsService
    {
        List<LabTestModel> GetTestsList();
        
        List<LabTestModel> CheckoutTestList { get; set; }
        List<LabTestModel> GetCheckoutItems();
        void PostCheckoutItems(string[] ids);
        List<LabTestModel> GetSelectedCheckoutItems();
        void DeleteCheckoutItems(string id);
        LabTestModel GetCheckoutItem(string id);
        void AddCheckoutItem(LabTestModel item);
        decimal? GetTotalPriceOfTests();
        int GetTestCount();
        //corona virus
        int GetTestCenterCount();
        List<CoronaVirusModel> GetTestCenterList();
        List<CoronaVirusModel> TestCenterList();
    }
}
