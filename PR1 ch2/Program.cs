using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR1_ch2
{
    class Program
    {
        static void Main(string[] args)
        {


            int[,] matr = new int[10, 10];
            Fill(matr);
            Show(matr);
            int[] a = TestMatrix(matr);
            if(a.Length!=0)Show(a,"столбцы содержащие только положительные элементы находытся под этими номерами\n (начало отсчета с 0):");
            else 
            Console.WriteLine("таких столбцов нет");
            
            
            
            int[,] matr1 = new int[10, 10];
            Fill(matr1);
            Show(matr1);
            int[] b = TestMatrix(matr1);
            if(b.Length!=0)Show(b,"столбцы содержащие только положительные элементы находытся под этими номерами\n (начало отсчета с 0):");
            else 
            Console.WriteLine("таких столбцов нет");


            Console.WriteLine("\n Для выхода нажмите любую клавишу");
            Console.ReadKey();
        }

        static void Fill(int[,] matr)
        {
            Random rndx = new Random();
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    matr[i, j] = rndx.Next(-1, 9);
                }
            }
        }
        static void Show(int[,] matr, string text = "Исходная матрица: ")
        {
            Console.WriteLine(text);
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    Console.Write("{0,3}", matr[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void Show(int[] arrey, string text = "циферки: ")
        {
            Console.WriteLine(text);
            for (int i = 0; i < arrey.GetLength(0); i++)
            {
                Console.Write("{0,3}", arrey[i]);
            }
            Console.WriteLine();
        }
        static int[] GiveColum(int[,] matr, int number)
        {
            int[] arrey = new int[matr.GetLength(0)];
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                arrey[i] = matr[i,number ];
            }
            return arrey;
        }
        static bool TestColum(int[] Colum)
        {
            return (Colum.Min() > 0);
        }

        static int[] TestMatrix(int[,] matr)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < matr.GetLength(1); i++)
            {
                if (TestColum(GiveColum(matr, i))) list.Add(i);
            }
            return list.ToArray();
        }
    }
}
