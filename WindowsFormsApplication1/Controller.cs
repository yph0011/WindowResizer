using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            foreach(System.Diagnostics.Process p in
                System.Diagnostics.Process.GetProcesses())
            {
                if (p.MainWindowTitle.Length != 0)
                {

                    TargetWindowList.Items.Add(p.ProcessName + ':' +p.MainWindowTitle);
                }
            }
        }

    }
}
