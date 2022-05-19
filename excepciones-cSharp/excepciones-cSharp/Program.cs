using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excepciones_cSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Introduce un número: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Introduce otro número: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);
                Console.ReadLine();
            }
            catch(DivideByZeroException e)
            {
                Console.Write(e.Message);
                Console.ReadLine();
            }
            catch (FormatException e)
            {
                Console.Write(e.Message);
                Console.ReadLine();
            }
            catch(OverflowException e)
            {
                Console.Write(e.Message);
                Console.ReadLine();
            }
            finally
            {

            }
        }
    }
}
