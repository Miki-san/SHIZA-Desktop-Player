﻿using System;
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
    public partial class SHIZA_App_LoadWindow : Form
    {
        public SHIZA_App_LoadWindow()
        {
            InitializeComponent();
        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState != 3)
            {
                this.Hide();
                Form ifrm = new SHIZA_App_mainWindow();
                ifrm.ShowDialog();
            }
        }
    }
}
