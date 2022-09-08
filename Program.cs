using System;

namespace Seminar4HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишите цикл , который принимает на вход 2 числа (А и В) и возводит число А в натуральную степень В

            // int Num (int A, int B){
            //     int res = 1;
            //     for(int count = 0; count < B; count++){
            //         res*= A;
            //     }
            // return res;
            // }

            // Console.WriteLine ("Enter the number A: ");
            // int num1 = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine ("Enter number B: ");
            // int num2 = Convert.ToInt32(Console.ReadLine());

            // int result = Num (num1, num2);
            // Console.WriteLine("Number is - " + result);
                         

            //Напишите программу, которая принимает на вход число и выдает сумму цифр в числе
            // что-то с формулой не так
            int Sum (int num){
                int result=0;
                    for (int curr = num; curr>0; curr /=10){
                        result += curr%10;
                    }
                return result;                
            }

            Console.WriteLine("Enter the number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            
            //int number =  ();
            Console.WriteLine($"Result is - {Sum (num)}");
            

            //Напишите программу, которая задает массив из произвольного элемента и выводит их на экран

            
            // int [] CreateArray (int size, int min, int max){
            //     int [] array = new int [size];
            //         for (int i=0; i<size; i++){
            //             array [i] = new Random().Next(min, max);
            //         }
            //     return array;
            // }

            // Console.WriteLine ("Введите минимальное и максимальное значение: ");
            // int min = Convert.ToInt32(Console.ReadLine());
            // int max = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine ($"{min} {max}");
            // Console.WriteLine ("Введите количество элементов: ");
            // int size = Convert.ToInt32(Console.ReadLine());
            
            // int [] array = CreateArray(size,min,max);
            // for (int i=0; i<array.Length; i++){
            //     Console.Write (array [i] + " ");
            // }
        

        }
    }
}

