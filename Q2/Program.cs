using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Program
    {
        class program
        {
            static void Main(string[] args)
            {

                program pg = new program();
                //calll method
                Console.WriteLine("Enter a string : ");


                string str = Console.ReadLine();
                Console.WriteLine("Enter number of character : ");

                int num = int.Parse(Console.ReadLine());//disPlay result

                Console.WriteLine("Output : " + pg.Left(str, num));
            }
            //return left path of a string
            
               
       
            public string Left(string str, int num)
            {
                //if string is empty or null
                if (string.IsNullOrEmpty(str)) 
                { 
                    return ""; 
                }
                //if number of characters is less than or equal to 0 
                if(num <= 0)
                {
                    return "";
                }
                //if number of characters is more than length of string
                if(num >= str.Length) 
                { 
                    return str; 
                }
                //return required part of string
              return str.Substring(0,num);
            }
        }
    }
}
