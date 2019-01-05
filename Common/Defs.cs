namespace LogicGates.Common
{
    public class Defs
    {
        public enum Wire
        {
            Horizontal = 0,
            Vertical = 1
        }

        public enum Connection
        {
            HighImpedance = -1,
            Low = 0,
            High = 1
        }

        public enum Element
        {
            Low = Connection.Low,
            High = Connection.High
        }

        public enum Pin
        {
            Null = -1,
            In = 0,
            Out = 1
        }

        public enum Mouse
        {
            Null = -1,
            Idle = 0,
            Select = 1,
            SelectPin = 2,
            Move = 3,
            Connect = 4

        }
    }
}