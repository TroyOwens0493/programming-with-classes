using System;

class Program
{
    static void Main(string[] args)
    {
        int breathsThisSession = 0;
        int reflectionsThisSession = 0;
        int listsThisSession = 0;
        do
        {
            Console.Clear();
            Console.WriteLine("Welcome to the mindfullness program! Please choose what you would like to do");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. See history");
            Console.WriteLine("5. Quit");
            string selection = Console.ReadLine();

            if (selection == "1")
            {
                breathsThisSession++;
                Breathing breathe = new();
                breathe.BreathingLoop();
            }
            else if (selection == "2")
            {
                reflectionsThisSession++;
                Reflcting reflect = new();
                reflect.ReflectingLoop();
            }
            else if (selection == "3")
            {
                listsThisSession++;
                Listing list = new();
                list.ListingLoop();
            }
            else if (selection == "4")
            {
                Console.Clear();
                Console.Write("Would you like to see your stats for the 1. month or for the 2. year? ");
                string input = Console.ReadLine();
                InAndOut reader = new();
                List<string> data = new();
                string range = "";

                if (input == "1")
                {
                    range = "month";
                }
                else
                {
                    range = "year";
                }

                data = reader.GetFromDateRange(range);
                Console.Clear();
                Console.WriteLine($"In the past {range} you have done the breathing activity {data[0]} times.\n You have done the relfection activity {data[1]} times. \n You have done the listing activity {data[2]} times.");
                Console.WriteLine();
                Console.WriteLine("Please note that the stats are updated each time you quit the program");
                Console.WriteLine();
                Console.WriteLine("Press any enter to continue");
                Console.ReadLine();
            }
            else
            {
                InAndOut writer = new();
                writer.WriteSessionData(new List<string> { breathsThisSession.ToString(), reflectionsThisSession.ToString(), listsThisSession.ToString() });
                System.Environment.Exit(0);
            }
        } while (true);
    }
}
