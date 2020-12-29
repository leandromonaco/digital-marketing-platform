using System;
using System.IO;

namespace DigitalMarketing.Tools.WebPConverter
{
    /// <summary>
    /// https://developers.google.com/speed/webp/docs/using
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var filenames = Directory.GetFiles(args[0]);
            foreach (var filename in filenames)
            {
                FileInfo fileInfo = new FileInfo(filename);
                if (fileInfo.Extension.Equals(".jpg") || fileInfo.Extension.Equals(".png"))
                {
                    string strCmdText;
                    strCmdText = @$"-q 20 ""{filename}"" -o ""{fileInfo.DirectoryName}\{fileInfo.Name.Replace(fileInfo.Extension, ".webp")}""";
                    System.Diagnostics.Process.Start($"{Environment.CurrentDirectory}\\WebP_Converter\\tools\\cwebp.exe", strCmdText);
                }
            }

        }
    }
}
