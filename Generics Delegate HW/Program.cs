using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Delegate_HW
{
    //public delegate void MyAction<in T1>(T1 t1);
    
    //public delegate void MyAction<in T1, in T2>(T1 t1, T2 t2);
    //public delegate void MyAction<in T1, in T2, in T3>(T1 t1, T2 t2, T3 t3);
    class Program
    {
        public static  Func<int, int, int,int> myAction1 = (a, b, c) => Math.Min(a, Math.Min(b, c));
        public static Func<double, double, double, double> myAction2 = (a, b, c) => (a + b + c) / 3;
        public static Action< string> myAction3 = (a) =>
        {
            middle(a);
        };

        public static Action<string> myAction4 = (a)=>
            {
                count_Vowels(a);
            };

        public static Action<string> myAction5 = (a) =>
        {
            CountAllWord(a);
        };
        public static Action<int> myAction6 = (a) =>
        {
            SumOfDigit(a);
        };

        static void Main(string[] args)
        {
            #region q1

            
            Console.WriteLine("The smallest value is " + myAction1(25,37,29 ));


            #endregion

            #region q2

            Console.WriteLine("The avarage is: " + myAction2(25,45,65));

            #endregion

            #region q3

            Console.WriteLine(middle("350"));

            #endregion

            #region q4
            Console.WriteLine("number of Vowels is " + (count_Vowels("w3resource")));

            #endregion

            #region q5
            string sentence = "The quick brown fox jumps over the lazy dog";
            Console.WriteLine("number of Word is " + (CountAllWord(sentence))); ;

            #endregion

            #region q6
            int n = 85;
            Console.WriteLine("Sum of digit is " + SumOfDigit(n));

            #endregion
        }
        public static String middle(String str)
        {
            int position;
            int length;
            if (str.Length % 2 == 0)
            {
                position = str.Length / 2 - 1;
                length = 2;
            }
            else
            {
                position = str.Length / 2;
                length = 1;
            }
            return str.Substring(position,  length);
        }
        public static int count_Vowels(String str)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i]==('a')|| str[i] == ('e') || str[i] == ('i')
                        || str[i] == ('o') || str[i] == ('u'))
                {
                    count++;
                }
            }
            return count;
        }

        public static int CountAllWord (String str)
        {
            int countWord = 0;
            
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == ' ')
                    {
                    countWord++;
                    }
                }
                countWord = countWord + 1;
            
            return countWord; // returns 0 if string starts or ends with space " ".
        }
        
        public static int SumOfDigit(int n)
        {
            int result = 0;

            while (n > 0)
            {
                result += n % 10;
                n /= 10;
            }

            return result;
        }
    }
}
