using System;
using System.ServiceModel;

namespace Magic8BallServiceHost
{
    class ServiceHostApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Magic8Ball Service Host");
            Console.WriteLine("-----------------------");

            // NB: Never wrap your ServiceHost in a using(...) {...} statement as exceptions will be masked!
            // Use a try ... finally instead.
            ServiceHost host = new ServiceHost(typeof(Magic8Ball));
            try
            {
                host.Open();

                Console.WriteLine("The Magic8Ball service awaits your questions and is listening on the following endpoints:");

                // Display endpoints the service is currently listening on:
                foreach (var e in host.Description.Endpoints)
                {
                    Console.WriteLine("  " + e.Name + " @ " + e.Address);
                }

                // Tell the user how to quit and wait until they do!
                do { Console.WriteLine("\r\nPress [Esc] to quit ...\r\n"); }
                while (Console.ReadKey(true).Key != ConsoleKey.Escape);

                host.Close();
            }
            catch (AddressAccessDeniedException ex)
            {
                ConsoleColor old = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(@"The Magic8BallServiceHost must be run with elevated permissions. If you're running this under Visual Studio, please restart Visual Studio elevated.");
                Console.ForegroundColor = old;

                    throw ex;
            }
            finally
            {
                if (host != null)
                {
                    host.Close();
                }
            }

        }
    }
}
