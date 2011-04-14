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
            "Absolutely"
        };

        public string Shake(string question)
        {
            long tickCount = 0;
            QueryPerformanceCounter(out tickCount);
            string response = responses[new Random((int)tickCount).Next(responses.Length)];

            Console.WriteLine(string.Format("Magic8Ball answered '{0}' to '{1}'", response, question));

            return response;
        }
    }
}
