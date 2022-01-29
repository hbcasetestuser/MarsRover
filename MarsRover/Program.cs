using MarsRover;

Console.WriteLine("Enter the upper-right coordinates of the plateau!");
var plateauInput = Console.ReadLine();
var plateauXY = plateauInput?.Split(" ");
if (plateauXY == null || plateauXY.Length != 2)
    throw new ArgumentException();

var plateau = new Plateau(Convert.ToInt32(plateauXY[0]), Convert.ToInt32(plateauXY[1]));

ConsoleKeyInfo cki;
do
{
    Console.WriteLine("Deploy the Rover!");
    var roverInput = Console.ReadLine();
    var roverXYD = roverInput?.Split(" ");
    if (roverXYD == null || roverXYD.Length != 3)
        throw new ArgumentException();
    var rover = new Rover(Convert.ToInt32(roverXYD[0]), Convert.ToInt32(roverXYD[1]), char.Parse(roverXYD[2]));
    plateau.RoverList.Add(rover);

    Console.WriteLine("Explore the plateau!");
    var commandLetters = Console.ReadLine();
    if (commandLetters == null)
        throw new ArgumentException();
    plateau.Command(commandLetters);

    Console.WriteLine(string.Join(" ", rover.X, rover.Y, rover.Direction));

    Console.WriteLine("Press the Escape (Esc) key to quit or any key to another deploy! \n");
    cki = Console.ReadKey();
} while (cki.Key != ConsoleKey.Escape);

Console.ReadKey();