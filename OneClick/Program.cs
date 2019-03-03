using System;
using System.IO;

namespace OneClick
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Installing...");

            var vsTemplatesDir = $"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\\Documents\\Visual Studio 2017\\Templates\\ItemTemplates\\Visual C#";
            var oneClickTemplatesDir = $"{vsTemplatesDir}\\OneClick";
            var commandTemplateZip = "Command.zip";

            if (Directory.Exists(vsTemplatesDir))
            {
                Directory.CreateDirectory(oneClickTemplatesDir);

                File.Copy(
                    sourceFileName: $"{AppDomain.CurrentDomain.BaseDirectory}\\{commandTemplateZip}",
                    destFileName: $"{oneClickTemplatesDir}\\{commandTemplateZip}",
                    overwrite: true);

                Console.WriteLine("Command template Installed!");

                Console.WriteLine("Installation completed. Please restart your VisualStudio!");
            }
            else
            {
                Console.WriteLine("Installation failed. Could not locate VisualStudio templates directory");
            }

            Console.ReadKey();
        }
    }
}
