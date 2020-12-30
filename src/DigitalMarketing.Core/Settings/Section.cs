using System.Collections.Generic;

namespace DigitalMarketing.Model.Settings
{
    public class Section
    {
        public string Type { get; set; }
        public string Layout { get; set; }
        public string Theme { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Paragraph { get; set; }
        public string BackgroundImage { get; set; }
        public string BackgroundVideo { get; set; }
        public string ButtonText { get; set; }
        public string DownloadFile { get; set; }
        public string Date { get; set; }
        public string Url { get; set; }
        public List<Testimonial> Testimonials { get; set; }
        public List<AccordionItem> AccordionItems { get; set; }
        public List<string> Images { get; set; }
        public Workflow Workflow { get; set; }
    }
}