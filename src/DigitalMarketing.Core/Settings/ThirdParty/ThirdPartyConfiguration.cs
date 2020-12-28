namespace DigitalMarketing.Model.Settings
{
    public class ThirdPartyConfiguration
    {
        public SendGridConfiguration SendGrid { get; set; }
        public GoogleAnalyticsConfiguration GoogleAnalytics { get; set; }
        public GoogleRecaptchaConfiguration GoogleRecaptcha { get; set; }
    }
}