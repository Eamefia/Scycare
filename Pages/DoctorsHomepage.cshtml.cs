using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Scycare.Web.Pages.Models;

namespace Scycare.Web.Pages
{
    public class DoctorsHomepageModel : PageModel
    {
        public List<AccordionElement> accordionElements = new List<AccordionElement>{
        new AccordionElement
        {
            Title ="Who is an online doctor",
            Details =  "",
        },
        new AccordionElement
        {
            Title ="How does the online consultation works",
            Details =   "When you send email or other communications to us, we may retain those communications in order to process your requests and improve the quality of our services.",
        },
        new AccordionElement
        {
            Title ="Can I test Scycare free of charge",
             Details ="Information such as creating entries, editing entries and uploading media to the App are collected automatically on our server when you access the App. As such, we may also request access to your device's camera in order for us to upload your media to the App. Any media uploaded , will be collected and stored on our servers. If you wish to change our access or permissions, you may do so in your device settings",
        },
        new AccordionElement
        {
            Title ="When can I test",
            Details =   "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."
        },
    };
        public void OnGet()
        {
        }
    }
}
