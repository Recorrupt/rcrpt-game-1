using System;
using System.Threading;

class Program
{

  /*
  rcrpt Code. 
  Lead = Ben
  Dev = Raf
  
  Situations or the INTS are identified what is happening.

  Notes:
  i keep on hella forgetting to add semicolons bruv
  Situation Codes:
  0 = Intro
  */
    static void Intro()
    {
        Console.WriteLine("You wake up in a dark room. It's cold and damp. You can't remember how you got here.");
        Console.WriteLine("You can see a faint light coming from the east.");
        Console.WriteLine("What do you do?");
    }

    static void ExploreRoom()
    {
        Console.WriteLine("You explore the room...");
        Thread.Sleep(2000);
        Console.WriteLine("You find a rusty key on the floor.");
        Console.WriteLine("There's a door to the east and another one to the west.");
        Console.WriteLine("Which door do you choose? (east/west)");
    }

    static void EastDoor()
    {
        Console.WriteLine("You open the door to the east...");
        Thread.Sleep(2000);
        Console.WriteLine("You enter a hallway.");
        Console.WriteLine("At the end of the hallway, you see a figure standing in the shadows.");
        Console.WriteLine("What do you do?");
    }

    static void WestDoor()
    {
        Console.WriteLine("You open the door to the west...");
        Thread.Sleep(2000);
        Console.WriteLine("You enter a dark room.");
        Console.WriteLine("It's too dark to see anything.");
        Console.WriteLine("What do you do.");
    }

    static void Encounter()
    {
        Console.WriteLine("The figure slowly starts to move towards you...");
        Thread.Sleep(2000);
        Console.WriteLine("You try to run but the door behind you is locked.");
        Console.WriteLine("You turn around and realize...");
        Thread.Sleep(2000);
        Console.WriteLine("It was your own shadow all along.");
        Console.WriteLine("You wake up, realizing it was all just a nightmare.");
    }

    static void Main(string[] args)
    {
        Intro();
        string choice = Console.ReadLine().ToLower();
        if (choice != null && choice == "explore")
        {
            ExploreRoom();
            choice = Console.ReadLine().ToLower();
            if (choice == "east")
            {
                EastDoor();
                Encounter();
            }
            else if (choice == "west")
            {
                WestDoor();
                Console.WriteLine("You're consumed by darkness.");
                Console.WriteLine("Game Over.");
            }
            else
            {
                Console.WriteLine("Invalid choice. Game Over.");
            }
        }
        else
        {
            Console.WriteLine("You hesitate and the darkness consumes you.");
            Console.WriteLine("Game Over.");
        }
    }
}
using System;
using System.Threading;

class Program
{
    static void Intro()
    {
        Console.WriteLine("You wake up in a dark room. It's cold and damp. You can't remember how you got here.");
        Console.WriteLine("You can see a faint light coming from the east.");
        Console.WriteLine("What do you do?");
    }

    static void ExploreRoom()
    {
        Console.WriteLine("You explore the room...");
        Thread.Sleep(2000);
        Console.WriteLine("You find a rusty key on the floor.");
        Console.WriteLine("There's a door to the east and another one to the west.");
        Console.WriteLine("Which door do you choose? (east/west)");
    }

    static void EastDoor()
    {
        Console.WriteLine("You open the door to the east...");
        Thread.Sleep(2000);
        Console.WriteLine("You enter a hallway.");
        Console.WriteLine("At the end of the hallway, you see a figure standing in the shadows.");
        Console.WriteLine("What do you do?");
    }

    static void WestDoor()
    {
        Console.WriteLine("You open the door to the west...");
        Thread.Sleep(2000);
        Console.WriteLine("You enter a dark room.");
        Console.WriteLine("It's too dark to see anything.");
        Console.WriteLine("What do you do.");
    }

    static void Encounter()
    {
        Console.WriteLine("The figure slowly starts to move towards you...");
        Thread.Sleep(2000);
        Console.WriteLine("You try to run but the door behind you is locked.");
        Console.WriteLine("You turn around and realize...");
        Thread.Sleep(2000);
        Console.WriteLine("It was your own shadow all along.");
        Console.WriteLine("You wake up, realizing it was all just a nightmare.");
    }

    static void Main(string[] args)
    {
        Intro();
        string choice = Console.ReadLine().ToLower();
        if (choice != null && choice == "explore")
        {
            ExploreRoom();
            choice = Console.ReadLine().ToLower();
            if (choice == "east")
            {
                EastDoor();
                Encounter();
            }
            else if (choice == "west")
            {
                WestDoor();
                Console.WriteLine("You're consumed by darkness.");
                Console.WriteLine("Game Over.");
            }
            else
            {
                Console.WriteLine("Invalid choice. Game Over.");
            }
        }
        else
        {
            Console.WriteLine("You hesitate and the darkness consumes you.");
            Console.WriteLine("Game Over.");
        }
    }
}
