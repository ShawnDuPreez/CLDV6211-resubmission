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

        public void OnGet() { }

        public IActionResult OnPost()
        {
            // Here you can add logic to save the venue to the database using your DbContext.
            return Page();
        }
    }
}
