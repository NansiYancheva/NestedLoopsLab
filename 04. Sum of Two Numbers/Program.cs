using System;
namespace NestedLoopLab
{
    class Program
    {
        static void Main()
        {
            int beggining = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int combinations = 0;
            bool isEqual = false;
            int currFirstNumber = 0;
            int currSecondNumber = 0;

            for (currFirstNumber = beggining; currFirstNumber <= end; currFirstNumber++)
            {
                for (currSecondNumber = beggining; currSecondNumber <= end; currSecondNumber++)
                {
                    combinations++;
                    if (currFirstNumber + currSecondNumber == magicNumber)
                    {
                        isEqual = true;
                        break;
                    }

                }
                if (isEqual)
                    break;
            }
            if (isEqual)
            {
                Console.WriteLine($"Combination N:{combinations} ({currFirstNumber} + {currSecondNumber} = {magicNumber})");
            }
            else
            {
                Console.WriteLine($"{combinations} combinations - neither equals {magicNumber}");

            }
        }
    }
}

