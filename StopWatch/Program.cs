using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) // this can execute forever
            {
                var calculator = new Calculator();

                Console.WriteLine("Type Start Command (Type: Start): ");
                var input = Console.ReadLine();
                if (!calculator.ValidateInput(input)) continue;
                
                calculator.SetStartEndDuration(DateTime.Now, input);

                while (!calculator.ValidateInput(input))
                {
                    Console.WriteLine("Type End Command (Type: Stop): ");
                    input = Console.ReadLine();
                }
                
                calculator.SetStartEndDuration(DateTime.Now, input);
                Console.WriteLine(calculator.GetDuration());
            }
        }
    }
}
