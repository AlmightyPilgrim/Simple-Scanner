﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SimpleMethods
{
    public class UserMethods
    {
        List<string> inputList = new List<string>();

        public string taskInput()
        {           
            Console.Write("Input task: ");
            string task = Console.ReadLine();
            return task;
        }

        public string listInput()
        {
            string path = @"C:\Users\Bret Hayes\OneDrive\Desktop\TestFile.txt";
            var inputList = System.IO.File.ReadLines(path).ToList();
            bool check = true;
            string task = "broken"; // broken must remain, if removed program breaks
            //method for the list of entries

            while (check == true)
            {
                firstHalfOfList();
                task = taskInput();
                inputList.Add(task);
                string appendText = task + Environment.NewLine;
                File.AppendAllText(path, appendText);

                Console.WriteLine("More Tasks?");
                string answer = Console.ReadLine();
                switch (answer)
                {
                    case "yes":
                        check = true;
                        break;
                    case "no":
                        check = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        check = false;
                        break; // default is sending user back through the loop, instead of handling
                }

                Console.Clear();
            }
            numberList();
            return task;
        }

        public bool moreTasks(bool check)
        {
            while (true)
            {
                Console.WriteLine("More Tasks?");
                string answer = Console.ReadLine();
                switch (answer)
                {
                    case "yes":
                        return check = true;
                    case "no":
                        return check = false;
                    default:
                        Console.WriteLine("Invalid Input");
                        return check = false;
                }

            }
        }

        public void numberList()
        {
            string path = @"C:\Users\Bret Hayes\OneDrive\Desktop\TestFile.txt";
            var inputList = System.IO.File.ReadLines(path).ToList();

            firstHalfOfList();
        }

        public void selectTask()
        {
            bool check = false;
            while (check != true)
            {
                string path = @"C:\Users\Bret Hayes\OneDrive\Desktop\TestFile.txt";
                var inputList = System.IO.File.ReadLines(path).ToList();
                Console.Clear();
                firstHalfOfList();

                Console.WriteLine("Which task do you wish to work on?");
                var choice = Console.ReadLine();
                Console.WriteLine("Is the task finished?" +
                    "[yes or no]");
                var confirm = Console.ReadLine();
                if (confirm == "yes")
                {
                    inputList[Convert.ToInt32(choice) - 1] = inputList[Convert.ToInt32(choice) - 1] + "\u00A0";
                }
                else if (confirm == "no")
                {
                    inputList.Add(inputList[Convert.ToInt32(choice) - 1]);
                    inputList[Convert.ToInt32(choice) - 1] = inputList[Convert.ToInt32(choice) - 1] + "\u00A0";
                }
                else
                {
                    Console.WriteLine("Invalid User Input");
                }
                Console.WriteLine("Are there more selections? [y/n]");
                switch (Console.ReadLine())
                {
                    case "y":
                        break;
                    case "n":
                        check = true;
                        break;
                    default:
                        Console.WriteLine("Invalid Entry");
                        check = true;
                        break;
                }
            File.WriteAllLines(path, inputList);            
            }            
        }

        public void deleteTask()
        {
            string path = @"C:\Users\Bret Hayes\OneDrive\Desktop\TestFile.txt";
            var inputList = System.IO.File.ReadLines(path).ToList();
            bool check = false;
            while (check != true)
            {
                firstHalfOfList();

                Console.WriteLine("Which task line number do you wish to remove?");
                string choice = Console.ReadLine();

                inputList.RemoveAt(Convert.ToInt32(choice) - 1);
                File.WriteAllLines(path, inputList);

                Console.WriteLine("Is there more to delete? [y/n]");
                switch (Console.ReadLine())
                {
                    case "y":
                        break;
                    case "n":
                        check = true;
                        break;
                    default:
                        Console.WriteLine("Invalid Entry");
                        check = true;
                        break;
                }
                Console.Clear();
            }
        }

        public void firstHalfOfList()
        {
            string path = @"C:\Users\Bret Hayes\OneDrive\Desktop\TestFile.txt";
            var inputList = System.IO.File.ReadLines(path).ToList();

            try
            {
                for (int line = 0; line < 25; line++)
                {
                    if (inputList[0].Contains("\u00A0"))
                    {
                        inputList.RemoveAt(0);
                        File.WriteAllLines(path, inputList);
                    }
                    else
                    {
                    }
                    if (inputList[line].Contains("\u00A0"))
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine($"{line + 1}: {inputList[line]}");
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"{line + 1}: {inputList[line]}");
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("You do not have 25 tasks yet.");
            }
        }

        public void secondHalfOfList()
        {
            string path = @"C:\Users\Bret Hayes\OneDrive\Desktop\TestFile.txt";
            var inputList = System.IO.File.ReadLines(path).ToList();

            try
            {
                for (int line = 25; line < 50; line++)
                {
                    if (inputList[0].Contains("\u00A0"))
                    {
                        inputList.RemoveAt(25);
                        File.WriteAllLines(path, inputList);
                    }
                    else
                    {
                    }
                    if (inputList[line].Contains("\u00A0"))
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine($"{line + 1}: {inputList[line]}");
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"{line + 1}: {inputList[line]}");
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("You do not have 50 tasks yet.");
            }
        }

        public void pageList()
        {
            string path = @"C:\Users\Bret Hayes\OneDrive\Desktop\TestFile.txt";
            var inputList = System.IO.File.ReadLines(path).ToList();
            bool check = true;
            while (check == true)
            {
                Console.WriteLine("Do you want to view your first 25 lines or second 25?" +
                    "\n\t\t Answer with" +
                    "\n\t [First]\t [Second]");
                string answer = Console.ReadLine();
                if (answer == "First")
                {
                    firstHalfOfList();
                    Console.WriteLine("Do you wish to view more? y/n");
                    string choice = Console.ReadLine();
                    if (choice == "y")
                    {
                        check = true;
                    }
                    else
                    {
                        check = false;
                    }
                }
                else if (answer == "Second")
                {
                    secondHalfOfList();
                    Console.WriteLine("Do you wish to view more? y/n");
                    string choice = Console.ReadLine();
                    if (choice == "y")
                    {
                        check = true;
                    }
                    else
                    {
                        check = false;
                    }
                }
                else
                {
                    Console.WriteLine("I am sorry, your entry does not compute.");
                    Console.WriteLine("Do you wish to actually view a list? y/n");
                    string choice = Console.ReadLine();
                    if (choice == "y")
                    {
                        check = true;
                    }
                    else
                    {
                        check = false;
                    }

                }
                Console.Clear();
            }
        }
    }
}
