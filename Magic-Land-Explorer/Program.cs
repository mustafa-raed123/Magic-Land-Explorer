using Magic_Land_Explorer.Tasks;
using System.Diagnostics.Metrics;
using System.Text.Json;
using static Magic_Land_Explorer.Program;

namespace Magic_Land_Explorer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data", "jsconfig1.json");
            List<Category>? categories = new List<Category>();
            if (File.Exists(jsonFilePath))
            {
                string jsonstring = File.ReadAllText(jsonFilePath);
                categories = JsonSerializer.Deserialize<List<Category>>(jsonstring);
            }
            else 
            {
                Console.WriteLine("File not found");
                return;
            }

            while (true)
            {
            Console.WriteLine("Please Enter the Number");
            Console.WriteLine("1- Destinations with duration less than 100 minutes:");
            Console.WriteLine("2- Destination with the longest duration:");
            Console.WriteLine("3- Sorting by name");
            Console.WriteLine("4- Top 3 longest-duration destinations:");
            Console.WriteLine("5- Exit");
               
                if (int.TryParse(Console.ReadLine(), out int Choice))
                {
                    switch (Choice) {
                        case 1:
                            Console.WriteLine();
                            Console.WriteLine(" Destinations with duration less than 100 minutes:");
                            Console.WriteLine();
                            FilterDestinations.printLessthan100(categories, duration => duration < 100);
                            Console.WriteLine();
                            break;
                            case 2:

                            Console.WriteLine();
                            Console.WriteLine(" Destination with the longest duration:");
                            Console.WriteLine();
                            LongestDuration.PrintLongestDuration(categories);
                            Console.WriteLine();
                            break;
                        case 3:
                            Console.WriteLine();
                            Console.WriteLine(" Sorting by name");
                            Console.WriteLine();
                            SortByName.SortingByName(categories);
                            Console.WriteLine();
                            break;
                            case 4:
                    Console.WriteLine();
                    Top3Duration.TopThreeDuration(categories);
                            break;
                            case 5:
                            return;
                        default:
                            Console.WriteLine("please Enter A Currect number");
                            break;                  
                }
                    }else {

                    Console.WriteLine("please Enter A Number ");
                    }
            }
        }
        //private static List<Category> GetDataFromJson()
        //{
        //    string jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data", "jscofig1.json");
        //    var categories = new List<Category>();
        //    if (File.Exists(jsonFilePath))
        //    {
        //        string jsonstring = File.ReadAllText(jsonFilePath);
        //        categories = JsonSerializer.Deserialize<List<Category>>(jsonstring);
        //    }
        //    else
        //    {
        //        Console.WriteLine("File not found");
        //    }
        //    return categories;
        //}

     

    }
}
