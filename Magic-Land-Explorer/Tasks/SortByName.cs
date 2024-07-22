using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Land_Explorer.Tasks
{
    internal class SortByName
    {
        public static void SortingByName(List<Category> categories)
        {
            var SortedElementByName = categories.SelectMany(e => e.destinations).OrderBy(e => e.name);

            foreach (var item in SortedElementByName)
            {
                Console.WriteLine(item.name);
            }

        }
    }
}
