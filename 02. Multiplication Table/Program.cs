using System;
namespace NestedLoopLab
{
    class Program
    {
        static void Main()
        {
            for (int firstNumber = 1; firstNumber <= 10; firstNumber++)
            {
                for (int secondNumber = 1; secondNumber <= 10; secondNumber++)
                {
                    Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
                }
            }

        }
    }
}
