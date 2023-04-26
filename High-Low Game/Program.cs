using System;
namespace MyGame
{ 
        class Program 
    { 
     
        static void Main(string[] args) 
        {
            

                Console.WriteLine("välkommen till HiLo Spel ");

            string level, input;

            Console.WriteLine("Chose your level:L=Lätt, M=Mellan,S=Svårt ");
            

            level = Console.ReadLine();

            if (level == "L")

            {

                Random random = new Random();
                bool playAgain = true;
                int min = 1;
                int max = 10;

                int guess;
                int number;
                int guesses;
                String response;
                while (playAgain)


                {
                    guess = 0;
                    guesses = 0;
                    response = "";
                    number = random.Next(min, max + 1);

                    while (guess != number)

                    {
                        Console.WriteLine("Gissa på ett tala mellan " + min + " - " + max + " : ");

                        guess = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Guess: " + guess);

                        if (guess > number)

                        {
                            Console.WriteLine(guess + " Gissningen var för håg!");

                        }
                        else if (guess < number)

                        {
                            Console.WriteLine(guess + " Gissningen var för låg!");

                        }
                        guesses++;
                    }
                    Console.WriteLine("Number: " + number);

                    Console.WriteLine("YOU WIN!");

                    Console.WriteLine("Guesses: " + guesses);

                    Console.WriteLine("Would you like to play again (Y/N): ");


                    response = Console.ReadLine();

                    response = response.ToUpper();

                    if (response == "Y")

                    {
                        playAgain = true;
                    }
                    else
                    {
                        playAgain = false;
                    }

                }


                Console.WriteLine("Thanks for playing the Game! ... ");

                Console.ReadKey();
            }

            else if (level == "M")
                    {
                        Random random = new Random();
                        bool playAgain = true;
                        int min = 1;
                        int max = 100;

                        int guess;
                        int number;
                        int guesses;
                       String response;
                        while (playAgain)


                        {
                            guess = 0;
                            guesses = 0;
                            response = "";
                            number = random.Next(min, max + 1);

                            while (guess != number)

                            {
                                Console.WriteLine("Guess a number between " + min + " - " + max + " : ");

                                guess = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("Guess: " + guess);

                                if (guess > number)

                                {
                                    Console.WriteLine(guess + " Gissningen var för håg!");
                                    

                                }
                                else if (guess < number)

                                {
                                    Console.WriteLine(guess + " Gissningen var för låg!");

                                }
                                guesses++;
                            }
                            Console.WriteLine("Number: " + number);

                            Console.WriteLine("YOU WIN!");

                            Console.WriteLine("Guesses: " + guesses);

                            Console.WriteLine("Would you like to play again (Y/N): ");


                            response = Console.ReadLine();

                            response = response.ToUpper();

                            if (response == "Y")

                            {
                                playAgain = true;
                            }
                            else
                            {
                                playAgain = false;
                            }

                        }


                        Console.WriteLine("Thanks for playing the Game! ... ");

                        Console.ReadKey();


                        }
            else _ = (level == "S");
                        {
                            Random random = new Random();
                            bool playAgain = true;
                            int min = 1;
                            int max = 1000;

                            int guess;
                            int number;
                            int guesses;
                           String response;
                            while (playAgain)


                            {
                                guess = 0;
                                guesses = 0;
                                response = "";
                                number = random.Next(min, max + 1);

                                while (guess != number)

                                {
                                    Console.WriteLine("Gissa på ett tala mellan " + min + " - " + max + " : ");

                                    guess = Convert.ToInt32(Console.ReadLine());

                                    Console.WriteLine("Guess: " + guess);

                                    if (guess > number)

                                    {
                                        Console.WriteLine(guess + " Gissningen var för håg!");

                                    }
                                    else if (guess < number)

                                    {
                                        Console.WriteLine(guess + " Gissningen var för låg!");

                                    }
                                    guesses++;
                                }
                                Console.WriteLine("Number: " + number);

                                Console.WriteLine("YOU WIN!");

                                Console.WriteLine("Guesses: " + guesses);

                                Console.WriteLine("Would you like to play again (Y/N): ");


                                response = Console.ReadLine();

                                response = response.ToUpper();

                                if (response == "Y")

                                {
                                playAgain = true;
                               }
                                else
                                {
                                playAgain = false;
                            }


                            Console.WriteLine("Would you like to play again (Y/N): ");


                            response = Console.ReadLine();

                            response = response.ToUpper();

                            if (response == "Y")

                            {
                                playAgain = true;
                            }
                            else
                            {

                                playAgain = false;
                            }



                        }
                    }

            Console.WriteLine("Thanks for playing the Game! ... ");

                Console.ReadKey();
            
               





        }
    }
}