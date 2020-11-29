using System;

namespace DigitalMarketing.Model.Events
{
    public class PersonalInformation
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
    }
}