using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CLDV6211_ST10294003.Pages
{
    public class VenueModel : PageModel
    {
        [BindProperty]
        public string VenueName { get; set; }

        [BindProperty]
        public string Location { get; set; }

        [BindProperty]
        public int Capacity { get; set; }

        public void OnGet()
        {
            // Handles GET requests for the venue page (e.g., display form)
        }

        public IActionResult OnPost()
        {
            // Handles POST requests to process venue creation or updates
            return Page();
        }
    }
}
//(Microsoft, 2024 (Razor Pages); Troelsen & Japikse, 2022)
// See references in Program.cs
