using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_Prim
{
    internal class Grafo
    {
        public int CantidadVertices { get; set; }
        public int[,] MatrizPesos { get; set; }
        public List<Vertice> Vertices { get; set; }

        public Grafo(int cantidad)
        {
            CantidadVertices = cantidad;
            MatrizPesos = new int[cantidad,cantidad];
            Vertices = new List<Vertice>();
        }
        public void AgregarVertice (string Nombre)
        {
            Vertices.Add(new Vertice(Nombre));
        }
        public void AgregarArista (int origen, int destino, int peso)
        {
            MatrizPesos[origen,destino] = peso;
            MatrizPesos[destino,origen] = peso;
        }
        public void MostrarMatriz()
        {
            Console.WriteLine("Matriz de Adyacencia");

            for (int i = 0; i < CantidadVertices; i++) 
            {
                for (int j = 0; j < CantidadVertices; j++)
                {
                    Console.Write($"{MatrizPesos[i, j], 3}");
                }
                Console.WriteLine();
            }
        }


       
    }
}
