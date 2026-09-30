namespace PrototypePattern_RobotFactory
{
    public class EntertainmentRobot : RobotPrototype
    {
        public EntertainmentRobot(string modelName, int batteryCapacity, string softwareVersion, string entertainmentFeature)
            : base(modelName, batteryCapacity, softwareVersion, entertainmentFeature)
        {
        }

        public override RobotPrototype Clone()
        {
            return (RobotPrototype)this.MemberwiseClone();
        }
    }
}