using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {

        public static int[,] Move(int[,] ot)
        {
            Console.WriteLine("Enter how much to move x");
            int dx = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter how much to move y");
            int dy = int.Parse(Console.ReadLine());
            for (int i = 0; i < ot.Length / 2; i++)
            {
                ot[0, i] = ot[0, i] + dx;
                ot[1, i] = ot[1, i] + dy;
            }

            return ot;
        }
        public static int[,] Resize(int[,] ot)
        {
            int tzirx = Math.Abs(0 - ot[0, 0]);
            int tziry = Math.Abs(0 - ot[1, 0]);
            Console.WriteLine("Enter how much to resize x");
            int mx = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter how much to resize y");
            int my = int.Parse(Console.ReadLine());
            for (int i = 0; i < ot.Length / 2; i++)
            {
                ot[0, i] = ot[0, i] - tzirx;
                ot[1, i] = ot[1, i] - tziry;
                ot[0, i] = ot[0, i] * mx;
                ot[1, i] = ot[1, i] * my;
                ot[0, i] = ot[0, i] + tzirx;
                ot[1, i] = ot[1, i] + tziry;
            }

            return ot;
        }
        public static int[,] Rotate(int[,] ot)
        {
            double xtag, ytag;
            int tzirx = Math.Abs(0 - ot[0, 0]);
            int tziry = Math.Abs(0 - ot[1, 0]);
            Console.WriteLine("How much to rotate?");
            double rot = double.Parse(Console.ReadLine());
            rot = ((rot / 180) * Math.PI);
            for (int i = 0; i < ot.Length / 2; i++)
            {
                ot[0, i] = ot[0, i] - tzirx;
                ot[1, i] = ot[1, i] - tziry;
                xtag = (ot[0, i] * Math.Cos(rot)) - (ot[1, i] * Math.Sin(rot));
                ytag = (ot[0, i] * Math.Sin(rot)) + (ot[1, i] * Math.Cos(rot));
                ot[0, i] = (int)(Math.Round(xtag));
                ot[1, i] = (int)(Math.Round(ytag));
                ot[0, i] = ot[0, i] + tzirx;
                ot[1, i] = ot[1, i] + tziry;
            }
            return ot;
        }
        static void Main(string[] args)
        {
            int[,] ot = { {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 0, 12 , 0, 12, 0, 12, 0, 12, 0, 12, 0, 12, 0, 12, 0, 12, 0, 12, 0 , 12, 0 , 12},
                          {0, 0, 0, 0, 0, 0, 0, 0, 0, 0,  0,  0,  0, 1,  1 , 2, 2 , 3, 3 , 4, 4 , 5, 5 , 6, 6 , 7, 7 , 8, 8 , 9, 9 , 10, 10, 11, 11}};

            for (int i = 0; i < ot.Length / 2; i++)
            {
                ot[0, i] = ot[0, i] + 30;
                ot[1, i] = ot[1, i] + 20;
                Console.SetCursorPosition(ot[0, i], ot[1, i]);
                Console.Write("*");
            }
            Console.SetCursorPosition(0, 0);
            ot = Move(ot);
            ot = Resize(ot);
            ot = Rotate(ot);
            Console.Clear();
            for (int i = 0; i < ot.Length / 2; i++)
            {
                ot[0, i] = ot[0, i] + 50;
                ot[1, i] = ot[1, i] + 50;
                Console.SetCursorPosition(ot[0, i], ot[1, i]);
                Console.Write("*");
            }

            Console.ReadLine();

        }
    }
}