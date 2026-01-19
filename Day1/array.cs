using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    internal class array
    {
       static void main(string[] args){
            int[] array = { 1, 2, 3};
            array[2] = 1;
            foreach (var i in array) { 
                Console.WriteLine(i);
            
            }
            string x = "           hello world";
            string reversed = new string(x.Reverse().ToArray());
            x.Trim();
            Console.WriteLine(int.MinValue );
            Math.Exp(2);
            
            Console.WriteLine(x);
            Console.WriteLine(int.TryParse("     -4", out int result) );


            int[] test = new int[] { 11, 1, 2, 4, 5 };
            Array.Sort(test);
            foreach (var i in test) {
                Console.Write($" {i},");
            }

        }
    }
}
