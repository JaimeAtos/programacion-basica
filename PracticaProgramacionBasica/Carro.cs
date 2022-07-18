using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaProgramacionBasica
{
    /*Clase hija con herencia: listo*/
    sealed internal class Carro : Vehiculo
    {
        private string _Modelo { get; set; }
        private int _Puertas { get; set; }

        public Carro(string modelo, int puertas)
        {
            _Modelo = modelo;
            _Puertas = puertas;
        }

        public void GetModelo()
        {
            Console.WriteLine($"Su vehiculo {Marca} es de modelo {_Modelo}");
        }
        public void GetPuertas()
        {
            Console.WriteLine($"Su vehiculo tiene {_Puertas} puertas");
        }

    }
}
