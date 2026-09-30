namespace PrototypePattern_RobotFactory
{
    public class ServiceRobot : RobotPrototype
    {
        public ServiceRobot(string modelName, int batteryCapacity, string softwareVersion, string serviceTask)
            : base(modelName, batteryCapacity, softwareVersion, serviceTask)
        {
        }

        public override RobotPrototype Clone()
        {
            return (RobotPrototype)this.MemberwiseClone();
        }
    }
}