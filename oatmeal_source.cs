using System.ComponentModel.Design;
using System.Net.Security;
using System.Runtime.InteropServices;

namespace OATVTTE
{
 internal class Program
    {
 static void Main(string[] _1)
    {
	/* These are the commands.
	go forward
	look around
    room    */            


	Random rnd = new Random();
            // "roomNumber" is what room you are currently in. If it is greater than a specific number, it will go to the next level.
            int roomNumber = 0;
            int trapFake = 0;
            while (roomNumber < 10)
            {
                // This is the randomizer. If it is over 8, it prints line 21.
                int chanceTrap = rnd.Next(1, 10);
                bool trapRoom = false;
                Console.WriteLine("> You went forward.");
                // Makes the "trap room", if that randomizer prints anything over 8.
                if (chanceTrap > 5)
                {
                    Console.WriteLine("> Something feels off...");
                    trapRoom = true;
                }
                // afterNotice makes it so that the above doesn't occur.
            afterNotice:
                string choiceC = Console.ReadLine();
                if (choiceC != "look around")
                {
                    if (choiceC == "go forward")
                    {
                        roomNumber++;
                        goto winer;
                    }
                    if (choiceC == "room")
                    {
                        Console.WriteLine("> If I can remember, I went through " + roomNumber, "rooms");
                        goto afterNotice;
                    }
                    else
                    {
                        Console.WriteLine("> I don't know what that means.");
                        goto afterNotice;
                    }
                winer:;
                    trapRoom = false;
                }
                // Doing this command will disable any traps in the room (make trapRoom false). Left is true and right is false.
                else
                {
                    Console.WriteLine(trapRoom ? "> There's a trap here! You disable it. 100 points." : "> There's nothing wrong here.");
                    if (trapRoom = false)
                    {
                        trapFake++;
                    }
                    trapRoom = false;
                    goto afterNotice;
                }
            }
            // This is the end. Your score will be shown, but since roomNumber isn't two digits, it multiplies by 10.
            Console.WriteLine("> You found the exit.");
            Console.WriteLine("Score:");
            Console.WriteLine(roomNumber * 10);
            Thread.Sleep(5000);
            }
        }
    }

