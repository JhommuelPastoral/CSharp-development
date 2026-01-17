using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Using System accessing the Console.Write, without it, we to use System.Console


// DATA TYPES
// long = 900L, putting L means, we are declaring this number is a long number which is int64


/*
 .ToString(), Format Parameters
    C = Currency
    D = Decimal
    E = Exponential
    F = Fixed Point 
    G = General 
    N = Number (Group Separator) ex 1234.56 = N3 = 1,234,560
    P = Percent
    
 
 */


namespace Day1
{
    internal class Day2
    {
        static void Main(string[] args)
        {
            double age = 1234123.560;
            int t = 10;
            //Console.WriteLine(age.ToString().GetType());
            Console.WriteLine(Convert.ToString(t,2));
            Console.WriteLine(age.ToString("N2") );
            Console.WriteLine("Hello World");

            //try
            //{
            //    int test = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine(test);
            //}
            //catch (Exception e) {
            //    Console.WriteLine($"{e.ToString()}  Error1231232");
            //}
            string txtNum = "asd";
            if(int.TryParse(txtNum, out int result))
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Not A valid");
            }
        }

    }
}
