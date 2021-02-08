using System;

namespace zad_5_3
{
    class Matrix
    {
        private byte _i = 0;
        private byte _j = 0;
        private double _sum = 0;

        public void enterData(int size, double[,] array)
        {
            Random rnd = new Random();
            for (_i = 0; _i < size; _i++)
            {
                for (_j = 0; _j < size; _j++)
                {
                    array[_i, _j] = (_i == _j) ? Math.Round(9 * rnd.NextDouble()) : 0;
                }
            }
        }
        public void processData(int size, double[,] array)
        {
            for (_i = 0; _i < size; _i++)
            {
                for (_j = 0; _j < size; _j++)
                {
                    if(_i == _j)
                    {
                        _sum = _sum + array[_i, _j];
                    }
                }
            }
        }
        public void writeData(int size, double[,] array)
        {
            for (_i = 0; _i < size; _i++)
            {
                Console.Write("|");
                for (_j = 0; _j < size; _j++)
                {
                    Console.Write(array[_i, _j] + ",\t");
                }
                Console.Write("|");
                Console.WriteLine();
            }
            Console.WriteLine($"Sum = {_sum}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int array_size=10;
            double[,] array = new double[array_size,array_size];

            Matrix matrix_1 = new Matrix();
            matrix_1.enterData(array_size, array);
            matrix_1.processData(array_size, array);
            matrix_1.writeData(array_size, array);
            
        }
    }
}
