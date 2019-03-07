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
            // calling the method selectFromMenu to run the entirety of the code
            // One Line to RULE THEM ALL.
            simpleTitle.selectFromMenu();     
            // This a good thing?
        }
    }
}
