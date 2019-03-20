using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchWizardException
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizard w = new Wizard();
            string response = null;

            do
            {
                try
                {
                    w.DoMagic();

                    Console.Write("[enter for more magic]");
                }
                catch (OutOfMannaException oom)
                {
                    Console.Write("Out of manna: " + oom.Message);
                }
                catch (Exception x)
                {
                    Console.Write("Error: " + x.Message);
                }

                response = Console.ReadLine().Trim().ToLower();
            } while (response != "finite");
        }
    }
}
