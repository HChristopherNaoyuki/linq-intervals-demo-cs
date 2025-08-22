using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq_intervals_demo_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            var items = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            var even_items = items.NewWhere(x => x % 2 == 0);

            foreach(var item in even_items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
