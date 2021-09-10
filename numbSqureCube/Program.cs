using System;

namespace numbSqureCube
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            multiples();
        }
        static void multiples()
        {
            int iterator = 0;
            Console.WriteLine("number   Square   cube");
            while (iterator <= 10)
            {
                Console.Write(iterator + "      ");
                Console.Write(iterator * iterator+ "       ");
                Console.WriteLine(iterator * iterator * iterator);
                iterator++;
            }
            /*for (int iterator = 10; iterator <= 0; iterator--)
            {
                Console.Write(iterator + "      ");
                Console.Write(iterator * iterator + "       ");
                Console.WriteLine(iterator * iterator * iterator);
            }*/
            Console.ReadLine();
        }
    }
}
