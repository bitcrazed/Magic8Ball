using System;

namespace Magic8BallServiceHost
{
    public sealed class Magic8Ball : IMagic8Ball
    {
        [System.Runtime.InteropServices.DllImport("Kernel32.dll")]
        public static extern bool QueryPerformanceCounter(out long perfcount);

        private string[] responses = 
        { 
            "Not a chance!",
            "Very Unlikely",
            "Be careful what you wish for!",
            "Perhaps",
            "Possibly",
            "Likely",
            "Very Likely",
            "Absolutely!"
        };

        public string Shake(string question)
        {
            // Choose a random answer from the list:
            long tickCount = 0;
            QueryPerformanceCounter(out tickCount);
            string response = responses[new Random((int)tickCount).Next(responses.Length)];

            // Output info to the server console:
            Console.WriteLine(string.Format("{0}: Question: '{1}' Answer: '{2}'", DateTime.Now, question, response));

            return response;
        }
    }
}
