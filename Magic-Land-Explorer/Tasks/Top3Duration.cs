using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Land_Explorer.Tasks
{
    public class Top3Duration
    {
        public static void TopThreeDuration(List<Category> categories)
        {
            var LongestDuration = categories.SelectMany(e => e.destinations).OrderByDescending(e => {

                var Duration = 0;
                var ConvertToInt = int.TryParse(e.duration?.Split(" ")[0], out Duration);
                return Duration;

               }).Take(3);

            foreach (var category in LongestDuration) {
                Console.WriteLine($"{ category.name} : {category.duration} ");
                Console.WriteLine( );
            }
        }
    }
}
