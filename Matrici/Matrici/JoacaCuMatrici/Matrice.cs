using System;
using System.Collections.Generic;
using System.Text;

namespace Matrici.JoacaCuMatrici
{
    class Matrice
    {
        int n, m;
        int[,] matrix;

        public void initializeMatrix()
        {
            Console.WriteLine("Matricea: ");

            Console.Write("Numarul de randuri: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Numarul de coloane ");
            m = Convert.ToInt32(Console.ReadLine());
            matrix = new int[n, m];
            Console.WriteLine("");

            Console.WriteLine("Introdu elementele in matrice ");
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    Console.Write("matricea[" + (i + 1) + "][" + (j + 1) + "] = ");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            Console.WriteLine("");

            Console.WriteLine("Matricea este ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("");
        }

        public int getRows()
        {
            return n;
        }

        public int getColumns()
        {
            return m;
        }

        public int[,] getMatrix()
        {
            return matrix;
        }
    }
}
