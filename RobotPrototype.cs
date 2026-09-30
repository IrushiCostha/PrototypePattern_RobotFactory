using System;

namespace PrototypePattern_RobotFactory
{
    public abstract class RobotPrototype
    {
        public string ModelName { get; set; }
        public int BatteryCapacity { get; set; }
        public string SoftwareVersion { get; set; }
        public string Task { get; set; }

        public RobotPrototype(string modelName, int batteryCapacity, string softwareVersion, string task)
        {
            ModelName = modelName;
            BatteryCapacity = batteryCapacity;
            SoftwareVersion = softwareVersion;
            Task = task;
        }

        public abstract RobotPrototype Clone();

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"[Robot] Model: {ModelName} | Battery: {BatteryCapacity} hrs | Software: {SoftwareVersion} | Task: {Task}");
        }
    }
}