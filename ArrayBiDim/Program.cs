using System;

namespace ArrayBiDim
{
    class Program
    {
        static void Main(string[] args)
        {

            float mediaTotal = 0.0f;

            Console.WriteLine("Introduza o número de linhas: ");
            string linhas = Console.ReadLine();
            Console.WriteLine("Introduza o número de colunas: ");
            string colunas = Console.ReadLine();

            int linhasN = int.Parse(linhas);
            int colunasN = int.Parse(colunas);

            float [,] matriz = new float [linhasN, colunasN];

            for ( int i = 0; i < matriz.GetLength(0); i++)
            {

                float mediaLinhas = 0.0f;

                for ( int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.WriteLine($"Qual o número para a posição [{i},{j}]");

                    

                    string value = Console.ReadLine();
                    float valueN = float.Parse(value);
                    matriz[i, j] = valueN;
                    mediaLinhas += matriz[i,j]/matriz.GetLength(1);

                }
                mediaTotal += mediaLinhas;
                Console.WriteLine($"A média da linha é: {mediaLinhas}");
            }

            Console.WriteLine($"A soma das médias é: {mediaTotal}");

        }
    }
}
