using System;

namespace AgilityManager.API.Model.SendGrid
{
    public class EmailEvent
    {
        public long EmailEventId { get; set; }
        public DateTime EventTime { get; set; }
        public string Email { get; set; }
        public string Event { get; set; }
        public int Id { get; set; }
        public string EventId { get; set; }
        public string Category { get; set; }
        public string IpAddress { get; set; }
        public string Reason { get; set; }
        public string MessageId { get; set; }
        public string SmtpId { get; set; }
        public string Status { get; set; }
        public int Timestamp { get; set; }
        public string Type { get; set; }
        public int Uid { get; set; }
        public string Url { get; set; }
        public string UserAgent { get; set; }
    }
}