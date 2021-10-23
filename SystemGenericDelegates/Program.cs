using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemGenericDelegates
{
    class Program
    {
        static Func<int, string> PrintNumbersName = X =>
        {
            switch (X)
            {
                case 1: return "One";
                case 2: return "Two";

                case 3: return "Three";

                default:
                    throw new ArgumentException();
                    
            }
        };

        static void Main()
        {
            Console.WriteLine(   PrintNumbersName(5));
        }
    }
}
