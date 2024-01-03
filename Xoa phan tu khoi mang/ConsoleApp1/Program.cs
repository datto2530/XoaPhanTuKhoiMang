using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine("nhap gia tri muon xoa");
            int n = int.Parse(Console.ReadLine());
            for (int i = n; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            Array.Resize(ref array, array.Length - 1);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                Console.Write(" ");
            }
        }
    }
}