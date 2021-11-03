using System;
using System.Collections.Generic;
using System.Text;

namespace Console_App
{
    class project
    {
        static void Main(string[] args)
        {
            while (true)
            {


                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("RULES! \nSimple guess number game. Where player have their score set to 30.\nFor each incorrent guess score is decrease by 1.\nPlayer with the most score points left WIN'S THE GAME");
                Console.ResetColor();
                Console.WriteLine("Enter number of players (1 or 2):");
                int pNum = Convert.ToInt32(Console.ReadLine());

                string PLAYER1 = "Name";
                string PLAYER2 = "Name";
                int scoreP1 = 30;
                int scoreP2 = 30;


                if (pNum == 1)
                {
                    Console.WriteLine("Enter username:");
                    string x = Console.ReadLine();
                    Console.WriteLine("Enter age:");
                    int y = Convert.ToInt32(Console.ReadLine());
                    Player player = new Player(x, y);

                    Console.WriteLine("Player: " + player.name + " " + player.age + " years old");

                    PLAYER1 = player.name;

                }
                else if (pNum == 2)
                {
                    Console.WriteLine("First player enter your username:");
                    string x = Console.ReadLine();
                    Console.WriteLine("First player enter your age:");
                    int y = Convert.ToInt32(Console.ReadLine());
                    Player player = new Player(x, y);

                    Console.WriteLine("Second player enter your username:");
                    string x1 = Console.ReadLine();
                    Console.WriteLine("Second player enter your age:");
                    int y1 = Convert.ToInt32(Console.ReadLine());
                    Player player1 = new Player(x1, y1);

                    Console.WriteLine("First player is: " + player.name + " " + player.age + " years old" + "\nSecond player is: " + player1.name + " " + player1.age + " years old");

                    PLAYER1 = player.name;
                    PLAYER2 = player1.name;


                };


                if (pNum == 1)
                {
                    Console.WriteLine("\n" + PLAYER1 + "\nGOOD LUCK!");

                    Random randomSolo = new Random();
                    int secretNumSolo = randomSolo.Next(1, 11);
                    int guessNumSolo = 0;

                    while (secretNumSolo != guessNumSolo)
                    {

                        Console.WriteLine("Guess a number between 1 and 10");
                        guessNumSolo = Convert.ToInt32(Console.ReadLine());

                        if (secretNumSolo != guessNumSolo)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Wrong number, plese try again!");
                            Console.ResetColor();
                        }

                        --scoreP1;
                    };
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nGood job " + PLAYER1 + " \nNext stage is guessing for 1 to 100! \nGOOD LUCK!!!");
                    Console.ResetColor();

                    Random random100Solo = new Random();
                    int secretNumSolo100 = random100Solo.Next(1, 101);
                    int[] x = { secretNumSolo100 + 1, secretNumSolo100 + 2, secretNumSolo100 + 3, secretNumSolo100 + 4, secretNumSolo100 + 5, secretNumSolo100 - 1, secretNumSolo100 - 2, secretNumSolo100 - 3, secretNumSolo100 - 4, secretNumSolo100 - 5 };
                    int[] y = { secretNumSolo100 + 6, secretNumSolo100 + 7, secretNumSolo100 + 8, secretNumSolo100 + 9, secretNumSolo100 + 10, secretNumSolo100 - 6, secretNumSolo100 - 7, secretNumSolo100 - 8, secretNumSolo100 - 9, secretNumSolo100 - 10 };

                    while (secretNumSolo100 != guessNumSolo)
                    {

                        Console.WriteLine("Guess a number between 1 and 100");
                        guessNumSolo = Convert.ToInt32(Console.ReadLine());

                        if (secretNumSolo100 != guessNumSolo)
                        {
                            for (int i = 0; i < 10; i++)
                            {
                                if (guessNumSolo == x[i])
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("HOT!");
                                    Console.ResetColor();
                                    break;
                                }
                                else if (guessNumSolo == y[i])
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("VERY HOT!");
                                    Console.ResetColor();
                                    break;
                                }

                            }
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Wrong number, plese try again!");
                            Console.ResetColor();

                        }
                   
                        --scoreP1;
                    };

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Good job " + PLAYER1 + "!");
                    Console.ResetColor();

                    Console.WriteLine("Your score is: " + scoreP1);


                }
                else if (pNum == 2)
                {
                    Console.WriteLine("\n \n" + PLAYER1 + " is playing first! \nGOOD LUCK!");

                    Random random = new Random();
                    int secretNum = random.Next(1, 11);
                    int guessNum = 0;



                    while (secretNum != guessNum)
                    {

                        Console.WriteLine("Guess a number between 1 and 10");
                        guessNum = Convert.ToInt32(Console.ReadLine());

                        if (secretNum != guessNum)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Wrong number, plese try again!");
                            Console.ResetColor();
                        }

                        --scoreP1;
                    };

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("GOOD JOB " + PLAYER1 + "\n\n");
                    Console.ResetColor();

                    int secretNum1 = random.Next(1, 11);

                    Console.WriteLine("\n \n" + PLAYER2 + " is playeng now! \nGOOD LUCK!");

                    while (secretNum1 != guessNum)
                    {

                        Console.WriteLine("Guess a number between 1 and 10");
                        guessNum = Convert.ToInt32(Console.ReadLine());

                        if (secretNum1 != guessNum)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Wrong number, plese try again!");
                            Console.ResetColor();
                        }

                        --scoreP2;
                    };
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("GOOD JOB " + PLAYER2 + "\n\n");
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("SECOND STAGE! GUESS NUMBER FOR 1 TO 100\n" + PLAYER1 + " playing again!");
                    Console.ResetColor();

                    Random random100Solo = new Random();
                    int secretNumSolo100 = random100Solo.Next(1, 101);
                    int[] x = { secretNumSolo100 + 1, secretNumSolo100 + 2, secretNumSolo100 + 3, secretNumSolo100 + 4, secretNumSolo100 + 5, secretNumSolo100 - 1, secretNumSolo100 - 2, secretNumSolo100 - 3, secretNumSolo100 - 4, secretNumSolo100 - 5 };
                    int[] y = { secretNumSolo100 + 6, secretNumSolo100 + 7, secretNumSolo100 + 8, secretNumSolo100 + 9, secretNumSolo100 + 10, secretNumSolo100 - 6, secretNumSolo100 - 7, secretNumSolo100 - 8, secretNumSolo100 - 9, secretNumSolo100 - 10 };

                    while (secretNumSolo100 != guessNum)
                    {

                        Console.WriteLine("Guess a number between 1 and 100");
                        guessNum = Convert.ToInt32(Console.ReadLine());

                        if (secretNumSolo100 != guessNum)
                        {
                            for (int i = 0; i < 10; i++)
                            {
                                if (guessNum == x[i])
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("HOT!");
                                    Console.ResetColor();
                                    break;
                                }
                                else if (guessNum == y[i])
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("VERY HOT!");
                                    Console.ResetColor();
                                    break;
                                }

                            }
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Wrong number, plese try again!");
                            Console.ResetColor();

                            --scoreP1;

                        }
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("GOOD JOB " + PLAYER1 + "\n\n");
                    Console.ResetColor();

                    Console.WriteLine(PLAYER2 + " playing now!");

                    Random random100Solo1 = new Random();
                    int secretNumSolo1001 = random100Solo1.Next(1, 101);
                    int[] x1 = { secretNumSolo1001 + 1, secretNumSolo1001 + 2, secretNumSolo1001 + 3, secretNumSolo1001 + 4, secretNumSolo1001 + 5, secretNumSolo1001 - 1, secretNumSolo1001 - 2, secretNumSolo1001 - 3, secretNumSolo1001 - 4, secretNumSolo1001 - 5 };
                    int[] y1 = { secretNumSolo1001 + 6, secretNumSolo1001 + 7, secretNumSolo1001 + 8, secretNumSolo1001 + 9, secretNumSolo1001 + 10, secretNumSolo1001 - 6, secretNumSolo1001 - 7, secretNumSolo1001 - 8, secretNumSolo1001 - 9, secretNumSolo1001 - 10 };

                    while (secretNumSolo1001 != guessNum)
                    {

                        Console.WriteLine("Guess a number between 1 and 100");
                        guessNum = Convert.ToInt32(Console.ReadLine());

                        if (secretNumSolo1001 != guessNum)
                        {
                            for (int i = 0; i < 10; i++)
                            {
                                if (guessNum == x1[i])
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("HOT!");
                                    Console.ResetColor();
                                    break;
                                }
                                else if (guessNum == y1[i])
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("VERY HOT!");
                                    Console.ResetColor();
                                    break;
                                }

                            }
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Wrong number, plese try again!");
                            Console.ResetColor();

                            --scoreP2;

                        }
                    }

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("GAME IS OVER \n" + PLAYER1 + " score is: " + scoreP1 + "\n" + PLAYER2 + " score is: " + scoreP2);
                    Console.ResetColor();
                    if (scoreP1 > scoreP2)
                    {
                        Console.WriteLine(PLAYER1 + " is the WINNER");
                    }
                    else if (scoreP1 < scoreP2)
                    {
                        Console.WriteLine(PLAYER2 + " is the WINNER");
                    }
                    else
                    {
                        Console.WriteLine("DRAW");
                    };


                }

                Console.WriteLine("Play Again? [Y or N]");

                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
            }

        }
    }
}




