using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionExample
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Please type your year of birth");
            var year = Console.ReadLine();

            try
            {
                if (year?.Length != 4 )
                {
                    throw new InvalidYearException();
                }

                Console.WriteLine($"You was born in {year}");
            }
            catch (InvalidYearException ex)
            {
                throw ex;
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
