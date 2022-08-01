namespace Scycare.Web.Pages.Models
{
    public class LabTestModel
    {
        public string Id { get; set; }
        public string PackageName { get; set; }
        public string TestDescription { get; set; }
        public string RequiredSample { get; set; }
        public string TestType { get; set; }
        public string[] TestUnderPackage { get; set; }
        public decimal Price { get; set; }

    }
}
