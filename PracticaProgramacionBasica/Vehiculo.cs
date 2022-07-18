using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*CHECAR LA PARTE DE POO*/
namespace PracticaProgramacionBasica
{
    /*Clase abs con 2 atributos y metodos : listo*/
    internal class Vehiculo
    {
        protected int Cilindros = 6;
        protected string Marca = "Audi";

        protected void encenderVehiculo(string marca)
        {
            Console.WriteLine($"Su vehiculo {marca} a sido encendio");
        }

        protected void apagarVehiculo(string marca)
        {
            Console.WriteLine($"Su vehiculo {marca} a sido apagado");
        }
    }
}
