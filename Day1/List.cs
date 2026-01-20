using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    internal class List
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>();
            nums.Add(1);
            nums.Add(2);
            String name = "hello wrold";
            Console.WriteLine(name.Reverse().ToArray().ToString());
            Console.WriteLine(nums.Average());


            List<List<int>> grid = new List<List<int>>();
            Console.WriteLine(grid.GetType());


            grid.Add(new List<int> { 1, 2, 3 });
            foreach (var row in grid) {
                
                foreach (var col in row)
                {
                    Console.Write(col);
                }

            }

            Console.WriteLine("count" + grid.Count);
            int[][] arr = new int[][] { 
                new int[] { 10, 2,3 },
                new int[] { 5, 6, 7 }
            } ;

            Array.Sort(arr, (a, b) => a[0].CompareTo(b[0]));
            foreach (var item in arr)
            {
                foreach (var col in item)
                {
                    Console.Write(col);
                }
                Console.WriteLine();
            }

            Console.WriteLine(char.is);

            //nums.ForEach( x =>
            //{
            //    Console.WriteLine(x);
            //});

        }
    }
}
