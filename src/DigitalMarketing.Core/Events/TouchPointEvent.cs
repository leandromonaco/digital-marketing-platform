using System;
using System.Dynamic;

namespace DigitalMarketing.Model.Events
{
    public class TouchPointEvent
    {
        public TouchPointEvent()
        {
            CustomData = new ExpandoObject();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Source { get; set; }
        public TouchPointEventType EventType { get; set; }
        public string Message { get; set; }
        public ExpandoObject CustomData { get; set; }
        
    }
}
