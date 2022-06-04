using System;
namespace NestedLoopLab
{
    class Program
    {
        static void Main()
        {
         int numberOfFloors = int.Parse(Console.ReadLine());
         int roomsPerFloor = int.Parse(Console.ReadLine());

            //редове = numberOfFloors
            for (int currFloor = numberOfFloors; currFloor >0; currFloor--)
            {
                //една колона стаи = roomsPerFloor
                for (int currRoom = 0; currRoom < roomsPerFloor; currRoom++)
                {
                    //ако етажа е последен
                    if (currFloor == numberOfFloors)
                    {
                        Console.Write($"L{currFloor}{currRoom} ");
                    }
                    //ако етажа е четен - офис
                    else if (currFloor % 2 == 0)
                    {
                        Console.Write($"O{currFloor}{currRoom} ");
                    }
                    //else - апартамент
                    else
                    {
                        Console.Write($"A{currFloor}{currRoom} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}