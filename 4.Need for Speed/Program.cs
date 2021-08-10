using System;
using System.Runtime.Serialization;

namespace _4.Need_for_Speed
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type: FamilyCar, SportCar, CrossMotorcycle or RaceMotorcycle");
            Console.WriteLine("Type Beast! for ending.");
            Console.WriteLine("After choosing between the choices you should insert on one line- Horse power and fuel");
            string info;
            while ((info = Console.ReadLine()) != "Beast!")
            {

                try
                {
                    var type = Console.ReadLine().Split(' '); 
                    switch (info)
                    {
                        case "FamilyCar":
                            var cfamily = new FamilyCar(int.Parse(type[0]), double.Parse(type[1]));
                            Console.WriteLine(cfamily);
                            break;
                        case "SportCar":
                            var scar = new SportCar(int.Parse(type[0]), double.Parse(type[1]));
                            Console.WriteLine(scar);
                            break;
                        case "CrossMotorcycle":
                            var cmotor = new CrossMotorcycle(int.Parse(type[0]), double.Parse(type[1]));
                            Console.WriteLine(cmotor);
                            break;
                        case "RaceMotorcycle":
                            var rmotor = new RaceMotorcycle(int.Parse(type[0]), double.Parse(type[1]));
                            Console.WriteLine(rmotor);
                            break;
                        
                        default:
                            throw new InvalidProgramException();
                    }
                }
                catch (InvalidProgramException iie)
                {
                    Console.WriteLine(iie.Message);
                }
            }
        }

    }
}