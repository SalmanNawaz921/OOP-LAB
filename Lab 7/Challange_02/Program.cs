using System;

namespace Challange_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write code here
            while (true)
            {
                int opt = Menu();
                if (opt == 1)
                {
                    FireFighter fighter = newFighter();
                    FireFighter.addFighter(fighter);
                }
                else if (opt == 2)
                {
                    FireTruck truck = newTruck();
                    if (truck != null)
                    {
                        FireTruck.addTruck(truck);
                        Console.WriteLine("Truck Added");
                    }
                    else
                    {
                        Console.WriteLine("Truck Not Added");
                    }
                }
                else if (opt == 3)
                {
                    FireFighter.viewAllFighters();
                }
            }
        }

        public static FireFighter newFighter()
        {
            Console.WriteLine("Enter The Name of Fighter: ");
            string figterName = Console.ReadLine();
            FireFighter fighter = new FireFighter(figterName);
            return fighter;
        }
        public static FireTruck newTruck()
        {
            Console.WriteLine("Enter The Length of Ladder: ");
            int ladderLength = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Color of Ladder: ");
            string ladderColour = Console.ReadLine();
            Ladder ladder = new Ladder(ladderLength, ladderColour);
            Console.WriteLine("Enter The Material of HosePipe: ");
            string pipeMaterial = Console.ReadLine();
            Console.WriteLine("Enter The Shape of HosePipe: ");
            string pipeShape = Console.ReadLine();
            Console.WriteLine("Enter The Diameter of HosePipe: ");
            float pipeDiameter = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter The FlowRate of HosePipe: ");
            float pipeFlowRate = float.Parse(Console.ReadLine());
            HosePipe pipe = new HosePipe(pipeMaterial, pipeShape, pipeDiameter, pipeFlowRate);
            Console.WriteLine("Enter The Name of FireFighter For This Truck: ");
            string fighterName = Console.ReadLine();
            bool Flag = false;
            FireFighter driver = new FireFighter(fighterName);
            foreach (FireFighter fighter in FireFighter.fighters)
            {
                if (fighterName == fighter.getName())
                {
                    Flag = true;
                    driver = fighter;
                    break;
                }
                else
                {
                    driver = null;
                }
            }
            if (driver != null)
            {
                FireTruck truck = new FireTruck(ladder, pipe, driver);
                return truck;
            }
            return null;
        }

        static int Menu()
        {
            int option = 0;
            Console.WriteLine("1. Add FireFighter");
            Console.WriteLine("2. Add FireTruck");
            Console.WriteLine("3. View All FireFighters");
            Console.Write("Your Option: ");
            option = int.Parse(Console.ReadLine());
            return option;
        }
    }
}
