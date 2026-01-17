using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    internal class array
    {
       static void Main(string[] args){
            int[] array = { 1, 2, 3};
            array[2] = 1;
            foreach (var i in array) { 
                Console.WriteLine(i);
            
            }
            string x = "hello world";
            
            Console.WriteLine(array.Contains(1));
              


        
       }
    }
}
