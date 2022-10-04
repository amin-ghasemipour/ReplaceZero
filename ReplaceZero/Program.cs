using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceZero
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }


        /// <summary>
        /// Replce Zero in number by using DivideByZeroException
        /// </summary>
        private static void ConvertZeroToStar()
        {
            int number = 1050;
            string numberStr = number.ToString();
            string result = "";
            foreach (var chr in numberStr)
            {
                try
                {
                    var test = 1 / Convert.ToInt16(chr.ToString());
                    result += chr;
                }
                catch (DivideByZeroException)
                {
                    result += "*";
                }
            }
            Console.WriteLine(result);
        }

        /// <summary>
        /// Replce Zero in number by using Regex
        /// </summary>
        private static void ConvertZeroToStarByRegex()
        {
            int number = 1050;
            string numberStr = number.ToString();
            string result = Regex.Replace(numberStr, @"0", "*");
            Console.WriteLine(result);
        }
    }
}
