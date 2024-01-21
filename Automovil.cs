using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_Carro
{
    internal class Automovil
    {
        private int puertas;

        public int Puertas
        {
            get { return puertas; }
            set
            {
                if (value > 0)
                    puertas = value;
                else
                    Console.WriteLine("Número de puertas no válido");
            }
        }

        public string Marca { get; internal set; }
        public string Modelo { get; internal set; }
        public int Anno { get; internal set; }

        public void GetInformation()
        {
            //base.GetInformation();
            Console.WriteLine($"Puertas: {Puertas}");
        }

        internal void RunAction()
        {
            throw new NotImplementedException();
        }
    }
}

