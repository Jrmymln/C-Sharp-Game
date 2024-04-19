using System;

namespace QuizGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int lives = 3;

            string correctAnswer = "James Gosling";
            string answer;

            while (lives > 0)
            {
                Console.WriteLine();
                Console.Write("Answer: ");
                answer = Console.ReadLine();

                if (answer.Equals(correctAnswer))
                {
                    Console.WriteLine("You Win!");
                    break;
                }
                else
                {
                    lives--;
                    Console.WriteLine("Incorrect answer. Lives remaining: " + lives);
                }

                if (lives == 0)
                {
                    Console.WriteLine("You Lose");
                }

                Console.WriteLine();
            }
        }
    }
}
