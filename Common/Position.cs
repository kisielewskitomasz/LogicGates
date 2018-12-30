namespace LogicGates.Common
{
    public struct Position {
        public int Width;
        public int Height;

        public static Position operator+ (Position a, Position b) {
            Position position = new Position();
            position.Width = a.Width + b.Width;
            position.Height = a.Height + b.Height;
            return position;
        }

        public static Position operator- (Position a, Position b) {
            Position position = new Position();
            position.Width = a.Width - b.Width;
            position.Height = a.Height - b.Height;
            return position;
        }
    }
}