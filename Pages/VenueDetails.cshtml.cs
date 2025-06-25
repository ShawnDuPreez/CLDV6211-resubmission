using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CLDV6211_ST10294003.Pages
{
    public class VenueDetailsModel : PageModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string Price { get; set; }

        public void OnGet(int id)
        {
            // Hard-coded data for demonstration
            // Switch block to set venue details based on ID
            switch (id)
            {
                // Case for venue ID 1: Grand Hall
                case 1:
                    Name = "Grand Hall";
                    Description = "A luxurious hall perfect for weddings and large events.";
                    ImageUrl = "https://www.wheresmywedding.co.za/sites/default/files/images/blog/Shepstone-Gardens-Wedding-Venue-Johannesburg-Gauteng-Reception-Glass-Marquee_0.jpg";
                    Price = "R25,000 per day";
                    break;

                // Case for venue ID 2: Riverside Venue
                case 2:
                    Name = "Riverside Venue";
                    Description = "Beautiful riverside views ideal for outdoor events.";
                    ImageUrl = "https://www.conferences.co.za/images/riverside-sun-01-786x416.jpg";
                    Price = "R18,000 per day";
                    break;

                // Case for venue ID 3: Mountain Venue
                case 3:
                    Name = "Mountain Venue";
                    Description = "Fancy venue for the perfect wedding.";
                    ImageUrl = "https://thewed.com/storage/blog-uploads/2021/April/desktop-retina/QQ8UerC9xX5iM1hhKroX.jpg";
                    Price = "R15,000 per day";
                    break;

                // Default case for invalid or missing venue ID
                default:
                    Name = "Venue not found";
                    Description = "The venue you requested was not found.";
                    ImageUrl = "https://via.placeholder.com/800x400?text=Not+Found";
                    Price = "-";
                    break;
            }
        }
        //(Microsoft, 2024 (Razor Pages); Troelsen & Japikse, 2022)
    }
}
