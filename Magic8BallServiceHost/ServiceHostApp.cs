﻿using System;
using System.ServiceModel;

namespace Magic8BallServiceHost
{
    class ServiceHostApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Magic8Ball Service Host");
            Console.WriteLine("-----------------------");
            using (ServiceHost host = new ServiceHost(typeof(Magic8Ball)))
            {
                try
                {
                    host.Open();

                    Console.WriteLine("The Magic8Ball service awaits your questions:");
                    foreach (var e in host.Description.Endpoints)
                    {
                        Console.WriteLine("    " + e.Name + " @ " + e.Address);
                    }

                    do { Console.WriteLine("Press [Esc] to quit"); }
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
            }
        }
    }
}