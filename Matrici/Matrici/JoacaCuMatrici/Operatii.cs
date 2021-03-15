using System;
using System.Collections.Generic;
using System.Text;

namespace Matrici.JoacaCuMatrici
{
    class Operatii
    {
        Matrice matrix = new Matrice();
        int n, m;
        int[,] mat;
        public void startMessage()
        {
            initMatrix();
            getMatrix();

            openMessage();

            int option = Convert.ToInt32(Console.ReadLine());

            while (true)
            {
                if (option == 1)
                {
                    adunare();
                }
                else
                {
                    if (option == 2)
                    {
                        inmultireScalar();

                    }
                    else
                    {
                        if (option == 3)
                        {
                            inmultireMatrice();
                        }
                        else
                        {
                            if (option == 4)
                            {
                                Console.WriteLine("");
                                System.Threading.Thread.Sleep(2000);
                                Environment.Exit(1);
                            }
                            else
                            {
                                Console.WriteLine("Alege ce operatie doresti sa faci\n");
                            }
                        }
                    }
                }

                openMessage();
                option = Convert.ToInt32(Console.ReadLine());
            }


        }

        public void initMatrix()
        {
            matrix.initializeMatrix();
        }
        public void getMatrix()
        {
            n = matrix.getRows();
            m = matrix.getColumns();
            mat = matrix.getMatrix();

        }

        public void openMessage()
        {

            Console.WriteLine("Alege o optiune");
            Console.WriteLine("1 - Adunare a doua matrici ");
            Console.WriteLine("2 - Inmultirea matricei cu un scalar");
            Console.WriteLine("3 - Inmultirea a doua matrici");
            Console.WriteLine("4 - Iesire");
            Console.WriteLine("");
        }

        public void adunare()
        {
            Matrice matrix2 = new Matrice();
            matrix2.initializeMatrix();
            int[,] mat2;
            mat2 = matrix2.getMatrix();
            Console.WriteLine("Rezultatul adunarii a doua matrici este ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write((mat2[i, j] + mat[i, j]) + " ");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("");
        }

        public void inmultireScalar()
        {
            Console.WriteLine("inmultire cu un scalar");
            Console.Write("Scrie scalarul ");
            int numberMultiply = Convert.ToInt32(Console.ReadLine());



            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write((mat[i, j] * numberMultiply));
                    Console.Write(" ");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("");
        }

        public void inmultireMatrice()
        {
            Matrice matrix2 = new Matrice();
            matrix2.initializeMatrix();
            int rows = matrix.getRows();
            int columns = matrix2.getColumns();

            int[,] mat2;
            mat2 = matrix2.getMatrix();
            if (rows == columns)
            {
                Console.WriteLine("Rezultatul inmultirii a doua matrici este: ");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        Console.Write("Matricea 2 este: " + (mat2[i, j] * mat[i, j]) + " ");
                    }
                    Console.WriteLine("");
                }

            }
            else
            {
                Console.WriteLine("Numarul de linii din matricea 1 este inegal cu cel al coloanelor din matricea 2 \n");

            }

        }
    }
}

