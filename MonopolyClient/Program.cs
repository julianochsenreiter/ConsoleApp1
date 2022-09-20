using MonopolyClient.MonopolySvcRef;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var client = new MonopolyServiceClient("WSHttpBinding_IMonopolyService");
            client.GoToJail();
            Console.ReadLine();
            client.Close();
        }
    }
}
