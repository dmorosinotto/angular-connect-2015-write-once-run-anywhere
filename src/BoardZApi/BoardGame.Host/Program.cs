using System;
using BoardGame.Api;
using Microsoft.Owin.Hosting;

namespace BoardGame.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (WebApp.Start<Startup>("http://+:9090"))
                {
                    Console.WriteLine("Server is up and running on http://+:9090");
                    PrintIP(" - configure Angular init.js with this apiBaseUrl: 'http://{0}:9090'");
                    Console.WriteLine(" - for API documentation go to http://localhost:9090/swagger");
                    Console.WriteLine("...");
                    Console.ReadLine();
                }
            }
            catch (Exception ex) {
                Console.Error.WriteLine(ex.ToString());
                Console.WriteLine("If starting the server leads into a TargetInvocationException, you'll need to add a url to your urlacl settings by executing the following command (on Windows :)) in an elevated command line: ");
                Console.WriteLine("> netsh http add urlacl url=http://+:9090/ user=your_user_name");
            }
            
        }

        static void PrintIP(string binding) {
            foreach (System.Net.IPAddress ip in System.Net.Dns.GetHostAddresses(Environment.MachineName))
            { Console.WriteLine(binding, ip.ToString());  }
        }
    }
}
