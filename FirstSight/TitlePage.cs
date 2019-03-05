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
        public char choiceMenu(char select)
        {
            //Main menu selection of add, modify, or delete
            Console.WriteLine("Would you like to:");
            Console.WriteLine("\n\t[A] - Create New\n\t[B] - Select\n\t[C] - Next Page\n\t[D] - Delete\n");
            select = char.Parse(Console.ReadLine());
            Console.Clear();
            return select;
        }

        public char selectFromMenu()
        {
            char select = 'a';
            choiceMenu(select);
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

                    break;
                default:
                    Console.WriteLine("Invalid Entry");
                    break;
            }
            return select;
        }
    }
}
