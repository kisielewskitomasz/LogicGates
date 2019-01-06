namespace LogicGates.Common
{
    /// <summary>
    /// Defines all dimensions of objects in pixels
    /// </summary>
    public class Dimensions
    {
        /// <summary>
        /// Defines Canvas size
        /// </summary>
        public struct Canvas
        {
            public const int Width = 72 * 16;
            public const int Height = 72 * 9;
        }

        /// <summary>
        /// Defines Banner size
        /// </summary>
        public struct Banner
        {
            public const int Width = 384;
            public const int Height = 384;

            /// <summary>
            /// Defines Space size between buttons
            /// </summary>
            public struct Space
            {
                public const int Width = 32;
                public const int Height = 32;
            }

            /// <summary>
            /// Defines Button size
            /// </summary>
            public struct Button
            {
                public const int Width = Banner.Width - (2 * Banner.Space.Width);
                public const int Height = 64;
            }
        }

        /// <summary>
        /// Defines Tray size
        /// </summary>
        public struct Tray
        {
            public const int Width = Canvas.Width;
            public const int Height = 72;
        }

        /// <summary>
        /// Defines Element size
        /// </summary>
        public struct Element
        {
            public const int Width = 72;
            public const int Height = 72;


            /// <summary>
            /// Defines Pin size and relative position
            /// </summary>
            public struct Pin
            {
                public const int Width = 6;
                public const int Height = 6;

                /// <summary>
                /// Defines Pin relative position
                /// </summary>
                public struct Position
                {
                    /// <summary>
                    /// For In Pins
                    /// </summary>
                    public struct In
                    {
                        /// <summary>
                        /// For Signle input
                        /// </summary>
                        public struct Single
                        {

                            public const int Width = 0;
                            public const int Height = 33;
                        }

                        /// <summary>
                        /// For Double input
                        /// </summary>
                        public struct Double
                        {
                            /// <summary>
                            /// For First pin
                            /// </summary>
                            public struct A
                            {
                                public const int Width = Single.Width;
                                public const int Height = 20;
                            }

                            /// <summary>
                            /// For Second pin
                            /// </summary>
                            public struct B
                            {
                                public const int Width = Single.Width;
                                public const int Height = 46;
                            }
                        }
                    }

                    /// <summary>
                    /// For Out Pins
                    /// </summary>
                    public struct Out
                    {
                        public const int Width = 66;
                        public const int Height = In.Single.Height;
                    }
                }
            }
        }

        /// <summary>
        /// Defines space between Gates in tray
        /// </summary>
        public struct Space
        {
            public const int Width = 8;
        }

        /// <summary>
        /// Defines Wire thickness
        /// </summary>
        public struct Wire
        {
            public const int Thickness = 6;
        }
    }
}