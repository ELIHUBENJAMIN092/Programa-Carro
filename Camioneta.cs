using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_Carro
{
    internal class Camioneta
    {
        private double capacidadCarga;

        public double CapacidadCarga
        {
            get { return capacidadCarga; }
            set
            {
                if (value > 0)
                    capacidadCarga = value;
                else
                    Console.WriteLine("Capacidad de carga no válida");
            }
        }

        public string Marca { get; internal set; }
        public string Modelo { get; internal set; }
        public int Anno { get; internal set; }

        public void GetInformation()
        {
           //base.GetInformation();
            Console.WriteLine($"Capacidad de carga: {CapacidadCarga} toneladas");
        }

        internal void RunAction()
        {
            throw new NotImplementedException();
        }
    }
}

