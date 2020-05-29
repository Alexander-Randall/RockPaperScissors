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

    static void Main(string[] args)
    {
        bool keepPlaying = true;

        while (keepPlaying)
        {
            GetPlayerInput();
            
            keepPlaying = false;
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

            if (playerInput.ToLower() == "rock")
            {
                toReturn = Selection.Rock;
                validInput = true;
            }
            else if (playerInput.ToLower() == "paper")
            {
                toReturn = Selection.Paper;
                validInput = true;
            }
            else if (playerInput.ToLower() == "scissors")
            {
                toReturn = Selection.Scissors;
                validInput = true;
            }
            else
            {
                Console.WriteLine("Entry invalid");
            }
            
            
            if (ComputerInput.ToLower() == "rock")
            {
                toReturn = Selection.Rock;
                validInput = true;
            }
            else if (ComputerInput.ToLower() == "paper")
            {
                toReturn = Selection.Paper;
                validInput = true;
            }
            else if (ComputerInput.ToLower() == "scissors")
            {
                toReturn = Selection.Scissors;
                validInput = true;
            }
        }
        return toReturn;
    } 
        
}
