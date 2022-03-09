using System;

namespace ArrayBiDim
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduza o número de linhas: ");
            string linhas = Console.ReadLine();
            Console.WriteLine("Introduza o número de colunas: ");
            string colunas = Console.ReadLine();

            int linhasN = int.Parse(linhas);
            int colunasN = int.Parse(colunas);

            float [,] matriz = new float [linhasN, colunasN];

            for ( int i = 0; i < matriz.GetLength(0); i++)
            {
                for ( int j = 0; j < matriz.GetLength(1); j++)
                {
                    string value = Console.ReadLine();
                    float valueN = float.Parse(value);
                }
            }


        }
    }
}
