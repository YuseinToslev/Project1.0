namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string playerMove = string.Empty; //=> "";
            const string rock = "Rock";
            const string paper = "Paper";
            const string scissors = "Scissors";

            Console.Write("Choose [r]ock,[p]aper or [s]cissors: ");
            string input = Console.ReadLine();

            if (input == "r" || input == "rock")
            {
                playerMove = "Rock";
            }
            else if (input == "p" || input == "paper")
            {
                playerMove = "Paper";
            }
            else if (input == "s" || input == "scissors")
            {
                playerMove = "Scissors";
            }
            else
            {
                Console.WriteLine("Wrong input. Try again...");
                return;
            }

            Random random = new Random();
            int computerRandomMove = random.Next(1, 4);

            string computerMove = string.Empty;

            //switch(computerRandomMove)
            //{
            //    case 1:
            //        ComputerMove = "Rock";
            //        break;
            //}

            if (computerRandomMove == 1)
            {
                computerMove = "Rock";
            }
            else if (computerRandomMove == 2)
            {
                computerMove = "Paper";
            }
            else if (computerRandomMove == 3)
            {
                computerMove = "Scissors";
            }
            Console.WriteLine($"Computer choose {computerMove}");

            if ((playerMove == "Rock" && computerMove == "Scissors")
                || (playerMove == "Scissors" && computerMove == "Paper")
                || (playerMove == "Paper" && computerMove == "Rock"))
            {
                Console.WriteLine("Player won!");
            }
            else if ((playerMove == "Scissors" && computerMove == "Rock")
                || (playerMove == "Paper" && computerMove == "Scissors")
                || (playerMove == "Rock" && computerMove == "Paper"))
            {
                Console.WriteLine("Computer won!");
            }
            else
                Console.WriteLine("It's a draw!");

        }
    }
}