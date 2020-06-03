using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteveMontalvo_CE08
{
    class Program
    {
        static string DataFileFolder = @"..\..\Output";

        static void Main(string[] args)
        {

            DataFile1 data = new DataFile1();
            DataFile2 data2 = new DataFile2();
            DataFile3 data3 = new DataFile3();
            DataFieldLayout Layout = new DataFieldLayout();
            bool ProgramIsRunning = true;

            while (ProgramIsRunning)
            {
                Console.Clear();
                //Menu
                Console.WriteLine("------Menu------- \n");
                Console.WriteLine("1. DataFile1");
                Console.WriteLine("2. DataFile2");
                Console.WriteLine("3. DataFile3");
                Console.WriteLine("4. Exit \n");
                Console.Write("Please select one of the following files: ");
                string userinput = Console.ReadLine();
                userinput = ValidateUserResponse.IsNullOrWhiteSpace(userinput.ToLower());
                

                switch (userinput)
                {
                    case "1":
                    case "1.":
                    case "datafile1":
                    case "data file1":
                    case "datafile 1":
                    case "data file 1":
                        {
                            Console.WriteLine("You have selected to write File1.");
                            Directory.CreateDirectory(DataFileFolder);
                            SplitMethodFile1(data, Layout);
                            Utility.PauseBeforeContinuing();
                        }
                        break;
                    case "2":
                    case "2.":
                    case "datafile2":
                    case "data file2":
                    case "datafile 2":
                    case "data file 2":
                        {
                            Console.WriteLine("You have selected to write File2.");
                            Directory.CreateDirectory(DataFileFolder);
                            SplitMethodFile2(data2, Layout);
                            Utility.PauseBeforeContinuing();
                        }
                        break;
                    case "3":
                    case "3.":
                    case "datafile3":
                    case "data file3":
                    case "datafile 3":
                    case "data file 3":
                        {
                            Console.WriteLine("You have selected to write File3.");
                            Directory.CreateDirectory(DataFileFolder);
                            SplitMethodFile3(data3, Layout);
                            Utility.PauseBeforeContinuing();
                        }
                        break;
                    case "4":
                    case "4.":
                    case "exit":
                        {

                            Console.WriteLine("You have selected to exit the program");
                            Utility.PauseBeforeContinuing();
                            ProgramIsRunning = false;
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("Please select a valid menu option.");
                            Utility.PauseBeforeContinuing();
                        }
                        break;

                }
            }
        }

        public static void SplitMethodFile1(string [] File1, string [] Layout)
        {
            int i = 0;
            int j;
            string[] splitData;

           

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(DataFileFolder, "JsonFileDataFile1.json")))
            {
                while (i < File1.DataInfo.Length)
                {

                    splitData = File1.DataInfo[i].Split('|');
                    i++;
                    outputFile.WriteLine("[");
                    outputFile.WriteLine("{");
                    for (j = 0; j < splitData.Length;)
                    {
                        
                        outputFile.WriteLine('\u0022' + Layout.Lines[j] + '\u0022'+ ":" + '\u0022'+ splitData[j]+ '\u0022'+",");

                        j++;
                    }
                    outputFile.WriteLine("}");
                    outputFile.WriteLine("]");
                }
            }
        }
        public static void SplitMethodFile2(DataFile2 File2, DataFieldLayout Layout)
        {
            int i = 0;
            int j;
            string[] splitData;

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(DataFileFolder, "JsonFileDataFile2.json")))
            {
                while (i < File2.DataInfo.Length)
                {

                    splitData = File2.DataInfo[i].Split('|');
                    i++;
                    outputFile.WriteLine("[");
                    outputFile.WriteLine("{");
                    for (j = 0; j < splitData.Length;)
                    {

                        outputFile.WriteLine('\u0022' + Layout.Lines[j] + '\u0022' + ":" + '\u0022' + splitData[j] + '\u0022' + ",");

                        j++;
                    }
                    outputFile.WriteLine("}");
                    outputFile.WriteLine("]");
                }
            }
        }
        public static void SplitMethodFile3(DataFile3 File3, DataFieldLayout Layout)
        {
            int i = 0;
            int j;
            string[] splitData;

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(DataFileFolder, "JsonFileDataFile3.json")))
            {
                while (i < File3.DataInfo.Length)
                {

                    splitData = File3.DataInfo[i].Split('|');
                    i++;
                    outputFile.WriteLine("[");
                    outputFile.WriteLine("{");
                    for (j = 0; j < splitData.Length;)
                    {

                        outputFile.WriteLine('\u0022' + Layout.Lines[j] + '\u0022' + ":" + '\u0022' + splitData[j] + '\u0022' + ",");

                        j++;
                    }
                    outputFile.WriteLine("}");
                    outputFile.WriteLine("]");
                }
            }
        }
    }
}

