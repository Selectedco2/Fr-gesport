

using System.ComponentModel;

Console.ForegroundColor = ConsoleColor.Cyan;

int points =  0;

Console.WriteLine("State your name challanger");

string name = Console.ReadLine();

Console.WriteLine("Well then " + name + " shall we get started?");
Console.WriteLine( );
Console.WriteLine("1st question: What game won the Game of the year awards year 2022? ");
Console.WriteLine("A) God of war: Ragnarok. B) Elden ring. C) Stray. ");
    string question1 = Console.ReadLine().ToUpper();
    
    if (question1 == "B") 
    {
        Console.WriteLine("Good job!");
        points++;
    }
    else
    {
        Console.WriteLine("Not quite!");
    }
Console.WriteLine( );
Console.WriteLine("Okay, next question!");
Console.WriteLine( );
Console.WriteLine("In “Undertale”, what is the name of the boss character that loves spaghetti and puzzles?");
Console.WriteLine("A) Sans B) Napstablook C) Papyrus"); 
    string question2 = Console.ReadLine().ToUpper();

    if (question2 == "C")
    {
        Console.WriteLine("Damn, you're smart");
        points++;
    }
    else
    {
        Console.WriteLine("Nah, better luck next time. The answer was Papyrus!");

    }
Console.WriteLine( );
Console.WriteLine("Last question now!");
Console.WriteLine( );
Console.WriteLine("What is the name of the world in “Minecraft” where Endermen come from?");
Console.WriteLine("A) The aether B) The nether C) The end");
string question3 = Console.ReadLine().ToUpper();

    if (question3 == "C")
    {
        Console.WriteLine("That's correct! Good job.");
        points++;
    }
    else
    {
        Console.WriteLine("Nope, incorrect. The answer was “The end”.");

    }

    Console.WriteLine( );
Console.WriteLine("Okay, next question!");
Console.WriteLine( );

// Japan eleven gjorde denna fråga

// Console.WriteLine("Which ones Minecraft character?");
// Console.WriteLine("a) Pip b) naohito c) Enderman"); 
//     string question4 = Console.ReadLine().ToUpper();

//     if (question4 == "C")
//     {
//         Console.WriteLine("You are a genius");
//         points++;
//     }
//     else
//     {
//         Console.WriteLine("jävla fitta");

//     }
Console.WriteLine( );

Console.WriteLine("Here are your final points, challenger!");

if (points <= 1)
{
    Console.WriteLine("-" + points + "-");
    Console.WriteLine("Better luck next time");

}

else if (points == 2)
{
    Console.WriteLine("-" + points + "-");
    Console.WriteLine("Almost full points? I'm impressed");
}

else if (points == 3)
{
    Console.WriteLine("-" + points + "-");
    Console.WriteLine("Damn, you really are a master when it comes to gaming knowledge!");

}



Console.ReadLine();