using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Land_Explorer.Tasks
{
    
    public class FilterDestinations
    {
         public static void printLessthan100(List<Category> categories, Predicate<int> IsLessThan100)
        {
              Action<string> printnamedelegate = printname;
               var destinations = categories.SelectMany(e => e.destinations).ToList();   // to store all destination 
                
            Console.WriteLine();
            foreach (var category in destinations)
              {
                if ((int.TryParse(category.duration?.Split(" ")[0],
                        out int duration)
                        && IsLessThan100(duration))
                        || category.duration == null)   // to check if destination.duration less than 100 or more than 100 or null
                {
                    printnamedelegate(category.name);
                }
              }
        }

         

        private static void printname(string name) // TO Print the name of destination
        {
            Console.WriteLine(name);
        }
    }


}
