using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMethods
{
    public class SimpleScanMethods
    {
        public string taskInput(string task)
        {
            // task input method
            Console.WriteLine("What task do you have have that needs to be done?");
            task = Console.ReadLine();
            return task;
        }

        public char choiceMenu(char select)
        {
            //Main menu selection of add, modify, or delete
            Console.WriteLine("Would you like to:");
            Console.WriteLine("[A] - Create New\n\t[B] - Modify Existing\n");
            select = char.Parse(Console.ReadLine());
            return select;
        }
    }
}
