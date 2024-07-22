using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Land_Explorer.Tasks
{
    internal class LongestDuration
    {
        public static void PrintLongestDuration(List<Category> categories)
        {
              string? LongestDuration = categories.SelectMany(e =>e.destinations).OrderByDescending(e => {  // to ordered from bigges to smallest
                  
                  var Duration = 0;
                  var FromSmallestToBiggest = int.TryParse(e.duration?.Split(" ")[0],out Duration);
                  return Duration;                      
                  
                 }).FirstOrDefault()?.name; 


            Console.WriteLine(LongestDuration);
        }

    }
}

