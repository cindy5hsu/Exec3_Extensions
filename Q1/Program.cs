using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class Program
    {
        //class program
        //{
            

            static void Main(string[] args)
            {
                //test
                int num = 15;
                if (IsoddorIseven.IsOdd(num))
                {
                    Console.WriteLine(num + "is odd");
                }
                else if (IsoddorIseven.IsEven(num))
                {
                    Console.WriteLine(num + "is even.");
                }

            }
        //}
    }
    public static class IsoddorIseven
    {
            public static bool IsOdd(int value)
            {
                return value % 2 != 0;
            }
            public static bool IsEven(int value)
            {
                return value % 2 == 0;
            }
    }
 }

