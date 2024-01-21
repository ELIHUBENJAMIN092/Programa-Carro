using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_Carro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Automovil miAutomovil = new Automovil();
            miAutomovil.Marca = "Toyota";
            miAutomovil.Modelo = "Corolla";
            miAutomovil.Anno = 2022;
            miAutomovil.Puertas = 4;

            Camioneta miCamioneta = new Camioneta();
            miCamioneta.Marca = "Ford";
            miCamioneta.Modelo = "F-150";
            miCamioneta.Anno = 2023;
            miCamioneta.CapacidadCarga = 2.5;

            Console.WriteLine("Información del Automóvil:");
            miAutomovil.GetInformation();
            Console.WriteLine("\nInformación de la Camioneta:");
            miCamioneta.GetInformation();

            Console.WriteLine("\nAcciones:");
            miAutomovil.RunAction();  // Acción genérica del automóvil
            miCamioneta.RunAction();  // Acción genérica de la camioneta
        }
    }
}
