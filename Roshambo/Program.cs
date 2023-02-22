// Roshambo App
// Jeff Santucci
// 02/20/2023

using Roshambo;
using System.Xml.Serialization;
using static Roshambo.Player;
Human human = new Human();
Rock rock = new Rock();
Any random = new Any();



string[] RoshamboArray = new string[3];

RoshamboArray[0] = "Rock";
RoshamboArray[1] = "Paper";
RoshamboArray[2] = "Scissors";

bool isOpponent = false;
string opponentName;

do
{
    Console.Write("Enter your name: ");
    string playerName = Console.ReadLine();
    do
    {
        Console.WriteLine("Select your Opponent either Rock or Random");
        opponentName = Console.ReadLine();
        if (opponentName == "Rock" || opponentName == "Random")
        {
            isOpponent = true;
        }
    } while (isOpponent == false); 
   
            for (int i = 0; i < RoshamboArray.Length; i++)
            {
                Console.WriteLine($"{i + 1}.{RoshamboArray[i]}");
            }
            Console.WriteLine(playerName + " choose one - 1. Rock, 2. Paper or 3. Scissors");
            int num = int.Parse(Console.ReadLine());
            string answer = RoshamboArray[num - 1];

            human.choice = answer;
            human.name = playerName;
            human.RoshamboValue();

            if (opponentName == "Rock")
            {
                rock.name = "Rock";
                rock.choice = "Rock!";
                rock.RoshamboValue();

                if (human.choice == "Paper")
                {
                    Console.WriteLine(human.name + " is a winner! Paper beats Rock!");
                }
                else if (human.choice == "Rock")
                {
                    Console.WriteLine(human.name + " and " + rock.name + " Tied!");
                }
                else
                {
                    Console.WriteLine(rock.name + " wins! Rock beats " + human.choice + "!");
                }
            }
            else if (opponentName == "Random")
            {
                random.name = "Random";
                random.RoshamboValue();

                if (human.choice == random.choice)
                {
                    Console.WriteLine(human.name + " and " + random.name + " Tied!");
                }
                else if (human.choice == "Paper" && random.choice == "Rock")
                {
                    Console.WriteLine(human.name + " is a winner! " + human.choice + " beats " + random.choice + "!");
                }
                else if (human.choice == "Rock" && random.choice == "Scissors")
                {
                    Console.WriteLine(human.name + " is a winner! " + human.choice + " beats " + random.choice + "!");
                }
                else if (human.choice == "Scissors" && random.choice == "Paper")
                {
                    Console.WriteLine(human.name + " is a winner! " + human.choice + " beats " + random.choice + "!");
                }
                else if (human.choice == "Rock" && random.choice == "Paper")
                {
                    Console.WriteLine(random.name + " is a winner! " + random.choice + " beats " + human.choice + "!");
                }
                else if (human.choice == "Scissors" && random.choice == "Rock")
                {
                    Console.WriteLine(random.name + " is a winner! " + random.choice + " beats " + human.choice + "!");
                }
                else
                {
                    Console.WriteLine(random.name + " is a winner! " + random.choice + " beats " + human.choice + "!");
                }

            }
        
   Console.WriteLine("Play Again? y/n");
   

} while (Console.ReadLine()=="y");
Console.WriteLine("Thanks for playing .... Goodbye!");
