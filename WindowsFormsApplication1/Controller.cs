using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibWindowInfo;

namespace WindowsFormsApplication1
{
    public partial class Controller : Form
    {
        public Controller()
        {
            InitializeComponent();
        }

        private void ListUpWindows_Click(object sender, EventArgs e)
        {
            WindowManager winman = new WindowManager();
            List<Process> pList = winman.GetProcessesWithWIndow();
            int i = 0;
            foreach(Process p in pList)
            {
                string lblstr = p.ProcessName + " : " + p.MainWindowTitle;
                TargetWindowList.Items.Add(lblstr);
            }
            TargetWindowList.Refresh();
        }

    }
}
