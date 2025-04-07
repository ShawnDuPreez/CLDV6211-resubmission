﻿using System;

namespace CLDV6211_ST10294003.Models
{
    public class Booking
    {
        public int BookingId { get; set; }
        public int EventId { get; set; }
        public int VenueId { get; set; }
        public DateTime BookingDate { get; set; }

        // Navigation properties
        public Event Event { get; set; }
        public Venue Venue { get; set; }
    }
}
