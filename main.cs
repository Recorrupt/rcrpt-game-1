using System;
using System.Threading;

class Program
{

  /*
  rcrpt Code. 
  Lead = Ben
  Dev = Raf
  
  Situations or the INTS are identified what is happening.

  Situation Codes:
  0 = Intro
  */
    static void Intro()
    {
      // Intro. Idk whats the rest
      int situation = 0
        Console.WriteLine("You wake up in a dark room. It's cold and damp. You can't remember how you got here.");
        Console.WriteLine("You can see a faint light coming from the east.");
        Console.WriteLine("What do you do?");
    }

    static void ExploreRoom()
    {
      int situation = 1
        Console.WriteLine("You explore the room...");
        Thread.Sleep(2000);
        Console.WriteLine("You find a rusty key on the floor.");
        Console.WriteLine("There's a door to the east and another one to the west.");
        Console.WriteLine("Which door do you choose? (east/west)");
    }

    static void EastDoor()
    {
      int situation = 2
        Console.WriteLine("You open the door to the east...");
        Thread.Sleep(2000);
        Console.WriteLine("You enter a hallway.");
        Console.WriteLine("At the end of the hallway, you see a figure standing in the shadows.");
        Console.WriteLine("What do you do?");
    }

    static void WestDoor()
    {
      int situation = 3
        Console.WriteLine("You open the door to the west...");
        Thread.Sleep(2000);
        Console.WriteLine("You enter a dark room.");
        Console.WriteLine("It's too dark to see anything.");
        Console.WriteLine("What do you do?");
      string identifier = "westdoorchoice"
    }

    static void Encounter()
    {
      int situation = 4
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

        if (choice == "explore")
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
