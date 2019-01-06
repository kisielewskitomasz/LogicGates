namespace LogicGates.Common
{
    /// <summary>
    /// Defines all constant values
    /// </summary>
    public class Defs
    {
        /// <summary>
        /// Defines types of Wire
        /// </summary>
        public enum Wire
        {
            /// <summary>Hotizontal Wire</summary>
            Horizontal = 0,
            /// <summary>Hertical Wire</summary>
            Vertical = 1
        }

        /// <summary>
        /// Defines states of Connection
        /// </summary>
        public enum Connection
        {
            /// <summary>High impedance state</summary>
            HighImpedance = -1,
            /// <summary>Low state</summary>
            Low = 0,
            /// <summary>High state</summary>
            High = 1
        }

        /// <summary>
        /// Defines states of Element
        /// </summary>
        public enum Element
        {
            /// <summary>Low state</summary>
            Low = Connection.Low,
            /// <summary>High state</summary>
            High = Connection.High
        }

        /// <summary>
        /// Defines types of Pin
        /// </summary>
        public enum Pin
        {
            /// <summary>Not existing type</summary>
            Null = -1,
            /// <summary>Input type</summary>
            In = 0,
            /// <summary>Out type</summary>
            Out = 1
        }

        /// <summary>
        /// Defines states of Mouse
        /// </summary>
        public enum Mouse
        {
            /// <summary>Not existing state</summary>
            Null = -1,
            /// <summary>Idle state</summary>
            Idle = 0,
            /// <summary>Selected Element state</summary>
            Select = 1,
            /// <summary>Selected one Pin of Element for new Connection state</summary>
            SelectPin = 2,
            /// <summary>Moving selected Element state</summary>
            Move = 3,
            /// <summary>Selected second Pin of Element for new Connection state</summary>
            Connect = 4
        }
    }
}