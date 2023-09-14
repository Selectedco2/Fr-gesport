

int points =  0;

Console.WriteLine("State your name challanger");

string name = Console.ReadLine();

Console.WriteLine("Well then " + name + " shall we get started?");
Console.WriteLine( );
Console.WriteLine("1st question: What game won the Game of the year awards year 2022? ");
Console.WriteLine("A) God of war: Ragnarok. B) Elden ring. C) Stray. ");
Console.ReadLine();
string question1 = Console.ReadLine().ToLower();
    
    if (question1 == "B")
    {
        Console.WriteLine("Good job!");
        points++;
    }








Console.ReadLine();