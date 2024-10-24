using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yıldızlarla dik üçgen şekil
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


            Console.WriteLine();

            #endregion

            #region Yıldızlarla ters dik üçgen şekil

            for (int i = 5; i >= 1; i--)
            {
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            #endregion

            #region Yıldızlarla üçgen şekil

            int n = 5;
            for (int i = 1; i <= n; i++)
            {
                for (int j = n - i; j > 0; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


            #endregion

            #region Yıldızlarla ters üçgen şekil

            int m = 5;
            for (int i = m; i >= 1; i--)
            {
                for (int j = m - i; j > 0; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            #endregion

            #region Yıldızlarla baklava şekil

            int n = 5;
            for (int i = 1; i <= n; i++)
            {
                for (int j = n - i; j > 0; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            int m = 5;
            for (int i = m; i >= 1; i--)
            {
                for (int j = m - i; j > 0; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            #endregion
            Console.Read();
        }
    }
}
