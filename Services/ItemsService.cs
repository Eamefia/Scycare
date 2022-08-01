using Scycare.Web.Interfaces;
using Scycare.Web.Pages.Models;
using System.Diagnostics;

namespace Scycare.Web.Services
{
    public class ItemsService : IItemsService
    {
        public List<LabTestModel> CheckoutTestList { get; set; } = new List<LabTestModel>();

        public List<LabTestModel> TestList { get; set; } = new List<LabTestModel>()
        {

          new LabTestModel
            {
                Id = "0",
                PackageName = "Full Blood Count (FBC)",
                TestDescription = "This test is to determine general health status and to screen for, diagnose or monitor a variety of disorders that affect blood cells such as anaemia and infection, as well as nutritional status and exposure to toxic substances, bleeding disorders or cancer.The full blood count (FBC) is one of the most commonly ordered tests and provides important information about the kinds and numbers of cells in the blood: red blood cells (RBC), white blood cells (WBC) and platelets. Abnormalities in any of these types of cells can indicate the presence of important medical disorders.The WBC Differential count determines the general health status and to screen for, diagnose or monitor a variety of disorders that affect blood cells such as anaemia and infection, as well as nutritional status and exposure to toxic substances, bleeding disorders or cancer.",
                RequiredSample = "Blood",
                TestType = "Multiple Tests",
                TestUnderPackage = { },
                Price = 50.00m,

            },
            new LabTestModel
            {
                Id ="1",
                PackageName = "Haemoglobin Test (Hb)",
                TestDescription = "This test measures the amount of haemoglobin (a protein found in red blood cells) in your blood and is a good indication of your blood's ability to carry oxygen throughout your body. Haemoglobin carries oxygen to cells from the lungs. If your haemoglobin levels are low, you have anaemia, a condition in which your body is not getting enough oxygen, causing fatigue and weakness.",
                RequiredSample = "Blood",
                TestType = "Singlee Tests",
                TestUnderPackage = { },
                Price = 15.00m,

            },
            new LabTestModel
            {
                Id ="2",
                PackageName = "Widal Test",
                TestDescription = "Widal test measures antibodies against flagellar (H) and somatic (O) antigens of the causative organism. In acute infection, O antibody appears first, rising progressively, later falling and often disappearing within a few months. H antibody appears a little later but persists for longer. It is used to help make a presumptive diagnosis of enteric fever, also known as typhoid fever.",
                RequiredSample = "Blood",
                TestType = "Multiple Tests",
                TestUnderPackage = { },
                Price = 30.00m,

            },
            new LabTestModel
            {
                Id ="3",
                PackageName = "Haemoglobin Test (Hb) + Widal Test",
                TestDescription = "Hb test measures the amount of haemoglobin (a protein found in red blood cells) in your blood and is a good indication of your blood's ability to carry oxygen throughout your body. Haemoglobin carries oxygen to cells from the lungs. If your haemoglobin levels are low, you have anaemia, a condition in which your body is not getting enough oxygen, causing fatigue and weakness. Widal test measures antibodies against flagellar (H) and somatic (O) antigens of the causative organism. In acute infection, O antibody appears first, rising progressively, later falling and often disappearing within a few months. H antibody appears a little later but persists for longer. It is used to help make a presumptive diagnosis of enteric fever, also known as typhoid fever.",
                RequiredSample = "Blood",
                TestType = "Multiple Tests",
                TestUnderPackage = { },
                Price = 70.00m,

            },
            new LabTestModel
            {
                Id ="4",
                PackageName = "Fasting Blood Sugar/Glucose Test",
                TestDescription = "This test is to determine whether or not your blood glucose level is within the reference range; to screen for, diagnose, and monitor diabetes, and monitor blood glucose levels where required.  Glucose is a sugar that serves as the main source of energy for the body. The carbohydrates we eat are broken down into glucose (and a few other sugars), absorbed by the small intestine and circulated throughout the body. Most of the body's cells require glucose for energy production; the brain and nervous system cells rely on glucose for energy, and can only function when glucose levels in the blood remain within a certain range.",
                RequiredSample = "Blood",
                TestType = "Single Test",
                TestUnderPackage = { },
                Price = 15.00m,

            },
              new LabTestModel
            {
                Id ="5",
                PackageName = "Uric Acid Test",
                TestDescription = "This test is to detect high levels of uric acid, which could be a sign of the condition gout, to monitor uric acid levels when undergoing chemotherapy or radiotherapy, or to investigate kidney stones. Uric acid is produced by the breakdown of purines. Purines are chemicals that come from nucleic acids (DNA, RNA). They enter the circulation from digestion of foods or from normal breakdown and turnover of cells in the body. Most uric acid is removed by the kidneys and disposed of in the urine; the remainder is excreted in the faeces.",
                RequiredSample = "Blood",
                TestType = "Single Test",
                TestUnderPackage = { },
                Price = 20.00m,

            },
            new LabTestModel
            {
                Id ="6",
                PackageName = "Cholestrol Test",
                TestDescription = "Cholesterol testing is recommended when you have established heart disease (angina, heart attack), or if there is a family history of high cholesterol, or of heart disease at an early age; if you are less than 45 years of age and have risk factors which put you at an increased chance of developing heart disease, such as diabetes, high blood pressure, chronic renal failure or renal transplantation, Aboriginal or Torres Strait Islander, overweight or you are a smoker. In addition, cholesterol testing is performed if you are following a recommended diet or taking drugs to lower your cholesterol level, to monitor your response to treatment. Total cholesterol may be measured alone or in combination with other tests including HDL, LDL, and triglycerides - often called a lipid profile.",
                RequiredSample = "Blood",
                TestType = "Single Test",
                TestUnderPackage = { },
                Price = 30.00m,

            },
           new LabTestModel
            {
               Id ="7",
                PackageName = "Triglycerides",
                TestDescription = "This test is to assess the risk of developing heart disease. This test measures the amount of triglycerides in your blood. Triglycerides are the body's storage form for fat. Most triglycerides are found in adipose (fat) tissue. Some triglycerides circulate in the blood to provide fuel for muscles to work. Extra triglycerides are found in the blood after eating a meal — when fat is being sent from the gut to adipose tissue for storage. Ideally, the test for triglycerides should be done when you are fasting and no extra triglycerides from a recent meal are present. During fasting most triglycerides are carrried in the blood by lipoproteins called very low density lipoproteins (VLDL).",
                RequiredSample = "Blood",
                TestType = "Single Test",
                TestUnderPackage = { },
                Price = 30.00m,

            },
           new LabTestModel
            {
               Id ="8",
                PackageName = "Urine Routine Examination (Urinalysis",
                TestDescription = "Urinalysis is used to detect and manage a wide range of problems such as urinary tract infections, kidney disorders and diabetes. Abnormal urinalysis may point towards a particular disease or illness and prompt further testing. Urinalysis involves checking the appearance, concentration and content of urine. 1. Chemical examination, which tests chemically for a number of substances such as sugar (glucose), protein and nitrites that provide valuable information about health and disease; and 2. Microscopic examination, which identifies and counts the type of cells and other components (bacteria, casts and crystals) that can be present in urine.",
                RequiredSample = "Urine",
                TestType = "Multiple Tests",
                TestUnderPackage = { },
                Price = 30.00m,

            },
            new LabTestModel
            {
                Id ="9",
                PackageName = "Stool Routine Examination",
                TestDescription = "A stool test is also known as stool culture, faecal sample test or stool sample test. The test helps in diagnosing medical conditions, such as inflammatory bowel disease, gastric or colon cancer, anal fissures, haemorrhoids, as well as to detect the presence of blood in your stool sample. ",
                RequiredSample = "Stool",
                TestType = "Multiple Tests",
                TestUnderPackage = { },
                Price = 20.00m,

            },
            new LabTestModel
            {
                Id="10",
                PackageName = "Hepatitis B",
                TestDescription = "This test is to diagnose and follow the course of an infection with hepatitis B or to determine if the vaccine against hepatitis B has produced the desired level of immunity. Hepatitis B is an infection of the liver caused by the hepatitis B virus (HBV). Hepatitis B blood tests detect viral proteins (antigens), the antibodies that are produced in response to an infection, or detect or evaluate the genetic material (DNA) of the virus. The pattern of tests results can identify a person who has a current active infection, was exposed to HBV in the past, or has immunity as a result of vaccination.",
                RequiredSample = "Blood",
                TestType = "Single Test",
                TestUnderPackage = { },
                Price = 30.00m,

            },
           new LabTestModel
            {
               Id="11",
                PackageName = "Hepatitis C",
                TestDescription = "This test helps to determine if you have contracted the hepatitis C virus and to monitor treatment of the infection. is C is a virus that can infect and damage the liver. In most cases, it is contracted through exposure to blood (usually from sharing contaminated needles while injecting drugs or, before 1990, through a blood transfusion. It can also be passed from mother to baby. Other ways it can occasionally be transmitted include needlestick injuries in a healthcare setting, tattooing, body piercing and rarely through sexual transmission. Hepatitis C antibody is produced in response to exposure to the hepatitis C virus (HCV). The most common test for HCV looks for these antibodies in your blood. Other tests detect the presence of the actual virus, the amount of virus present, or determine the specific subtype of virus.",
                RequiredSample = "Blood",
                TestType = "Single Test",
                TestUnderPackage = { },
                Price = 30.00m,

            },
            new LabTestModel
            {
                Id="12",
                PackageName = "Syphilis",
                TestDescription = "This test is to screen for syphilis infection. The test is looking for evidence of Treponema pallidum, the bacterium that causes syphilis. Syphilis is a sexually transmitted disease. It is easily treated but can cause severe health problems if left untreated.",
                RequiredSample = "",
                TestType = "",
                TestUnderPackage = { },
                Price = 30.00m,

            },
             new LabTestModel
            {
                 Id="13",
                PackageName = "Blood Group ",
                TestDescription = "This test is to determine your blood group in preparation for a possible blood transfusion or treatment with specific blood components or products. A blood group is commonly performed as part of a group of tests. These tests include ABO and RhD blood groups, a blood group antibody screen and a crossmatch. Blood groups are chemical structures (most commonly proteins or carbohydrates) on the outside surface of the red blood cell. These chemical structures usually have a defined function such as determining the shape of the cell or the transport of chemicals into, or out of, the red blood cell. In addition, they determine a person’s blood group.",
                RequiredSample = "",
                TestType = "",
                TestUnderPackage = { },
                Price = 10.00m,

            },
           new LabTestModel
            {
               Id="14",
                PackageName = "Sickling",
                TestDescription = "Sckling test is to screen for the presence of sickle cell trait or to confirm the presence of sickle cell disease. Blood is tested for the presence of haemoglobin S (HbS), which is a genetic variant of the protein haemoglobin. Haemoglobin is found inside red blood cells (RBCs) and is responsible for carrying oxygen from the lungs to all of the tissues and organs of the body.",
                RequiredSample = "",
                TestType = "",
                TestUnderPackage = { },
                Price = 15.00m,

            },
            new LabTestModel
            {
                Id="15",
                PackageName = "Erythrocyte Sedimation Rate (ESR)",
                TestDescription = "ESR is used to detect and monitor the activity of inflammation as an aid in the diagnosis of the underlying cause. Erythrocyte sedimentation rate (ESR) is an indirect measure of the degree of inflammation present in the body. It measures the rate of fall (sedimentation) of erythrocytes (red blood cells) in a tall, thin tube of blood. Results are reported as how many millimetres of clear plasma are present at the top of the column after one hour. Normally, red cells fall slowly, leaving little clear plasma. Increased blood levels of certain proteins (such as fibrinogen or immunoglobulins, which are increased in inflammation) cause the red blood cells to fall more rapidly, increasing the ESR. In large laboratories the ESR may be performed by an automated analyser.",
                RequiredSample = "Blood",
                TestType = "",
                TestUnderPackage = { },
                Price = 15.00m,

            },
           new LabTestModel
            {
               Id="16",
                PackageName = "Blood Film Examination (BF)",
                TestDescription = "BF is to determine if red blood cells, white blood cells, and platelets are normal in appearance and number; to distinguish between different types of white blood cells and to determine their relative percentages in the blood; to help diagnose a range of deficiencies, diseases, and disorders involving blood cell production, function and destruction; to monitor cell production and cell maturity in diseases such as leukaemia, during chemo/radiation therapy, or in the evaluation for haemoglobin variants",
                RequiredSample = "Blood",
                TestType = "",
                TestUnderPackage = { },
                Price = 15.00m,

            },
           new LabTestModel
            {
               Id="17",
                PackageName = "Glucose-6-phosphate dehydrogenase (G6PD) Test",
                TestDescription = "This test measures the amount of glucose-6-phosphate dehydrogenase (G6PD) in the red blood cells (RBCs). G6PD is an enzyme that protects red blood cells from the effects of oxidation. If there is insufficient G6PD, the RBCs become more vulnerable to oxidative damage. If these RBCs are exposed to an oxidative agent (for a list, click here), it changes their cellular structure, precipitating haemoglobin inside the cells (Heinz bodies), causing them to break apart (haemolysis).",
                RequiredSample = "Blood",
                TestType = "",
                TestUnderPackage = { },
                Price = 30.00m,

            },
             new LabTestModel
            {
                 Id="18",
                PackageName = "Pregnancy Test",
                TestDescription = "Starting approximately two weeks after conception, a hormone called human chorionic gonadatropin (hCG) hormone is produced by the developing placenta and can be detected in urine and in blood. This hCG detected in urine by home pregnancy test devices, which can be obtained from pharmacies and supermarkets. These are designed to detect hCG from about the time of the first missed period.",
                RequiredSample = "Urine",
                TestType = "",
                TestUnderPackage = { },
                Price = 20.00m,

            }

        };
        //Corona virus Test Center
        public List<CoronaVirusModel> TestCenterList { get; set; } = new List<CoronaVirusModel>();
        public List<CoronaVirusModel> TestCenters { get; set; } = new List<CoronaVirusModel>()
        {
            new CoronaVirusModel
            {
                 TestCenterName = "center A",
                 TestCenterAddress ="center A Address ",
                 TestCenterId  =   1,
                 TestCenterOpenningHours ="Monday, 10am to 18:30pm,Tuesday, 10am to 18:30pm,Wednesday, 10am to 18:30pm,Thursday, 10am to 18:30pm,Friday, 10am to 18:30pm",
                 TestCenterPhone = 0244778899,
            },
             new CoronaVirusModel
            {
                 TestCenterName = "center B",
                 TestCenterAddress ="center B Address ",
                 TestCenterId  =   1,
                 TestCenterOpenningHours ="Monday, 10am to 18:30pm,Tuesday, 10am to 18:30pm,Wednesday, 10am to 18:30pm,Thursday, 10am to 18:30pm,Friday, 10am to 18:30pm",
                 TestCenterPhone = 0244778899,
            },
              new CoronaVirusModel
            {
                 TestCenterName = "center C",
                 TestCenterAddress ="center C Address ",
                 TestCenterId  =   1,
                 TestCenterOpenningHours ="Monday, 10am to 18:30pm,Tuesday, 10am to 18:30pm,Wednesday, 10am to 18:30pm,Thursday, 10am to 18:30pm,Friday, 10am to 18:30pm",
                 TestCenterPhone = 0244778899,
            }
        };
        public List<CoronaVirusModel> GetTestCenters()
        {

            return TestCenters;
        }

        public int GetTestCenterCount()
        {
            return TestCenters.Count;
        }


        List<CoronaVirusModel> IItemsService.TestCenterList()
        {
            return TestCenters; 
        }

        //End Corona Virus Test center

        public List<LabTestModel> GetTestsList()
        {

            return TestList;
        }


        public void PostCheckoutItems(string[] ids)
        {
            CheckoutTestList.Clear();

            foreach (string id in ids)
            {
                var SelectedLabtest = TestList.Find(i => i.Id == id);
                              
                    CheckoutTestList.Add(SelectedLabtest);
                
            }
            
        }

        public List<LabTestModel> GetSelectedCheckoutItems()
        {

            return CheckoutTestList;
        }


        public int GetTestCount()
        {
            return CheckoutTestList.Count;
        }

        public decimal? GetTotalPriceOfTests()
        {
            return CheckoutTestList.Select(x => x.Price).Sum();
        }

        public void DeleteCheckoutItems(string id)
        {
            CheckoutTestList.Remove(CheckoutTestList.FirstOrDefault(i => i.Id == (id)));
        }


        public LabTestModel GetCheckoutItem(string id)
        {
            return TestList.FirstOrDefault(i => i.Id == id);
        }

        public void AddCheckoutItem(LabTestModel item)
        {
            CheckoutTestList.Add(item);
        }

        public List<LabTestModel> GetCheckoutItems()
        {
            throw new NotImplementedException();
        }

        public List<CoronaVirusModel> GetTestCenterList()
        {

            return TestCenters;
        }
    }
}
