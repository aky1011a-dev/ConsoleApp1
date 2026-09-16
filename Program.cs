// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("bye world");
//some test comments
//hello


string[,] week_one = {{},{},{},{},{}};
string[,] week_two = {{},{},{},{},{}};
string[] days = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday"};



foreach (int week = 1; week < 3; week++)
{
    foreach (int day_index = 0; day_index < 5; day_index++)
    {
        bool day_finished = false;
        foreach (int period = 0; !day_finished; period++)
        {
            Console.WriteLine($"Week {week} {days[day_index} period {period}");
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

static void Show_Timetable