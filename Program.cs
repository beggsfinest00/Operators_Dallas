using System;

namespace Operators_Dallas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("int");
            //multiplies
            int intMult = 6 * 45;
            // adds
            int intAdd = 6 + 45;
            //displays
            Console.WriteLine($"the max of {intMult} and {intAdd} is {Math.Max(intMult, intAdd)}." +
                $"the min of {intMult} and {intAdd} is {Math.Min(intMult, intAdd)}.");
            
            //Greater?
            bool isIntGreater = intMult > intAdd;
            Console.WriteLine($"{intMult} is greater than {intAdd}, {isIntGreater}.");

            Console.WriteLine("short");
            //multiplies
            short shortMult = 6 * 45;
            // adds
            short shortAdd = 6 + 45;
            //displays
            Console.WriteLine($"the max of {shortMult} and {shortAdd} is {Math.Max(shortMult, shortAdd)}." +
                $"the min of {shortMult} and {shortAdd} is {Math.Min(shortMult, shortAdd)}.");

            //Greater?
            bool isshortGreater = shortMult > shortAdd;
            Console.WriteLine($"{shortMult} is greater than {shortAdd}, {isshortGreater}.");

            Console.WriteLine("long");
            //multiplies
            long longMult = 6 * 45;
            // adds
            long longAdd = 6 + 45;
            //displays
            Console.WriteLine($"the max of {longMult} and {longAdd} is {Math.Max(longMult, longAdd)}." +
                $"the min of {longMult} and {longAdd} is {Math.Min(longMult, longAdd)}.");

            //Greater?
            bool islongGreater = longMult > longAdd;
            Console.WriteLine($"{longMult} is greater than {longAdd}, {islongGreater}.");

            Console.WriteLine("float");
            //multiplies
            float floatMult = 6 * 45.5f;
            // adds
            float floatAdd = 6 + 45.5f;
            //displays
            Console.WriteLine($"the max of {floatMult} and {floatAdd} is {Math.Max(floatMult, floatAdd)}." +
                $"the min of {floatMult} and {floatAdd} is {Math.Min(floatMult, floatAdd)}.");

            //Greater?
            bool isfloatGreater = floatMult > floatAdd;
            Console.WriteLine($"{floatMult} is greater than {floatAdd}, {isfloatGreater}.");

            Console.WriteLine("double");
            //multiplies
            double doubleMult = 6 * 45.5;
            // adds
            double doubleAdd = 6 + 45.5;
            //displays
            Console.WriteLine($"the max of {doubleMult} and {doubleAdd} is {Math.Max(doubleMult, doubleAdd)}." +
                $"the min of {doubleMult} and {doubleAdd} is {Math.Min(doubleMult, doubleAdd)}.");

            //Greater?
            bool isdoubleGreater = doubleMult > doubleAdd;
            Console.WriteLine($"{doubleMult} is greater than {doubleAdd}, {isdoubleGreater}.");

            Console.WriteLine("decimal");
            //multiplies
            decimal decimalMult = (decimal)(6 * 45.5);
            // adds
            decimal decimalAdd = (decimal)(6 + 45.5);
            //displays
            Console.WriteLine($"the max of {decimalMult} and {decimalAdd} is {Math.Max(decimalMult, decimalAdd)}." +
                $"the min of {decimalMult} and {decimalAdd} is {Math.Min(decimalMult, decimalAdd)}.");

            //Greater?
            bool isdecimalGreater = decimalMult > decimalAdd;
            Console.WriteLine($"{decimalMult} is greater than {decimalAdd}, {isdecimalGreater}.");
        }
    }
    }
