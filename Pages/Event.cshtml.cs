using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace CLDV6211_ST10294003.Pages
{
    public class EventModel : PageModel
    {
        [BindProperty]
        public string EventName { get; set; }

        [BindProperty]
        public DateTime EventDate { get; set; }

        [BindProperty]
        public string Description { get; set; }

        public void OnGet()
        {
            // Handles GET requests for the event page (e.g., display form or data)
        }

        public IActionResult OnPost()
        {
            // Handles POST requests to create a new event (form submission)
            return Page();
        }
    }
}
//(Microsoft, 2024 (Razor Pages); Troelsen & Japikse, 2022)
// See references in Program.cs