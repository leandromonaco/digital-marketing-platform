using System;
using System.Collections.Generic;

namespace DigitalMarketing.Model.Database
{
    public partial class Touchpoint
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public bool IsEmailDelivered { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
