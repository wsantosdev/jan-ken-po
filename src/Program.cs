using JanKenPo;

var cpu = new Player();

void Play()
{
    Console.WriteLine("Enter 1 for Rock, 2 for Paper or 3 for Scissors. Press Esc to quit.");
    var keyInfo = Console.ReadKey();
    
    if (keyInfo.Key is ConsoleKey.Escape)
    {
        Console.Write("See you next time.");
        Environment.Exit(0);
    }

    IShape playerSelectedShape = keyInfo.Key switch
    {
        ConsoleKey.D1 or ConsoleKey.NumPad1 => new Rock(),
        ConsoleKey.D2 or ConsoleKey.NumPad2 => new Paper(),
        ConsoleKey.D3 or ConsoleKey.NumPad3 => new Scissors(),
        _ => new None()
    };

    if (playerSelectedShape is None)
    {
        Console.WriteLine("\nBad choice! Try again.");
        Environment.Exit(0);
    }

    var cpuSelectedShape = cpu.Play();

    var result = cpu.CheckResult(playerSelectedShape, cpuSelectedShape);
    Console.Write($"\nYou played {playerSelectedShape.GetType().Name}. ");
    Console.Write($"\nCPU played {cpuSelectedShape.GetType().Name}. ");
    switch (result)
    {
        case -1:
            Console.WriteLine("\nYou won!");
            break;
        case 0:
            Console.WriteLine("\nDraw game.");
            break;
        case 1:
            Console.WriteLine("\nYou loose.");
            break;
    }
    Console.Write("\n");
    Play();
}

Play();