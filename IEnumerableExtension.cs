using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq_intervals_demo_cs
{
    public static class IEnumerableExtension
    {
        public static IEnumerable<T> NewWhere<T>(
            this IEnumerable<T> items, Func<T, bool> predicate)
        {
            var list = new List<T>();

            foreach(var item in items)
            {
                if(predicate(item))
                {
                    yield return item;
                }
            }
        }
    }
}
