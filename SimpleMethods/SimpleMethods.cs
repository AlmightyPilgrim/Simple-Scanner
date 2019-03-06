using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

// Still need to add ranges to the list, limits to 25.
namespace SimpleMethods
{
    public class UserMethods
    {
        List<string> inputList = new List<string>();
        
        public string taskInput()
        {
            // task input method, NEEDS TO BE EXPANDED UPON, adding to
            // the input to turn it into a list, or having another method.
            Console.Write("Input task: ");
            string task = Console.ReadLine();
            return task;
        }

        public string listInput()
        {
            string path = @"C:\Users\Bret Hayes\OneDrive\Desktop\TestFile.txt";
            var inputList = System.IO.File.ReadLines(path).ToList();
            bool check = true;    
            string task = "broken";
            //method for the list of entries
            
            while (check == true)
            {
                currentList();
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
                        return check = false; // default is sending user back through the loop, instead of handling
                }
                
            }
        }
        
        public void numberList()
        {
            string path = @"C:\Users\Bret Hayes\OneDrive\Desktop\TestFile.txt";
            var inputList = System.IO.File.ReadLines(path).ToList();

            currentList();          
        }

        public void selectTask()
        {
            string path = @"C:\Users\Bret Hayes\OneDrive\Desktop\TestFile.txt";
            var inputList = System.IO.File.ReadLines(path).ToList();
            bool check = false;
            while (check != true)
            {
                Console.Clear();
                currentList();

                Console.WriteLine("Which task do you wish to work on?");
                var choice = Console.ReadLine();
                Console.WriteLine("Is the task finished?");
                var confirm = Console.ReadLine();
                if (confirm == "yes")
                {
                    inputList[Convert.ToInt32(choice) - 1] = inputList[Convert.ToInt32(choice) - 1] + '-';
                }
                else if (confirm == "no")
                {
                    inputList.Add(inputList[Convert.ToInt32(choice) - 1]);
                    inputList[Convert.ToInt32(choice) - 1] = inputList[Convert.ToInt32(choice) - 1] + '-';
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
            }

            File.WriteAllLines(path, inputList);
        }

        public void deleteTask()
        {
            string path = @"C:\Users\Bret Hayes\OneDrive\Desktop\TestFile.txt";
            var inputList = System.IO.File.ReadLines(path).ToList();
            bool check = false;
            while (check != true)
            {
                currentList();

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

        public void currentList()
        {
            string path = @"C:\Users\Bret Hayes\OneDrive\Desktop\TestFile.txt";
            var inputList = System.IO.File.ReadLines(path).ToList();
            
            try
            {
                for (int line = 0; line < 25; line++)
                {
                    if (inputList[line].Contains("-"))
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                        Console.ForegroundColor = ConsoleColor.Blue;
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
    }
}
