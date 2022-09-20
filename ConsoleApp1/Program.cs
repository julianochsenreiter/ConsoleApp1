using ServiceLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(MonopolyService))
            {
                host.Open();
                Console.WriteLine("Service is running");
                Console.ReadLine();
            }
        }
    }
}
