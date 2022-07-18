using System;
using System.Collections.Generic;
using System.IO;


namespace PracticaProgramacionBasica
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Fail fallo = new Fail();

            string EMessage = fallo.error();

            Console.WriteLine(EMessage);

            try
            {
                GreetCountries("countries.txt", "ArchivoSalida");
            }catch(FileNotFoundException)
            {
                Console.WriteLine("Error: no se ha encontrado el archivo");
            }catch(Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }

            Carro Audi = new Carro("R8", 4);

            Audi.GetModelo();
            Audi.GetPuertas();

        }

        static void GreetCountries(string inputFile, string outputFile)
        {
            outputFile = @$"{outputFile} {DateTime.Today.ToString("yyyy-MMMM-dd")}.txt";
            string leerTexto, textoActualizado = "";
            using(StreamReader sr = new StreamReader(@"..\..\..\"+inputFile))
            {
                while((leerTexto = sr.ReadLine()) != null)
                {
                    textoActualizado += $"Saludos desde {leerTexto}!\n";
                }
            }

            using(StreamWriter sw = new StreamWriter(outputFile))
            {
                sw.WriteLine(textoActualizado);
            }
        }
    }
}
