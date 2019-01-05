namespace LogicGates.Common
{
    public class Dimensions
    {
        /// <summary>
        /// Struct used to define Canvas size
        /// </summary>
        public struct Canvas
        {
            public const int Width = 72 * 16;
            public const int Height = 72 * 9;
        }

        public struct Banner
        {
            public const int Width = 384;
            public const int Height = 384;

            public struct Space
            {
                public const int Width = 32;
                public const int Height = 32;
            }

            public struct Button
            {
                public const int Width = Banner.Width - (2 * Banner.Space.Width);
                public const int Height = 64;
            }
        }

        public struct Tray
        {
            public const int Width = Canvas.Width;
            public const int Height = 72;
        }

        public struct Element
        {
            public const int Width = 72;
            public const int Height = 72;

            public struct Pin
            {
                public const int Width = 6;
                public const int Height = 6;

                public struct Position
                {
                    public struct In
                    {
                        public struct Single
                        {

                            public const int Width = 0;
                            public const int Height = 33;
                        }

                        public struct Double
                        {
                            public struct A
                            {
                                public const int Width = Single.Width;
                                public const int Height = 20;
                            }
                            public struct B
                            {
                                public const int Width = Single.Width;
                                public const int Height = 46;
                            }
                        }
                    }

                    public struct Out
                    {
                        public const int Width = 66;
                        public const int Height = In.Single.Height;
                    }
                }
            }
        }



        public struct Space
        {
            public const int Width = 8;
        }

        public struct Wire
        {
            public const int Thickness = 6;
        }
    }
}