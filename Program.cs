using System;
using System.Threading; //for -> Thread.Sleep(int milliseconds);


namespace Code
{

    class Program
    {
        static void Show_Timetable(string[,] timetable)
        {
            int day_counter = 0;
            int period_counter = 0;
            int[] temp = { 1, 2 };
            foreach (int week in temp)
            {
                Console.WriteLine("Week " + temp + ":");
                foreach (string period in timetable)
                {
                    period_counter++;
                    Console.WriteLine(period);
                }
            }
        }
        static void DrawBattleShipBoard(char[,] current_board)
        {
            Console.WriteLine("  0 1 2 3 4 5 6 7 8 9");
            string numbers = "0123456789";
            for (int row = 0; row < 10; row++)
            {
                Console.Write(numbers[row]);
                for (int col = 0; col < 10; col++)
                {
                    Console.Write(" " + current_board[row, col]);
                }
                Console.Write("\n");
            }
        }
        static int Random(int min_including, int max_including)
        {
            Random rnd = new Random();
            return rnd.Next(min_including, max_including);
        }
        static void ClearLines(int Num_Lines = 0)
        {
            if (Num_Lines == 0)
            {
                Console.Clear();
            }
            else if (Num_Lines > 0)
            {
                for (int i = 0; i < Num_Lines; i++)
                {
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    Console.Write(new string(' ', Console.WindowWidth));
                    Console.SetCursorPosition(0, Console.CursorTop);
                }
            }
            else
            {
                Console.WriteLine("Error, \'ClearLines\' method called incorrectly");
            }
        }
        static void Main(string[] args)
        {

            bool running = true;
            while (running)
            {
                Console.WriteLine(
                    "0 - Exit\n" +
                    "i - Information\n" +
                    "1 - Paint Required\n" +
                    "2 - Sharing items\n" +
                    "3 - BattleShips WIP\n" +
                    "4 - Login System WIP"
                );
                Console.Write("-> ");
                string choice = Console.ReadLine().Trim().ToLower();
                ClearLines();
                switch (choice)
                {
                    case "0":
                        running = false;
                        Console.WriteLine("Program will terminate.");
                        break;
                    case "i":
                        Console.WriteLine(
                            "Created: 12/09/2026\n" +
                            "This is a program written by Adem Akyol in C#.\n" +
                            "Some code in this will have been translated from previous python code.\n" +
                            "This program will likely contain most of my code.\n" +
                            "To do: make a login system. use .txt, .json, APIs\n"
                            );
                        break;
                    case "t":
                        Console.WriteLine("test:");
                        int x = 5, y = 7;
                        Console.WriteLine($"{y / x} {y % x}");

                        break;
                    case "1":
                        Console.WriteLine("All measurements are in metres (m)");
                        double TotalArea = 0.0D;
                        bool WallLoop = true;
                        bool ValidOverall = true;
                        while (WallLoop)
                        {
                            Console.Write("Add a square surface (wall/ceiling), (Y/n): ");
                            string PaintChoice = Console.ReadLine().Trim().ToLower();
                            if (PaintChoice == "y")
                            {
                                Console.Write("Width: ");
                                double width = 0.0D;
                                string inputW = Console.ReadLine().Trim();
                                bool ValidWidth = double.TryParse(inputW, out width);
                                if (!ValidWidth)
                                {
                                    ValidOverall = false;
                                }

                                Console.Write("Height/Length: ");
                                double height = 0.0D;
                                string inputH = Console.ReadLine().Trim();
                                bool ValidHeight = double.TryParse(inputH, out height);
                                if (!ValidHeight)
                                {
                                    ValidOverall = false;
                                }

                                Console.Write("Coats of paint: ");
                                double coats = 0.0D;
                                string inputC = Console.ReadLine().Trim();
                                bool ValidCoats = double.TryParse(inputC, out coats);
                                if (!ValidCoats)
                                {
                                    ValidOverall = false;
                                }

                                if (ValidOverall)
                                {
                                    TotalArea = TotalArea + width * height * coats;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid Input detected.");
                                    WallLoop = false;
                                }
                            }
                            else
                            {
                                ClearLines(1);
                                WallLoop = false;
                            }
                        }

                        bool ValidOverallR = true;
                        if (ValidOverall)
                        {
                            bool RemoveLoop = true;
                            while (RemoveLoop)
                            {
                                Console.Write("Add an area without paint. e.g. a window, (Y/n): ");
                                string RemoveChoice = Console.ReadLine().Trim().ToLower();

                                if (RemoveChoice == "y")
                                {
                                    Console.Write("Width: ");
                                    double width = 0.0D;
                                    string inputW = Console.ReadLine().Trim();
                                    bool ValidWidth = double.TryParse(inputW, out width);
                                    if (!ValidWidth)
                                    {
                                        ValidOverallR = false;
                                    }

                                    Console.Write("Height/Length: ");
                                    double height = 0.0D;
                                    string inputH = Console.ReadLine().Trim();
                                    bool ValidHeight = double.TryParse(inputH, out height);
                                    if (!ValidHeight)
                                    {
                                        ValidOverallR = false;
                                    }

                                    if (ValidOverallR)
                                    {
                                        TotalArea = TotalArea - width * height;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid Input detected.");
                                        RemoveLoop = false;
                                    }
                                }
                                else
                                {
                                    ClearLines(1);
                                    RemoveLoop = false;
                                }
                            }
                        }
                        if (ValidOverallR)
                        {
                            string PaintArea = (TotalArea * 0.2).ToString().Trim('0').Trim('.');

                            Console.WriteLine($"You will need {PaintArea} litres of paint.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid input occured. No result");
                        }
                        break;
                    case "2":
                        bool DivideLoop = true;
                        while (DivideLoop)
                        {
                            Console.WriteLine("This code divides items evenly between groups and gives a left over.");
                            Console.Write("Enter the number of groups, (0 to exit to menu) -> ");
                            string GroupChoice = Console.ReadLine().Trim();
                            if (GroupChoice == "0")
                            {
                                DivideLoop = false;
                                continue;
                            }
                            int groups = 0;
                            bool ValidGroups = int.TryParse(GroupChoice, out groups);
                            if (!ValidGroups)
                            {
                                Console.WriteLine("Invalid Input detected.");
                                Thread.Sleep(2000);
                                ClearLines();
                                continue;
                            }

                            Console.Write("Enter the number of items -> ");
                            int items = 0;
                            string inputitems = Console.ReadLine().Trim();
                            bool validItems = int.TryParse(inputitems, out items);
                            if (!validItems)
                            {
                                Console.WriteLine("Invalid Input detected.");
                                Thread.Sleep(2000);
                                ClearLines();
                                continue;
                            }

                            Console.WriteLine($"Each group gets {items / groups} item(s) with {items % groups} item(s) left over.");

                            Console.Write("Return -> ");
                            Console.ReadLine();

                        }
                        break;
                    case "3":

                        char[,] board = {
                            {' ',' ',' ',' ',' ',' ',' ',' ',' ',' ' }, {' ',' ',' ',' ',' ',' ',' ',' ',' ',' ' },
                            {' ',' ',' ',' ',' ',' ',' ',' ',' ',' ' }, {' ',' ',' ',' ',' ',' ',' ',' ',' ',' ' },
                            {' ',' ',' ',' ',' ',' ',' ',' ',' ',' ' }, {' ',' ',' ',' ',' ',' ',' ',' ',' ',' ' },
                            {' ',' ',' ',' ',' ',' ',' ',' ',' ',' ' }, {' ',' ',' ',' ',' ',' ',' ',' ',' ',' ' },
                            {' ',' ',' ',' ',' ',' ',' ',' ',' ',' ' }, {' ',' ',' ',' ',' ',' ',' ',' ',' ',' ' }
                            };

                        char[,] board_visible = board.Clone() as char[,]; //copies board
                        //draw water
                        for (int row = 0; row < 10; row++)
                        {
                            for (int col = 0; col < 10; col++)
                            {
                                board_visible[row, col] = '~';
                            }
                        }

                        //10x10 char grid, each element of list is a row
                        //boats = C - Carrier, B - Battleship, c - Cruiser, S - Submarine, D - Destroyer
                        char[] boats = { 'C', 'B', 'c', 'S', 'D' };
                        int[] boat_sizes = { 5, 4, 3, 3, 2 };

                        List<int> ran_seed = new List<int>();
                        for (int i = 0; i < 40; i++)
                        {
                            ran_seed.Add(1)
                        }
                        for (int i = 0; i < 40; i++)
                        {
                            ran_seed.Add(0)
                        }

                        // add boats

                        for (int ship_index = 0; ship_index < boats.Length; ship_index++)
                        {
                            int ship_length = boat_sizes[ship_index];
                            char ship_type = boats[ship_index];
                            bool successful_boat = false;
                            while (!successful_boat)
                            {
                                // 0 = horizontal, 1 = verticle
                                int direction = Random(0, 1); //too fast. need new random number option
                                if (direction == 0)
                                {
                                    int current_row = Random(0, 8); // no boats can start at row 8 or 9
                                    int start_pos = Random(0, 9);
                                    bool valid_position = true;
                                    if (start_pos + ship_length > 9) //checks if it would go out of bounds
                                    {
                                        continue;
                                    }
                                    for (int coord_modifier = 0; coord_modifier < ship_length; coord_modifier++)
                                    {
                                        if (board[current_row, (start_pos + coord_modifier)] != ' ')
                                        {
                                            valid_position = false;
                                            break;
                                        }
                                    }
                                    if (valid_position)
                                    {
                                        for (int coord_modifier = 0; coord_modifier < ship_length; coord_modifier++)
                                        {
                                            board[current_row, (start_pos + coord_modifier)] = ship_type;
                                            successful_boat = true;
                                        }
                                    }
                                }

                                else
                                {
                                    int column = Random(0, 8); // no boats can start at column 8 or 9
                                    int start_row = Random(0, 9);
                                    bool valid_position = true;

                                    if (ship_length + start_row > 9)
                                    {
                                        continue;
                                    }
                                    for (int row_num = 0; row_num > 9; row_num++)
                                    {
                                        if (board[row_num, column] != ' ')
                                        {
                                            valid_position = false;
                                            break;
                                        }
                                    }
                                    if (valid_position)
                                    {
                                        for (int row_num = 0; row_num > 9; row_num++)
                                        {
                                            board[row_num, column] = ship_type;
                                            successful_boat = true;
                                        }
                                    }
                                }
                            }
                        }


                        DrawBattleShipBoard(board);





                        break;
                    case "4":

                        string[,] week_one = { { }, { }, { }, { }, { } };
                        string[,] week_two = { { }, { }, { }, { }, { } };
                        string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };



                        for (int week = 1; week < 3; week++)
                        {
                            for (int day_index = 0; day_index < 5; day_index++)
                            {
                                bool day_finished = false;
                                for (int period = 0; !day_finished; period++)
                                {
                                    Console.WriteLine($"Week {week} {days[day_index]} period {period}");
                                    Console.Write("-> ");
                                    string subject = Console.ReadLine();
                                    if (week == 1)
                                    {
                                        week_one[day_index, period] = subject;
                                    }
                                    else
                                    {
                                        week_two[day_index, period] = subject;
                                    }
                                }
                            }
                        }

                        break;

                    default:
                        Console.WriteLine("Invalid option.");
                        Console.ReadLine();
                        break;
                }
                Console.Write("Return to Main Menu -> ");
                Console.ReadLine();
                ClearLines();
            }
        }
    }
}
