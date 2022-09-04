using System;

namespace Seminar4HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишите цикл , который принимает на вход 2 числа (А и В) и возводит число А в натуральную степень В

            void Pow (int A, int B){
                Console.WriteLine ($"Answer is {Math.Pow(A,B)}");
            }

            Console.WriteLine ("Enter number A: ");
            int numA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine ("Enter number B: ");
            int numB = Convert.ToInt32(Console.ReadLine());
            Pow(numA,numB);


            //Напишите программу, которая принимает на вход число и выдает сумму цифр в числе

            //Напишите программу, которая задает массив из произвольного элемента и выводит их на экран
        }
    }
}
