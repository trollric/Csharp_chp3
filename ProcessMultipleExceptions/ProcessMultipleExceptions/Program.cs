using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessMultipleExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****** Handlong Multiple Exceptions ******\n");
            Car myCar = new Car("Rusty", 90);
            try
            {
                // Trip arg out of range exception.
                myCar.Accelerate(-10);
            }
            catch(CarIsDeadException e) when (e.ErrorTimeStamp.DayOfWeek != DayOfWeek.Friday)
            {
                // This line will only print if the "when" keyword evaluates true
                Console.WriteLine(e.Message);
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            // Safeguard catch
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            // This piece of code will always occur Exception or not
            finally
            {
                myCar.CrankTunes(false);
            }
            Console.ReadLine();
        }
    }
}
