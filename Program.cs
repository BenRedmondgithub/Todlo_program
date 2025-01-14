Console.WriteLine("Hello");

bool shallExit = false;
while (!shallExit)

{ 
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

var userChoice = Console.ReadLine();

switch (userChoice) {

    case "E":
    case "e":
          shallExit = true;
    Console.WriteLine("Exit");
    break;

    case "S":
    case "s":
    Console.WriteLine("See all TODOs");
    break;

    case "A":
    case "a":
    Console.WriteLine("Add a TODO");
    break;

    case "R":
    case "r":
    Console.WriteLine("Remove a TODO");
    break;

    default:
    Console.WriteLine("Invalid choice");
            break;
}

}
Console.ReadKey();
