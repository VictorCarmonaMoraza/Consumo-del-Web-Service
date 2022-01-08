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

            //Llamada al metodo Saludar
            //string result = client.Saludar("Pepe");

            //Llamada al metodo de GuardarLog
            string result = client.GuardarLog("Mensaje de Consola");

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
