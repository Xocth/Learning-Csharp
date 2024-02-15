using System;

namespace MultiplicationQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playAgain = true;

            while (playAgain)
            {
                playAgain = PlayQuiz();
            }

            Console.WriteLine("\nThank you for playing! Press any key to exit.");
            Console.ReadKey();
        }

        static bool PlayQuiz()
        {
            Random random = new Random();
            int score = 0;

            Console.Clear();
            Console.WriteLine("\n __       __            __    __      __            __  __                      __      __                             ______             __           \r\n|  \\     /  \\          |  \\  |  \\    |  \\          |  \\|  \\                    |  \\    |  \\                           /      \\           |  \\          \r\n| $$\\   /  $$ __    __ | $$ _| $$_    \\$$  ______  | $$ \\$$  _______  ______  _| $$_    \\$$  ______   _______        |  $$$$$$\\ __    __  \\$$ ________ \r\n| $$$\\ /  $$$|  \\  |  \\| $$|   $$ \\  |  \\ /      \\ | $$|  \\ /       \\|      \\|   $$ \\  |  \\ /      \\ |       \\       | $$  | $$|  \\  |  \\|  \\|        \\\r\n| $$$$\\  $$$$| $$  | $$| $$ \\$$$$$$  | $$|  $$$$$$\\| $$| $$|  $$$$$$$ \\$$$$$$\\\\$$$$$$  | $$|  $$$$$$\\| $$$$$$$\\      | $$  | $$| $$  | $$| $$ \\$$$$$$$$\r\n| $$\\$$ $$ $$| $$  | $$| $$  | $$ __ | $$| $$  | $$| $$| $$| $$      /      $$ | $$ __ | $$| $$  | $$| $$  | $$      | $$ _| $$| $$  | $$| $$  /    $$ \r\n| $$ \\$$$| $$| $$__/ $$| $$  | $$|  \\| $$| $$__/ $$| $$| $$| $$_____|  $$$$$$$ | $$|  \\| $$| $$__/ $$| $$  | $$      | $$/ \\ $$| $$__/ $$| $$ /  $$$$_ \r\n| $$  \\$ | $$ \\$$    $$| $$   \\$$  $$| $$| $$    $$| $$| $$ \\$$     \\\\$$    $$  \\$$  $$| $$ \\$$    $$| $$  | $$       \\$$ $$ $$ \\$$    $$| $$|  $$    \\\r\n \\$$      \\$$  \\$$$$$$  \\$$    \\$$$$  \\$$| $$$$$$$  \\$$ \\$$  \\$$$$$$$ \\$$$$$$$   \\$$$$  \\$$  \\$$$$$$  \\$$   \\$$        \\$$$$$$\\  \\$$$$$$  \\$$ \\$$$$$$$$\r\n                                         | $$                                                                              \\$$$                        \r\n                                         | $$                                                                                                          \r\n                                          \\$$                                                                                                          \n");
            Console.WriteLine("Please double click the top of the tab for the full experience");
            Console.WriteLine("Press 'h' for help or any other key to start the quiz.");
            char userInput = Console.ReadKey().KeyChar;

            if (userInput == 'h' || userInput == 'H')
            {
                DisplayHelp();
                Console.WriteLine("\nPress 'h' for help or any other key to start the quiz.");
                Console.ReadKey();
                return true; // Play again after help
            }
            else if (char.IsDigit(userInput)) // Check if a number key is pressed
            {
                Console.WriteLine("\nInvalid input. Please press 'h' for help or any other key to start the quiz.");
                Console.ReadKey();
                return true; // Play again after invalid input
            }

            Console.WriteLine("\nLet's get started!\n");

            for (int i = 1; i <= 10; i++)
            {
                int num1 = random.Next(1, 11);
                int num2 = random.Next(1, 11);
                int correctAnswer = num1 * num2;

                Console.Write($"Question {i}: What is {num1} x {num2}? ");
                int userAnswer;

                while (!int.TryParse(Console.ReadLine(), out userAnswer) || userAnswer < 1 || userAnswer > 100)
                {
                    Console.WriteLine("Please do not type text or symbols!\nEnter a number between 1 and 100.");
                    Console.Write($"Question {i}: What is {num1} x {num2}? ");
                }

                if (userAnswer == correctAnswer)
                {
                    Console.WriteLine("Correct!");
                    score++;
                }
                else
                {
                    Console.WriteLine($"Wrong! The correct answer is {correctAnswer}.");
                }
            }

            Console.WriteLine($"\nWell done! You got {score} out of 10 correct.");

            if (score < 3)
            {
                Console.WriteLine("Z   z                                  //////////////_               \r\n           Z   O               __\\\\\\\\@   //^^        _-    \\///////    \r\n        Z    z   o       _____((_     \\-/ ____/ /   {   { \\\\       }     \r\n                   o    0__________\\\\\\---//____/----//__|-^\\\\\\\\\\\\\\\\     \r\n\r\nYou are an Ambitious Anteater, you never give up!");
            }
            else if (score < 6)
            {
                Console.WriteLine("          __\r\n     w  c(..)o   (\r\n      \\__(-)    __)\r\n          /\\   (\r\n         /(_)___)\r\n         w /|\r\n          | \\\r\n         m  m\r\n\r\nYou are a Cheeky Monkey, keep on swinging and try for a higher score!");
            }
            else if (score < 9)
            {
                Console.WriteLine(" _/\\___\r\n(      \\\r\n \\______\\/{\r\nYou are a Noble Narwhal, continuously swimming will get you to the top!");
            }
            else
            {
                Console.WriteLine("                \\||/\r\n                |  @___oo\r\n      /\\  /\\   / (__,,,,|\r\n     ) /^\\) ^\\/ _)\r\n     )   /^\\/   _)\r\n     )   _ /  / _)\r\n /\\  )/\\/ ||  | )_)\r\n<  >      |(,,) )__)\r\n ||      /    \\)___)\\\r\n | \\____(      )___) )___\r\n  \\______(_______;;; __;;;\r\n\r\nYou are a Mighty Dragon, you are above all animals!");
            }

            Console.WriteLine("\nWould you like to play again? (Y/N)");
            char playAgainInput = Console.ReadKey().KeyChar;
            return (playAgainInput == 'Y' || playAgainInput == 'y');
        }

        static void DisplayHelp()
        {
            Console.WriteLine("\nWelcome to Multiplication Quiz!");
            Console.WriteLine("If you need help, enter the number for which you want to see the multiplication table.");
            Console.WriteLine("For example, if you enter '2', you will see the multiplication table of 2.\n");

            Console.WriteLine("Enter a number: ");
            int userInput;
            while (!int.TryParse(Console.ReadLine(), out userInput) || userInput < 1 || userInput > 10)
            {
                Console.WriteLine("Please enter a valid integer between 1 and 10.");
                Console.WriteLine("Enter a number: ");
            }

            Console.WriteLine($"\nMultiplication Table of {userInput}:\n");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{userInput} x {i} = {userInput * i}");
            }
        }
    }
}
