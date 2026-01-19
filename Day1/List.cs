using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    internal class List
    {
        static void Main(string[] args)
        {
            List <int> nums = new List <int>();
            nums.Add (1);
            nums.Add (2);
          
            Console.WriteLine(nums.Average());
            nums.ForEach( x =>
            {
                Console.WriteLine(x);
            });

        }
    }
}
