namespace MarsRover
{
    public class Plateau
    {
        public Plateau(int xLine, int yLine)
        {
            XLine = xLine;
            YLine = yLine;
            RoverList = new List<Rover>();
        }
        private int XLine { get; set; }
        private int YLine { get; set; }
        public List<Rover> RoverList { get; set; }

        public void Command(string letters)
        {
            var rover = RoverList.Last();

            foreach (var letter in letters.ToList())
            {
                switch (letter)
                {
                    case CommandLetters.Move:
                        rover.Move(XLine, YLine);
                        break;
                    case CommandLetters.Left:
                        rover.Left();
                        break;
                    case CommandLetters.Right:
                        rover.Right();
                        break;
                    default:
                        throw new ArgumentException("Undefined letter to command!");
                }
            }
        }
    }
}