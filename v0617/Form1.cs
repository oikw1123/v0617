﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v0617
{
    public partial class Form1 : Form
    {
        int vx = -10;
        int vy = -10;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int.Parse(label1.Text);
            int.Parse(label1.Text);
            
            label1.Left = vx;
            label1.Top = vy;
            if (vx <= -1)
            {
                vx = -10;
            }
            if (vy <= -1)
            {
                vy = -10;
            }
        }

    }
}
