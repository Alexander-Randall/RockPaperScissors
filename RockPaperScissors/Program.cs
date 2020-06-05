using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    enum Selection
    {
        Rock, Paper, Scissors
    }

    enum Outcome
    {
        Win, Lose, Draw
    }

    static void Main(string[] args)
    {
        bool keepPlaying = true;

        while (keepPlaying)
        {
            Outcome roundOutcome = GetGameOutcome(GetPlayerInput(), GetComputerInput());
            if(roundOutcome == Outcome.Win)
            {
                Console.WriteLine("you win\n");
            }else if(roundOutcome == Outcome.Lose)
            {
                Console.WriteLine("you lose\n");
            }
            else if (roundOutcome == Outcome.Draw)
            {
                Console.WriteLine("draw\n");
            }
        }
    }

    static Selection GetPlayerInput()
    {
        bool validInput = false;
        Selection toReturn = Selection.Paper;
        while (!validInput)
        {
            Console.WriteLine("Select: Rock, Paper, or Scissors");
            string playerInput = Console.ReadLine();

            if (playerInput.Equals("rock" , StringComparison.OrdinalIgnoreCase))
            {
                toReturn = Selection.Rock;
                validInput = true;
            }
            else if (playerInput.Equals("paper", StringComparison.OrdinalIgnoreCase))
            {
                toReturn = Selection.Paper;
                validInput = true;
            }
            else if (playerInput.Equals("scissors", StringComparison.OrdinalIgnoreCase))
            {
                toReturn = Selection.Scissors;
                validInput = true;
            }   
            else if (playerInput.Equals("Quit", StringComparison.OrdinalIgnoreCase))
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Entry invalid\n");
            }
        }
        return toReturn;
    } 

    static Selection GetComputerInput()
    {
        Random rnd = new Random();
        int randomNumber = rnd.Next(0, 3);
        Selection selection = (Selection) randomNumber;
        Console.WriteLine("Computer selected " + selection);
        return selection;
    }

    static Outcome GetGameOutcome(Selection player, Selection computer)
    {
        if  (player == Selection.Paper && computer == Selection.Rock)
        {
            return Outcome.Win;
        }
        else if (player == Selection.Rock && computer == Selection.Scissors)
        {
            return Outcome.Win;
        }
        else if (player == Selection.Scissors && computer == Selection.Paper)
        {
            return Outcome.Win;
        }
        else if (player == Selection.Scissors && computer == Selection.Rock)
        {
            return Outcome.Lose;
        }
        else if (player == Selection.Paper && computer == Selection.Scissors)
        {
            return Outcome.Lose;
        }
        else if (player == Selection.Rock && computer == Selection.Paper)
        {
            return Outcome.Lose;
        }
        else
        {
            return Outcome.Draw;
        }
    }
}
