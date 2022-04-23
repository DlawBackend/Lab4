using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.Write("Enter firstNumber: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter secondNumber: ");
            int secondNumber = int.Parse(Console.ReadLine());

            int sum = firstNumber + secondNumber;
            if(sum < 100) {
                Console.WriteLine("true");
            } else {
                Console.WriteLine("false");
            }


            Console.ReadLine();
