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
            //Main menu selection of add, modify, or delete
            Console.WriteLine("Would you like to:");
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
                    case 'B': // change, saying that has worked on or completed, this will be the greyed out section.

                        break;
                    case 'C':

                        break;
                    case 'D':
                        simpleUser.deleteTask();
                        break;
                    default:
                        Console.WriteLine("Invalid Entry");
                        break;
                }
                Console.WriteLine("Is there more?\n\t[y] - yes\n\t[n] - no");
                if (Console.ReadLine() == "y")
                {                   
                    check = true;
                }
                else
                {
                    check = false;
                }
                Console.Clear();
            }
            return select;
        }
    }
}
