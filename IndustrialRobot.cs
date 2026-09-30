namespace PrototypePattern_RobotFactory
{
    public class IndustrialRobot : RobotPrototype
    {
        public IndustrialRobot(string modelName, int batteryCapacity, string softwareVersion, string industrialTask)
            : base(modelName, batteryCapacity, softwareVersion, industrialTask)
        {
        }

        public override RobotPrototype Clone()
        {
            return (RobotPrototype)this.MemberwiseClone();
        }
    }
}