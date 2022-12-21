using System;

namespace JogoDaVelha
{
    class Program
    {       
        static void Main(string[] args)
        {
            string[,] matrix = new string[3, 3];

            string opcoes = "X";

            int indice = 1;

            int tentativas = 1;

            List<string> posiçãoNumeros = new List<string>();

            Console.WriteLine("---------------");
            Console.WriteLine(" JOGO DA VELHA ");
            Console.WriteLine("---------------");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = indice.ToString();
                    posiçãoNumeros.Add(indice.ToString());
                    indice++;
                }
            }
            
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($" [{matrix[i, j]}] ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.Write($"Escolher a opção [{opcoes}] e jogue no número disponivel: ");
            string jogada = Console.ReadLine();

            Console.Clear();

            
            while (tentativas < 9)
            {
                Console.WriteLine("---------------");
                Console.WriteLine(" JOGO DA VELHA ");
                Console.WriteLine("---------------");

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (jogada == matrix[i, j] && posiçãoNumeros.Contains(jogada))
                        {
                            matrix[i, j] = opcoes;
                            posiçãoNumeros.Remove(jogada);
                        }
                    }
                }
                
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write($" [{matrix[i, j]}] ");
                    }
                    Console.WriteLine();
                }
                if ((matrix[0, 0] == matrix[1, 1] && matrix[0, 0] == matrix[2, 2]) ||
                    (matrix[0, 2] == matrix[1, 1] && matrix[0, 2] == matrix[2, 0]))
                {
                    Console.WriteLine("---------------");
                    Console.WriteLine("  FIM DE JOGO  ");
                    Console.WriteLine("---------------");
                    Console.WriteLine($"Parabéns jogador [{opcoes}], VOCÊ GANHOU!!!");
                    break;
                }
                if ((matrix[0, 0] == matrix[0, 1] && matrix[0, 0] == matrix[0, 2]) ||
                    (matrix[1, 0] == matrix[1, 1] && matrix[1, 0] == matrix[1, 2]) ||
                    (matrix[2, 0] == matrix[2, 1] && matrix[2, 0] == matrix[2, 2]))
                {
                    Console.WriteLine("---------------");
                    Console.WriteLine("  FIM DE JOGO  ");
                    Console.WriteLine("---------------");
                    Console.WriteLine($"Parabéns jogador [{opcoes}], VOCÊ GANHOU!!!");
                    break;
                }
                if ((matrix[0, 0] == matrix[1, 0] && matrix[0, 0] == matrix[2, 0]) ||
                    (matrix[0, 1] == matrix[1, 1] && matrix[0, 1] == matrix[2, 1]) ||
                    (matrix[0, 2] == matrix[1, 2] && matrix[0, 2] == matrix[2, 2]))
                {
                    Console.WriteLine();
                    Console.WriteLine($"Parabéns jogador [{opcoes}], VOCÊ GANHOU!!!");
                    break;
                }

                if (opcoes == "X")
                {
                    opcoes = "O";
                }
                else
                {
                    opcoes = "X";
                }
                
                Console.WriteLine();
                Console.Write($"Escolher a opção [{opcoes}] e jogue no número disponivel: ");
                jogada = Console.ReadLine();
                
                while (!posiçãoNumeros.Contains(jogada))
                {
                    Console.WriteLine() ;
                    Console.Write("Jogada Inválida! Tente novamente: ");
                    jogada = Console.ReadLine();
                }
                tentativas++;

                Console.Clear();
            }
            if (tentativas == 9)
            {
                Console.WriteLine("---------------");
                Console.WriteLine(" JOGO DA VELHA ");
                Console.WriteLine("---------------");

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write($" [{matrix[i, j]}] ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("---------------");
                Console.WriteLine("  FIM DE JOGO  ");
                Console.WriteLine("---------------");
                Console.WriteLine($"EMPATOU!!! Jogar novamente.");
            }           
        }
    }
}
