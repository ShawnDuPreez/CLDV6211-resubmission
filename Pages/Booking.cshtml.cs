using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CLDV6211_ST10294003.Pages
{
    public class BookingModel : PageModel
    {
        [BindProperty]
        public string CustomerName { get; set; }

        [BindProperty]
        public string EventName { get; set; }

        [BindProperty]
        public int NumTickets { get; set; }

        public void OnGet()
        {
            // Handles GET requests for the booking page (e.g., display form)
        }

        public IActionResult OnPost()
        {
            // Handles POST requests to process a booking submission
            return Page();
        }
    }
}

// See references in Program.cs
//(Microsoft, 2024 (Razor Pages); Troelsen & Japikse, 2022)