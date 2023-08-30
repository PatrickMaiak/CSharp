namespace BatalhaNavalaCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] grade = new string[11, 11];
            grade[0, 0] = "x";                
            preencher(grade);

            // vencedor();
            listarMatriz(grade);


            //jogar
            bool posicionador = false;
            string turno = "N";

            Console.WriteLine("    -------------BEM VINDO AO BATALHA NAVAL------------- \n\n       ESCOLHA A POSIÇÃO DE SEUS NAVIOS E AVIAO\n");
            Console.WriteLine($"                  INSTRUÇÃO DE JOGO\n\n    informe um N° para linha --->\n\n    informe um N° para coluna |\n                              V\n\n            0 1 2 3 4 5 6 7 8 9 10\n          0 - - - - - - - - - - -\n          1 - - - - - - - - - - -\n          2 - - - - - - - - - - -\n          3 - - - - - - - - - - -\n          4 - - - - - - - - - - -\n          5 - - - - - - - - - - -\n          6 - - - - - - - - - - -\n          7 - - - - - - - - - - -\n          8 - - - - - - - - - - -\n          9 - - - - - - - - - - -\n          10- - - - - - - - - - -\n");



            int index = 0;

            while (!posicionador)
            {
                if (index == 3)
                {
                    break;
                }
                index++;
                Console.WriteLine("posicione (NA LINHA) o 1° navio:");
                int linha = int.Parse(Console.ReadLine());

                Console.WriteLine("posicione (NA COLUNA) o 1° navio:");
                int coluna = int.Parse(Console.ReadLine());

                if (coluna > 10 || linha > 10)
                {
                    Console.WriteLine("posiçao invalida");
                    continue;
                }

                if (grade[linha, coluna] != "-")
                {
                    Console.WriteLine("posiçao ja ocupada por outra jogada");
                    continue;
                }

                if (index == 3)
                {
                    turno = "A";
                }
                grade[linha, coluna] = turno;
                Console.Clear();
                listarMatriz(grade);

                //operador ternario
                /*  if (!posicionador)
                  {
                      turno = turno == "X" ? "O" : "X";
                  }
                */


            }
            Console.WriteLine($"navios e aviao posicionados com sucesso");

            jogadaDaMaquina();

            Console.ReadKey();

        }
        static void jogadaDaMaquina()
        {


            string[,] gradeOculta = new string[10, 10];
            int indice = 0;



            while (indice < 3)
            {
                indice++;
                Random random = new Random();

                int y = random.Next(0, 10);


                int x = random.Next(0, 10);

                gradeOculta[x, y] = "X";

                Console.WriteLine($"{x}{y}");
            }

        }


        static bool verificarVencedor(string[,] matriz)
        {



            return false;
        }

        static void preencher(string[,] matrizz)
        {
            for (int linha = 0; linha < matrizz.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < matrizz.GetLength(1); coluna++)
                {
                    matrizz[linha, coluna] = "-";
                }

            }

        }
        static void listarMatriz(string[,] matriz)
        {
            for (int linha = 0; linha < matriz.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
                {
                    Console.Write(matriz[linha, coluna]);
                }
                Console.WriteLine();
            }

        }

    }
}