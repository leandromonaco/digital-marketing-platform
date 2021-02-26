namespace DigitalMarketing.Model.Settings
{
    public class TenantServices
    {
        public SendGridConfiguration SendGrid { get; set; }
        public GoogleAnalyticsConfiguration GoogleAnalytics { get; set; }
        public GoogleRecaptchaConfiguration GoogleRecaptcha { get; set; }
    }
}