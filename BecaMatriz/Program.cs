using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BecaMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cada Becario deverá criar um metódo para calcular a soma da diagonal principal de uma matriz quadrada 3 x 3 
            // O método deverá ter o nome do participante
            // exemplo: CalculaSomaDiagonalPrincipal_Ricardo();


            int[,] matriz = CriaMatrizQuadrada();
            CalculaSomaDiagonalPrincipal_Pedro(matriz);
            
        }

        public static int[,] CriaMatrizQuadrada()
        {
            Console.WriteLine("Quantas linhas terá sua matriz quadrada? ");
            int linhas = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantas colunas terá sua matriz quadrada? ");
            int colunas = int.Parse(Console.ReadLine());

            
            int[,] matriz = new int[linhas, colunas];
            for(int i = 0; i < matriz.GetLength(0); i ++)
            {
                for(int j = 0; j < matriz.GetLength(1); j ++) 
                {
                    Console.WriteLine("Digite o número que vai na posição [" + (i+1) + "][" + (j+1) + "]");
                    matriz[i,j] = int.Parse(Console.ReadLine());
                }
            }
            return matriz;
           

        }

        public static void CalculaSomaDiagonalPrincipal_Pedro(int[,] matriz)
        {
            int soma = 0;
            for(int i = 0; i < matriz.GetLength(0); i ++)
            {
                for(int j = 0; j < matriz.GetLength(1); j ++) 
                {
                    if(i == j) 
                        {
                            soma += matriz[i, j];
                        }
                }
            }

            Console.WriteLine(soma);
            Console.ReadLine();
        }   
    }
}
