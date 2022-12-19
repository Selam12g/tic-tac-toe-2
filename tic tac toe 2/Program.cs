// See https://aka.ms/new-console-template for more information


namespace TIK__TAK_TOE2
{

    class Program
    {
        public static string player = "x";
        public static string[] arr = new string[9];
        public static int counter;
        public static string winner = "";
        public static bool win = false;
        static void Main(string[] args)
        {

            Console.WriteLine("wellcome to Tic Tac Toi Game");

            string menu;

            Console.WriteLine(@"  1. New Game       2. About author        3. exit");
            menu = Console.ReadLine();
            if (menu == "1")
            {
                while (counter < 9 && !win)
                {

                    int num;



                    while (!win)
                    {
                        Console.WriteLine("\n\n" + player + "'s move");
                        if (int.TryParse(Console.ReadLine(), out num) && num <= 10 && arr[num - 1] == null)
                        {

                            if (player == "x")
                            {
                                arr[num - 1] = "x";
                            }
                            else if (player == "o")
                            {
                                arr[num - 1] = "o";
                            }
                            counter++;
                            break;
                        }

                        else
                            Console.WriteLine("Illegal move! Try again.");
                    }


                    for (int i = 0; i < 9; i++)
                    {
                        if ((i == 1) || (i == 4) || (i == 7))
                        {
                            Console.Write(" ");
                        }
                        Console.Write(arr[i] + " ");
                        if (arr[i] == null)
                        {
                            Console.Write(" ");
                        }
                        if ((i == 2) || (i == 5) || (i == 8))
                        {
                            Console.WriteLine();
                        }
                        if ((i == 2) || (i == 5))
                        {
                            Console.WriteLine("--+--- +---");
                        }
                        if ((i == 0) || (i == 1) || (i == 3) || (i == 4) || (i == 6) || (i == 7))
                        {
                            Console.Write(" | ");
                        }
                    }



                    if ((arr[0] == player && arr[1] == player && arr[2] == player) || (arr[1] == player && arr[4] == player && arr[7] == player))
                    {
                        win = true;
                        winner = player;
                    }
                    else if ((arr[0] == player && arr[3] == player && arr[6] == player) || (arr[3] == player && arr[4] == player && arr[5] == player))
                    {
                        win = true;
                        winner = player;
                    }
                    else if ((arr[2] == player && arr[5] == player && arr[8] == player) || (arr[6] == player && arr[7] == player && arr[8] == player))
                    {
                        win = true;
                        winner = player;

                    }
                    else if ((arr[0] == player && arr[4] == player && arr[8] == player) || (arr[2] == player && arr[4] == player && arr[6] == player))
                    {
                        win = true;
                        winner = player;
                    }


                    if (player == "x")
                    {
                        player = "o";
                    }
                    else if (player == "o")
                    {
                        player = "x";
                    }

                }

                if (!win)
                    Console.WriteLine("no winner");
                else
                    Console.WriteLine(winner + " winns");
            }
            else if (menu == "2")
            {
                Console.WriteLine("selam Waktoli; student at wsb");
            }
            else if (menu == "3")
            {
                Console.WriteLine("you have successfully Quit the game");
                System.Environment.Exit(0);
            }


        }


    }



}