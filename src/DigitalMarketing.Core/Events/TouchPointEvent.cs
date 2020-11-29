using System.Dynamic;

namespace DigitalMarketing.Model.Events
{
    public class TouchPointEvent
    {
        public TouchPointEvent()
        {
            PersonalInformation = new PersonalInformation();
            ContactInformation = new ContactInformation();
            CustomData = new ExpandoObject();
        }
        public string Source { get; set; }
        public TouchPointEventType EventType { get; set; }
        public PersonalInformation PersonalInformation { get; set; }
        public ContactInformation ContactInformation { get; set; }
        public ExpandoObject CustomData { get; set; }
    }
}
