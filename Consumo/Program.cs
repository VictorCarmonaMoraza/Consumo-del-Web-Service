using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consumo
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.ServiciosSoapClient client = new ServiceReference1.ServiciosSoapClient();

            string result = client.HelloWorld();

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
