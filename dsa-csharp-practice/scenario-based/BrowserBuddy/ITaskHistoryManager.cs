using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.BrowserBuddy
{
    public interface ITaskHistoryManager
    {
            void VisitPage(string url);
            void GoBack();
            void GoForward();
            void CloseTab();
            void RestoreTabs();
            void ShowHistory();

        }
    }

