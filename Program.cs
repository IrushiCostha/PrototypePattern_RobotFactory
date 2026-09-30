using System;

namespace PrototypePattern_RobotFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- ROBOT FACTORY: PROTOTYPE PATTERN --- \n");

            // Base Prototypes
            ServiceRobot baseServiceRobot = new ServiceRobot("MedBot-3000", 12, "v1.0", "Hospital Patient Care");
            IndustrialRobot baseIndustrialRobot = new IndustrialRobot("WeldMaster-X", 24, "v2.1", "Automotive Welding");
            EntertainmentRobot baseEntertainmentRobot = new EntertainmentRobot("FunBot-V", 8, "v1.5", "Interactive Dancing");

            Console.WriteLine("=== Base Prototypes ===");
            baseServiceRobot.DisplayInfo();
            baseIndustrialRobot.DisplayInfo();
            baseEntertainmentRobot.DisplayInfo();
            Console.WriteLine();

            // Clone and Customize Service Robot
            ServiceRobot clonedServiceRobot = (ServiceRobot)baseServiceRobot.Clone();
            clonedServiceRobot.BatteryCapacity = 18;
            clonedServiceRobot.SoftwareVersion = "v1.1";

            // Clone and Customize Industrial Robot
            IndustrialRobot clonedIndustrialRobot = (IndustrialRobot)baseIndustrialRobot.Clone();
            clonedIndustrialRobot.Task = "Heavy Assembly";

            Console.WriteLine("=== Customized Cloned Robots ===");
            clonedServiceRobot.DisplayInfo();
            clonedIndustrialRobot.DisplayInfo();

            Console.ReadLine();
        }
    }
}