using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using SimpleMethods;

namespace FirstSight
{
    public class TitlePage
    {
        UserMethods simpleUser = new UserMethods();
        public char choiceMenu()
        {
            Console.WriteLine("Welcome to task center, where you enter tasks that you need completed." +
                "\nAlso, giving the option to marks completed and worked on tasks.");
            Console.WriteLine("\nWould you like to:");
            Console.WriteLine("\n\t[A] - Add Task\n\t[B] - Select\n\t[C] - Next Page\n\t[D] - Delete\n");
            char select = char.Parse(Console.ReadLine());
            Console.Clear();
            return select;
        }

        public char selectFromMenu()
        {
            char select = 'a';
            bool check = true;
            while (check == true)
            {
                select = choiceMenu();
                switch (select)
                {
                    case 'A':
                        simpleUser.listInput();
                        break;
                    case 'B': 
                        simpleUser.selectTask();
                        break;
                    case 'C':
                        simpleUser.pageList();
                        break;
                    case 'D':
                        simpleUser.deleteTask();
                        break;
                    default:
                        Console.WriteLine("Invalid Entry");
                        break;
                }
                Console.WriteLine("Do you wish to modify your task list more?" +
                    "\n\t[y] - yes\n\t[n] - no");
                string answer = Console.ReadLine();
                if (answer == "y")
                {                   
                    check = true;
                }
                else if (answer == "n")
                {
                    check = false;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                    check = true;
                }
                Console.Clear();
            }
            return select;
        }
    }
}
