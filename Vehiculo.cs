using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_Carro
{
    internal class Vehiculo
    {
        private string marca;
        private string modelo;
        private int anno;

        public string Marca
        {
            get { return marca; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    marca = value;
                else
                    Console.WriteLine("Marca no válida");
            }
        }

        public string Modelo
        {
            get { return modelo; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    modelo = value;
                else
                    Console.WriteLine("Modelo no válido");
            }
        }

        public int Anno
        {
            get { return anno; }
            set
            {
                if (value > 0)
                    anno = value;
                else
                    Console.WriteLine("Año no válido");
            }
        }

        public void GetInformation()
        {
            Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Año: {Anno}");
        }

        public virtual void RunAction()
        {
            Console.WriteLine("Realizando una acción genérica del vehículo");
        }
    }
}


