using System;
using System.IO;

namespace OneClick
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Installing...");

            var vsItemTemplatesDir = $"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\\Documents\\Visual Studio 2017\\Templates\\ItemTemplates\\Visual C#";
            var vsProjectTemplatesDir = $"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\\Documents\\Visual Studio 2017\\Templates\\ProjectTemplates\\Visual C#";
            var oneClickItemTemplatesDir = $"{vsItemTemplatesDir}\\OneClick";
            var oneClickSolutionTemplatesDir = $"{vsProjectTemplatesDir}\\OneClick\\Solution templates";
            var commandTemplateZip = "Command.zip";
            var queryTemplateZip = "Query.zip";
            var requestTemplateZip = "Request.zip";
            var handlerTemplateZip = "Handler.zip";
            var quickSliceFrameworkConsoleTemplateZip = "QuickSliceNetFrameworkConsole.zip";

            if (Directory.Exists(vsItemTemplatesDir) &&
                Directory.Exists(vsProjectTemplatesDir))
            {
                Directory.CreateDirectory(oneClickItemTemplatesDir);
                Directory.CreateDirectory(oneClickSolutionTemplatesDir);

                File.Copy(
                    sourceFileName: $"{AppDomain.CurrentDomain.BaseDirectory}\\{quickSliceFrameworkConsoleTemplateZip}",
                    destFileName: $"{oneClickSolutionTemplatesDir}\\{quickSliceFrameworkConsoleTemplateZip}",
                    overwrite: true);

                Console.WriteLine("QuickSlice .NET Framework console solution template Installed!");

                File.Copy(
                    sourceFileName: $"{AppDomain.CurrentDomain.BaseDirectory}\\{commandTemplateZip}",
                    destFileName: $"{oneClickItemTemplatesDir}\\{commandTemplateZip}",
                    overwrite: true);

                Console.WriteLine("Command template Installed!");

                File.Copy(
                    sourceFileName: $"{AppDomain.CurrentDomain.BaseDirectory}\\{queryTemplateZip}",
                    destFileName: $"{oneClickItemTemplatesDir}\\{queryTemplateZip}",
                    overwrite: true);

                Console.WriteLine("Query template Installed!");

                File.Copy(
                    sourceFileName: $"{AppDomain.CurrentDomain.BaseDirectory}\\{requestTemplateZip}",
                    destFileName: $"{oneClickItemTemplatesDir}\\{requestTemplateZip}",
                    overwrite: true);

                Console.WriteLine("Request template Installed!");

                File.Copy(
                    sourceFileName: $"{AppDomain.CurrentDomain.BaseDirectory}\\{handlerTemplateZip}",
                    destFileName: $"{oneClickItemTemplatesDir}\\{handlerTemplateZip}",
                    overwrite: true);

                Console.WriteLine("Handler template Installed!");

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
