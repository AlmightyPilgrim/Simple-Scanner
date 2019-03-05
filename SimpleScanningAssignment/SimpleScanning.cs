using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleMethods;
using FirstSight;

namespace SimpleScanningAssignment
{
    class SimpleScanning
    {
        static void Main(string[] args)
        {
            UserMethods simpleUser = new UserMethods();
            TitlePage simpleTitle = new TitlePage();
            // Select a task, next page, add a task, or delete
            simpleTitle.selectFromMenu();
            // Input Tasks
            // Choose task, going down the list
            // save in file
            simpleUser.listInput();
            // re-enter/ cross-off (grey out)
            // 25 lines to a page, including greyed out items
       
        }
    }
}
