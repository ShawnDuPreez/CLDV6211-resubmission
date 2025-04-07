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
        }

        public IActionResult OnPost()
        {
            // Handle booking submission logic here
            return Page();
        }
    }
}
