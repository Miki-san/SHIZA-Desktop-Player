using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHIZA_App
{
    public partial class SHIZA_App_mainWindow : Form
    {
        public SHIZA_App_mainWindow()
        {
            InitializeComponent();
        }

        private void SHIZA_App_mainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
