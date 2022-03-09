using System;

namespace PercorreString
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Escreva uma frase: ");
            string frase = Console.ReadLine();

            Console.WriteLine("Escolha uma letra que esteja na frase pelo menos: ");
            string letra = Console.ReadLine();

            int verify = Convert.ToInt32(letra[0]);

            for( int i = 0; i < frase.Length;i++ )
            {
                int letraFrase = Convert.ToInt32(frase[i]);
                if(verify != frase[i])
                {
                    Console.Write(frase[i]);
                }
            }

        }
    }
}
