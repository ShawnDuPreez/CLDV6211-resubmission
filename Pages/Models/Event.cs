using System;

namespace CLDV6211_ST10294003.Models
{
    // Represents an event with its details (name, date, description).
    public class Event
    {
        public int EventId { get; set; }
        public string EventName { get; set; }
        public DateTime EventDate { get; set; }
        public string Description { get; set; }
    }
}
