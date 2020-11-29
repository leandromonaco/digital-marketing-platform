using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace DigitalMarketing.Web.Model
{
    /// <summary>
    /// https://github.com/sample-by-jsakamoto/Blazor-UseGoogleReCAPTCHA/blob/master/BlazorServerEdition/Server/SampleAPI.cs
    /// </summary>
    public class reCaptchaValidator
    {
        private IHttpClientFactory HttpClientFactory { get; }

        private IOptionsMonitor<reCAPTCHAVerificationOptions> reCAPTCHAVerificationOptions { get; }

        public reCaptchaValidator(IHttpClientFactory httpClientFactory, IOptionsMonitor<reCAPTCHAVerificationOptions> reCAPTCHAVerificationOptions)
        {
            this.HttpClientFactory = httpClientFactory;
            this.reCAPTCHAVerificationOptions = reCAPTCHAVerificationOptions;
        }

        public static async Task<reCAPTCHAVerificationResponse> Validate(string reCAPTCHAResponse)
        {
            var url = "https://www.google.com/recaptcha/api/siteverify";
            var content = new FormUrlEncodedContent(new Dictionary<string, string>
            {
                {"secret", "6Ldau70ZAAAAANsmydONheCoY02xovNm5nmsv9Fb"},
                {"response", reCAPTCHAResponse}
            });

            var httpClient = new HttpClient();
            var response = await httpClient.PostAsync(url, content);
            response.EnsureSuccessStatusCode();

            var verificationResponse = await response.Content.ReadAsAsync<reCAPTCHAVerificationResponse>();
            return verificationResponse;
        }
    }
}
