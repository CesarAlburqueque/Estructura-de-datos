using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_Prim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Grafo grafo = new Grafo(5);

            grafo.AgregarVertice("A");
            grafo.AgregarVertice("B");
            grafo.AgregarVertice("C");
            grafo.AgregarVertice("D");
            grafo.AgregarVertice("E");


            grafo.AgregarArista(0, 1, 2);
            grafo.AgregarArista(0, 2, 3);
            grafo.AgregarArista(0, 3, 6);
            grafo.AgregarArista(1, 4, 4);
            grafo.AgregarArista(2, 3, 5);
            grafo.AgregarArista(3, 4, 1);


            grafo.MostrarMatriz();

            AlgoritmoPrim prim = new AlgoritmoPrim(grafo);
            prim.Ejecutar();

            Console.ReadKey();

        }
    }
}
