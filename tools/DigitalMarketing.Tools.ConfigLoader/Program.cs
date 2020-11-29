using System;
using System.IO;

namespace DigitalMarketing.Tools.ConfigLoader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //D:\Build\AgilityManager\DigitalMarketing\DigitalMarketing.Web\wwwroot\video\video.webm
            //D:\Build\AgilityManager\Web\Website\wwwroot\tenants\arystec\images\arystec-cover.webp
            byte[] bytes = File.ReadAllBytes(@"D:\Build\AgilityManager\DigitalMarketing\DigitalMarketing.Web\wwwroot\tenants\arystec\images\arystec-cover.webp");
            string file = Convert.ToBase64String(bytes);
        }
    }
}
