namespace Hangman_8._5
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int hangman;


           
        }

        public static void art()
        {

            int hangman;
            hangman = 0;

           while (hangman >= 7)
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
                            Console.WriteLine("     /|\  |"); 
                            Console.WriteLine("          |"); 
                            Console.WriteLine("          |"); 
                            Console.WriteLine("      ========="); 
                            break;

                              case 4:
                            Console.WriteLine("      +---+"); 
                            Console.WriteLine("      |   |"); 
                            Console.WriteLine("      O   |"); 
                            Console.WriteLine("     /|\  |"); 
                            Console.WriteLine("     /    |"); 
                            Console.WriteLine("          |"); 
                            Console.WriteLine("      ========="); 
                            break;

                             

                               case 5:
                            Console.WriteLine("      +---+"); 
                            Console.WriteLine("      |   |"); 
                            Console.WriteLine("      O   |"); 
                            Console.WriteLine("     /|\  |"); 
                            Console.WriteLine("     / \  |"); 
                            Console.WriteLine("          |"); 
                            Console.WriteLine("      ========="); 
                            break;

                                case 6:
                            Console.WriteLine("      +---+"); 
                            Console.WriteLine("      |   |"); 
                            Console.WriteLine("          |"); 
                            Console.WriteLine("     \O/  |"); 
                            Console.WriteLine("      |   |"); 
                            Console.WriteLine("     / \  |"); 
                            Console.WriteLine("      ========="); 
                            break;




                }

            }


        }
    }
}
