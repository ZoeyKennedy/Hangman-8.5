using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace Hangman_8._5
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            art();

            int hangman;
            hangman = 0;
            string guess;
            string assignSecretWord;
            string secretWord;
            Random rand = new Random();
            int randomNum;
            Console.WriteLine("Type a secret word that your friend will guess.");
            Console.WriteLine("If you are playing alone, type '1' for a random word.");
            assignSecretWord = Console.ReadLine();

            


            if (assignSecretWord == "1")
            {
                randomNum = rand.Next(1, 10);

                switch (randomNum)
                {  
                    case 1:
                        secretWord = "";
                        break;

                        case 2:
                        secretWord = "";
                        break; 

                    case 3:
                        secretWord = "";
                        break;

                    case 4:
                        secretWord = "";
                        break;

                        case 5:
                        secretWord = "";
                        break;

                        case 6:
                        secretWord = "";
                        break;

                        case 7:
                        secretWord = "";
                        break;

                        case 8:
                        secretWord = "";

                        break;


                        case 9:
                        secretWord = "";
                        break;

                        case 10:
                        secretWord = "";

                        break;

                }
            }

            else
            {
                secretWord = assignSecretWord; 

            }

            Console.ReadLine();
            while (hangman >= 6)
            { Console.WriteLine("Guess a letter");
                Console.WriteLine();
                guess = Console.ReadLine();
               
                if (secretWord.Contains(guess))
                {
                    Console.WriteLine();
                }
            }

        }

        public static void art()
        {

            int hangman;
            hangman = 0;

            if (hangman <= 6)
            {
                switch (hangman)
                {
                    case 0:
                            Console.WriteLine("      +---+"); 
                            Console.WriteLine("      |   |"); 
                            Console.WriteLine("          |"); 
                            Console.WriteLine("          |"); 
                            Console.WriteLine("          |"); 
                            Console.WriteLine("          |"); 
                            Console.WriteLine("      ========="); 
                            break;
                        case 1:
                            Console.WriteLine("      +---+"); 
                            Console.WriteLine("      |   |"); 
                            Console.WriteLine("      O   |"); 
                            Console.WriteLine("      |   |"); 
                            Console.WriteLine("          |"); 
                            Console.WriteLine("          |"); 
                            Console.WriteLine("      ========="); 
                            break;

                            case 2:
                            Console.WriteLine("      +---+"); 
                            Console.WriteLine("      |   |"); 
                            Console.WriteLine("      O   |"); 
                            Console.WriteLine("     /|   |"); 
                            Console.WriteLine("          |"); 
                            Console.WriteLine("          |"); 
                            Console.WriteLine("      ========="); 
                            break;

                             case 3:
                            Console.WriteLine("      +---+"); 
                            Console.WriteLine("      |   |"); 
                            Console.WriteLine("      O   |"); 
                            Console.WriteLine("     /|/  |"); 
                            Console.WriteLine("          |"); 
                            Console.WriteLine("          |"); 
                            Console.WriteLine("      ========="); 
                            break;

                              case 4:
                            Console.WriteLine("      +---+"); 
                            Console.WriteLine("      |   |"); 
                            Console.WriteLine("      O   |"); 
                            Console.WriteLine("     /|/  |"); 
                            Console.WriteLine("     /    |"); 
                            Console.WriteLine("          |"); 
                            Console.WriteLine("      ========="); 
                            break;

                             

                               case 5:
                            Console.WriteLine("      +---+"); 
                            Console.WriteLine("      |   |"); 
                            Console.WriteLine("      O   |"); 
                            Console.WriteLine("     /|/  |"); 
                            Console.WriteLine("     / /  |"); 
                            Console.WriteLine("          |"); 
                            Console.WriteLine("      ========="); 
                            break;

                                case 6:
                            Console.WriteLine("      +---+"); 
                            Console.WriteLine("      |   |"); 
                            Console.WriteLine("          |"); 
                            Console.WriteLine("     /O/  |"); 
                            Console.WriteLine("      |   |"); 
                            Console.WriteLine("     / /  |"); 
                            Console.WriteLine("      =========");
                        Console.WriteLine();
                        Console.WriteLine("You lost!");
                            break;

                }

                





            }


        }
    }
}
