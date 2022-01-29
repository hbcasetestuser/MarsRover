namespace MarsRover
{
    public class Rover
    {
        public Rover(int x, int y, char d)
        {
            X = x;
            Y = y;
            Direction = d;
            DirectionArray = new char[] { Directions.North, Directions.East, Directions.South, Directions.West };
        }
        public int X { get; private set; }
        public int Y { get; private set; }
        public char Direction { get; set; }
        private char[] DirectionArray { get; set; }

        public void Move(int xLine, int yLine)
        {
            if (Direction == Directions.North && Y != yLine)
                Y++;
            else if (Direction == Directions.East && X != xLine)
                X++;
            else if (Direction == Directions.South && Y != 0)
                Y--;
            else if (Direction == Directions.West && X != 0)
                X--;
            else
                throw new ArgumentOutOfRangeException("Out of plateau!");
        }

        public void Left()
        {
            var index = Array.IndexOf(DirectionArray, Direction);
            if (index == 0)
                Direction = Directions.West;
            else
                Direction = DirectionArray[index - 1];
        }

        public void Right()
        {
            var index = Array.IndexOf(DirectionArray, Direction);
            if (index == 3)
                Direction = Directions.North;
            else
                Direction = DirectionArray[index + 1];
        }
    }
}