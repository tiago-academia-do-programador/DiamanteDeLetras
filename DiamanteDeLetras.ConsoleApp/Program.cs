using System;

namespace DiamanteDeLetras.ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int letraA = 'A';

            int meioDoDiamante;

            while (true)
            {
                Console.Write("Digite a letra que estará no meio do diamante: ");
                meioDoDiamante = Console.Read();

                if (meioDoDiamante > 90 || meioDoDiamante < 65)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Por favor, digite um valor entre A e Z (maiúsculo)!");
                    Console.ReadLine();

                    Console.ResetColor();
                    continue;
                }
                else
                    break;
            }

            int tamanhoInicialEspacosExterior = (meioDoDiamante - 1) / 2;
            int tamanhoInicialEspacosInterior = -1;
            
            Console.WriteLine();

            for (int i = letraA; i < meioDoDiamante; i++)
            {
                for (int j = 0; j < tamanhoInicialEspacosExterior; j++)
                    Console.Write(" ");

                char letraAtual = Convert.ToChar(i);

                Console.Write(letraAtual);

                for (int k = 0; k < tamanhoInicialEspacosInterior; k++)
                    Console.Write(" ");

                if (i != letraA)
                    Console.Write(letraAtual);

                Console.WriteLine();

                tamanhoInicialEspacosExterior--;
                tamanhoInicialEspacosInterior += 2;
            }

            for (int i = meioDoDiamante; i >= letraA; i--)
            {
                for (int j = 0; j < tamanhoInicialEspacosExterior; j++)
                    Console.Write(" ");

                char letraAtual = Convert.ToChar(i);

                Console.Write(letraAtual);

                for (int k = 0; k < tamanhoInicialEspacosInterior; k++)
                    Console.Write(" ");

                if (i != letraA)
                    Console.Write(letraAtual);

                Console.WriteLine();

                tamanhoInicialEspacosExterior++;
                tamanhoInicialEspacosInterior -= 2;
            }

            Console.ReadLine();
        }
    }
}
