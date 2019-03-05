using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstSight
{
    public class TitlePage
    {
        public char choiceMenu(char select)
        {
            //Main menu selection of add, modify, or delete
            Console.WriteLine("Would you like to:");
            Console.WriteLine("\n\t[A] - Create New\n\t[B] - Modify Existing\n\t[C] - Select\n\t[D] - Delete\n");
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

                    break;
                case 'B':

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
