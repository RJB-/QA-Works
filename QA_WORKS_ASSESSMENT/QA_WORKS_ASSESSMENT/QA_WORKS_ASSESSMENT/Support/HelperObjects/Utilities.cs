using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace QA_WORKS_ASSESSMENT.Support.HelperObjects
{
    class Utilities
    {
        public void CloseAllBrowsers()
        {
            Process[] AllProcesses = Process.GetProcesses();
            foreach (var process in AllProcesses)
            {
                if (process.MainWindowTitle != "")
                {
                    string s = process.ProcessName.ToLower();
                    if (s == "firefox" || s == "iexplore" || s == "chrome")
                        process.Kill();
                }
            }
        }
    }
}
