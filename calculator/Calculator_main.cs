using System;
using Calc_Funcs;

namespace Claculator
{
    internal class Calculator_main
    {
        static void Main(string[] args)
        {
            dynamic result1 =Perform_Calc.Perform_Add(7, 7);
            dynamic result2 = Perform_Calc.Perform_Add("9", 3.5);
            dynamic result3 = Perform_Calc.Perform_Add("rohan", "ankit");
            dynamic result5 = Perform_Calc.Perform_Add("" , 12);
            Console.WriteLine(result5);
            Console.WriteLine(result3);
           Console.WriteLine(result1);
            Console.WriteLine(result2);

           dynamic result4 = Perform_Calc.Perform_Sub(7, 7);
            Console.WriteLine(result4);


            Console.ReadKey();
        }
    }
}
