using System;

namespace Lab3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string rerun;
            int userChoice;
            bool worked;
            string catChoice = "";

            do
            {
                string[] names = { "Alan", "Bob", "Carl", "David", "Eric", "Frank", "George", "Hank", "Ian", "Jack" };
                string[] favCandy = { "Almond Joy", "Baby Ruth", "Carmello", "Dots", "Extra Gum", "Fun Dip", "Gummi Bears", "Hot Tamales", "Ice Breakers", "Jaw Breakers" };
                string[] preTitle= { "Accounting", "Banking", "Consulting", "Default", "Enterprise", "Finance", "Geologist", "Human", "Insurance", "Joker" };
                
                do
                {
                    Console.Write("What student would you like to know about? Enter number 1-10 or 0 for a list of students: ");
                    worked = int.TryParse(Console.ReadLine(), out userChoice);
                    if (!worked || userChoice > 10 || userChoice < 0)
                    {
                        Console.WriteLine("Sorry, this is not a valid input.");
                        worked = false;
                    }
                    else if(userChoice == 0)
                    {
                        for (int i = 0; i < names.Length; i++)
                        {
                            Console.WriteLine($"{i + 1}: {names[i]}");
                        }
                        worked = false;
                    }
                } while (!worked);

                worked = false;
                while (!worked)
                {
                    Console.Write($"You selected {names[userChoice-1]}. What would you like to know about the student. Enter favorite candy or previous title: ");
                    catChoice = Console.ReadLine();
                    catChoice = catChoice.ToLower();

                    if (catChoice == "favorite candy" || catChoice == "previous title")
                    {
                        worked = true;
                    }
                    else
                    {
                        Console.WriteLine("This is not a valid input.");
                        worked = false;
                    }
                }

                if(catChoice == "favorite candy")
                {
                    Console.WriteLine($"{names[userChoice-1]}'s favorite candy is {favCandy[userChoice-1]}.");
                    //Console.WriteLine($"Would you like to learn more about {names[userChoice-1]}");


                }
                else
                {
                    Console.WriteLine($"{names[userChoice - 1]}'s previous position was {preTitle[userChoice - 1]}.");
                    //Console.WriteLine($"Would you like to learn more about {names[userChoice - 1]}");
                }
                
                //Check if user would like to continue
                Console.WriteLine("Would you like to know about another student: y/n");
                rerun = Console.ReadLine();
                rerun = rerun.ToLower();

                while(rerun != "y" && rerun != "n")
                {
                    Console.WriteLine("This is not a valid input. Would you like to continue: y/n");
                    rerun = Console.ReadLine();
                    rerun = rerun.ToLower();
                }
            }
            while (rerun == "y");
        }
    }
}
