using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_Prim
{
    internal class AlgoritmoPrim
    {
        private Grafo grafo;

        public AlgoritmoPrim (Grafo g)
        {
            grafo = g;  
        }

        private int VerticeMinimo(int[]Key, bool[] incluido)
        {
            int min = int.MaxValue, minIndex = -1;

            for (int v = 0; v < grafo.CantidadVertices; v++) 
            {
                if (!incluido[v] && Key[v] < min)
                {
                    min = Key[v];
                    minIndex = v;
                }
            }
            return minIndex;
        }
        public void Ejecutar()
        {
            int n = grafo.CantidadVertices;
            int[] parent = new int[n];
            int[] key = new int[n];
            bool[] incluido = new bool[n];

            for (int i = 0; i < n; i++)
            {
                key[i] = int.MaxValue;
                incluido[i] = false;
            }

            key[0] = 0;
            parent[0] = -1;

            for (int count = 0; count < n - 1; count++)
            {
                int u = VerticeMinimo(key, incluido);
                incluido[u] = true;

                for (int v = 0; v < n; v++)
                {
                    int peso = grafo.MatrizPesos[u, v];
                    if (peso != 0 && !incluido[v] && peso < key[v])
                    {
                        parent[v] = u;
                        key[v] = peso;
                    }
                }
            }

            MostrarResultado(parent);
        }

        private void MostrarResultado(int[] parent)
        {
            Console.WriteLine("\nAristas del Árbol de Expansión Mínima (Algoritmo Prim):");
            int total = 0;

            Console.WriteLine($"CantidadVertices: {grafo.CantidadVertices}");
            

            for (int i = 1; i < grafo.Vertices.Count; i++)
            {
               
                string origen = grafo.Vertices[parent[i]].Nombre;
                string destino = grafo.Vertices[i].Nombre;
                int peso = grafo.MatrizPesos[i, parent[i]];
                total += peso;

                Console.WriteLine($"{origen} - {destino} \tPeso: {peso}");
            }
        }
    }
}

