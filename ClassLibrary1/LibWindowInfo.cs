using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibWindowInfo;

namespace LibWindowInfo 
{
    public class WindowManager

    {
        public List<Process> GetProcessesWithWIndow()
        {
            List<Process> pList = new List<Process>(); 
            foreach (Process p in Process.GetProcesses())
            {
                if (p.MainWindowTitle.Length != 0) pList.Add(p);
            }
            return pList;
        }
    }
}
