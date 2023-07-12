using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            /*  string str;
              bool res;
              Console.WriteLine("Enter string");
              str = Console.ReadLine();
              int num;
              res = Int32.TryParse(str, out num);
              if (res)
              {
                  Console.WriteLine(num);
              }
              else
              {
                  Console.WriteLine("Not Valid");
              } */


            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            string str;
            Console.WriteLine("Enter String");
            str = Console.ReadLine();
            try{
                double no = Convert.ToDouble(str);
                Console.WriteLine("Parse successful. Converted decimal value: " + no);
            }
            catch (FormatException)
            {
                Console.WriteLine("Conversion failed. Invalid input format.");
            }
  
           
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            
            /*string decimalString = "34.34";
            try
            {
                decimal decimalValue = decimal.Parse(decimalString);
                Console.WriteLine("Parse successful. Converted decimal value: " + decimalValue);
            }
            catch (FormatException)
            {
                Console.WriteLine("Parse failed. Invalid input format.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Parse failed. Input value is too large or too small.");
            }
            */
            Console.ReadKey();
        }
    }
}

    ///////////////////////////////////////////////////////////////////////////////////////////////









   