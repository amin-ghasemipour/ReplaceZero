using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ReplaceZero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string result = ConvertZeroToStar(1050);
            Console.WriteLine($"result of {nameof(ConvertZeroToStar)}:{result}");

            result = ConvertZeroToStarByRegex(1050);
            Console.WriteLine($"result of {nameof(ConvertZeroToStarByRegex)}:{result}");
            Console.ReadKey();
        }


        /// <summary>
        /// Replce Zero in number by using DivideByZeroException
        /// </summary>
        private static string ConvertZeroToStar(int number)
        {
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
            return result;
        }

        /// <summary>
        /// Replce Zero in number by using Regex
        /// </summary>
        private static string ConvertZeroToStarByRegex(int number)
        {
            string numberStr = number.ToString();
            string result = Regex.Replace(numberStr, @"0", "*");
            return result;
        }
    }
}
