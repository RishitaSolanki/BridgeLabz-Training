using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.BrowserBuddy
{
    public class BrowserBuddyMain
    {
        static void Main(string[] args)
        {
            ITaskHistoryManager browser = new BrowserImpl();
            BrowserMenu.DisplayMenu(browser);
        }
    }
}
