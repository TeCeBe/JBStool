using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JBS_Tool
{
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }

        private void test_Load(object sender, EventArgs e)
        {
            countdownTimer.Start();
        }

        private void countdownTimer_Tick(object sender, EventArgs e)
        {
            countdownTimer.Stop();
            this.Close();
        }
    }
}
