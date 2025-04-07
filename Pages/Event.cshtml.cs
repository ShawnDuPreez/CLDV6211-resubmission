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

        public void OnGet() { }

        public IActionResult OnPost()
        {
            // Here you can add logic to save the event to the database using your DbContext.
            return Page();
        }
    }
}
