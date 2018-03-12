using System;
using System.IO;

namespace Minifier
{
    class Program
    {
        static void Main(string[] args)
        {
            string spacing; // Task variable from config file
            string combination; // source combination variable
            bool whiteSpace = false; //keep whitespace
            bool appendAll = false; //merge all js files

            string currentDirectory = Directory.GetCurrentDirectory(); // Where is the program
            Console.WriteLine("The current directory is {0}", currentDirectory);
            string configFileName = currentDirectory + "\\combiner.conf"; // Get the file path
            Console.WriteLine("The file is at {0}", configFileName); // Where is the file

            //this doesn't work yet
            StreamReader configFile = new StreamReader(configFileName);
            spacing = configFile.ReadLine();
            combination = configFile.ReadLine();
            if (spacing.Contains("maintain_all_spacing"))
            {
                whiteSpace = true;
            }
            else if (spacing.Contains("collapse_whitespace"))
            {
                //removeWhiteSpace("filename");
            }


        }
    }
}
