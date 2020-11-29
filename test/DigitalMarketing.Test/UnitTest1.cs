using DigitalMarketing.Model.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.IO;

namespace DigitalMarketing.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            byte[] bytes = File.ReadAllBytes(@"D:\Build\AgilityManager\Web\Website\wwwroot\tenants\arystec\images\arystec-cover.webp");
            string file = Convert.ToBase64String(bytes);

            //And correspondingly, read back to file:

            //byte[] bytes = Convert.FromBase64String(b64Str);
            //File.WriteAllBytes(path, bytes);
        }

        [TestMethod]
        public void UpdateHostFile()
        {
            //C:\Windows\System32\drivers\etc\hosts
            //Run as admin
            using (StreamWriter w = File.AppendText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "drivers/etc/hosts")))
            {
                //w.WriteLine("127.0.0.1 softwareworker.com");
                //w.WriteLine("127.0.0.1 aiswalker.softwareworker.com");
                //w.WriteLine("127.0.0.1 protechexteriors.softwareworker.com");
                //w.WriteLine("127.0.0.1 arystec.softwareworker.com");
                w.WriteLine("127.0.0.1 local.softwareworker.com");
            }
        }

        [TestMethod]
        public void DeserializeConfig()
        {
            string json = null;
            using (StreamReader r = new StreamReader(@"D:\Build\AgilityManager\DigitalMarketing\DigitalMarketing.Configuration\example.tenant.json"))
            {
                json = r.ReadToEnd();
            }
            var parsedConfig = JsonConvert.DeserializeObject<TenantConfigurationModel>(json);
        }

        //TODO: Add script to setup dependencies
        //docker run -e "ACCEPT_EULA=Y" --name "sw-sql" -e "SA_PASSWORD=S0ftw4r3W0rk3r" -p 1433:1433 -d mcr.microsoft.com/mssql/server:2019-latest
    }


}
