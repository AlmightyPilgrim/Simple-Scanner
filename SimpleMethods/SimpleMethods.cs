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
            Console.WriteLine("Input task: ");
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
            for (int x = 0; x < inputList.Count; x++)
            {
                Console.WriteLine($"{x + 1}: {inputList[x]}");
            }
            while (check == true)
            {
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
            var lineNumbers = System.IO.File.ReadLines(path).ToList();
          
            for (int x = 0; x < lineNumbers.Count; x++)
            {
                Console.WriteLine($"{x + 1}: {lineNumbers[x]}");
            }            
        }

        public void selectTask()
        {
            string path = @"C:\Users\Bret Hayes\OneDrive\Desktop\TestFile.txt";
            var inputList = System.IO.File.ReadLines(path).ToList();
            Console.WriteLine("Which task do you wish to work on?");

            for (int x = 0; x < inputList.Count; x++)
            {
                Console.WriteLine($"{x + 1}: {inputList[x]}");
            }

            string choice = Console.ReadLine();

        }

        public void deleteTask()
        {
            string path = @"C:\Users\Bret Hayes\OneDrive\Desktop\TestFile.txt";
            var inputList = System.IO.File.ReadLines(path).ToList();

            for (int x = 0; x < inputList.Count; x++)
            {
                Console.WriteLine($"{x+1}: {inputList[x]}");
            }

            Console.WriteLine("Which task line number do you wish to remove?");
            string choice = Console.ReadLine();
            
            inputList.RemoveAt(Convert.ToInt32(choice) - 1);
            File.WriteAllLines(path, inputList);            

            Console.Clear();
        }
    }
}
