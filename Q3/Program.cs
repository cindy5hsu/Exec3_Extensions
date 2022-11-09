using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{   
    //將List<string> 轉為 int[]
    internal class Program
    {
      
             static void Main(string[] args)
             {
                  string value = "123";
                  int number = value.ToInt(-1);// 若轉型失敗, 傳回-1
                  Console.WriteLine(number); // 123

                  value = "1ABC";
                  number = value.ToInt(-1); // 若轉型失敗, 傳回-1
                  Console.WriteLine(number); // -1
             }
    
    }
    public static class stringExtensions
    {
        public static int ToInt(this string sourcr, int defaulValue)//擴充方法 轉不成功 傳回 defaulValue
        {
            bool isInt = int.TryParse(sourcr, out int number);

            return isInt ? number : defaulValue;
        }
    }
}

