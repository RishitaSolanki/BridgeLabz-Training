using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.BrowserBuddy
{
    public class BrowserTab
    {
        private string url;
        private BrowserTab next;
        private BrowserTab previous;
        public BrowserTab Next
        {
            get { return next; }
            set { next = value; }
        }
        public BrowserTab Previous
        {
            get { return previous; }
            set { next = value; }
        }
        public string Url
        {
            get { return url; }
            set { url = value;}
        }
        public BrowserTab(string url)
        {
            Url = url;
            Next = null;
            Previous = null;
        }
    }
}

