using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputCPU;
            int randomInt;
            int scorePlayer = 0;
            int scoreCPU = 0;

            Console.WriteLine("Choose Rock, Paper, or Scissors");
            inputPlayer = Console.ReadLine();
            inputPlayer = inputPlayer.ToUpper();
            

            Random rnd = new Random();
            randomInt = rnd.Next(1, 4);

            switch (randomInt)
            {
                case 1:
                    inputCPU = "Rock";
                    Console.WriteLine("Computer chose Rock");
                    if (inputPlayer == "Rock")
                    {
                        Console.WriteLine("Draw!\n\n");
                    }
                    else if (inputPlayer == "Paper")
                    {
                        Console.WriteLine("Player Wins\n\n");
                        scorePlayer++;
                    }
                    else if (inputPlayer == "Scissors");
                    {
                        Console.WriteLine("CPU wins! \n\n");
                        scoreCPU++;

                    }
                    break;
                case 2:
                    inputCPU = "Paper";
                    if (inputPlayer == "Rock")
                    {
                        Console.Writeline("CPU won\n\n");
                        scoreCPU++;
                    }
                    else if (inputPlayer == "Paper")
                    {
                        Console.Writeline("Draw!\n\n");
                    }
                    else if (inputPlayer == "Scissors") 
                    {
                        Console.Writeline("Player wins!\n\n");
                    break;
                case 3:
                    inputCPU = "Scissors";
                    break;
                default:
                    Console.WriteLine("Invalid Entry");
                    break;
            }
        }
    }
}
