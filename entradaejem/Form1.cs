﻿using MetroFramework.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace entradaejem
{
    public partial class Form1 :
    MetroFramework.Forms.MetroForm

    {
        public Form1()
        {
            InitializeComponent();
            this.StyleManager = metroSytleManager1;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e) 
        {
        }


        private void metroToggle1_CheckedChange(object sender, EventArgs e)
        {
            if (metroToggle1.Checked)
            {
                metroStyleManager1.Theme =
                        MetroFramework.MetroThemeStyle.Dark;

            }
            else
            {
                MetroStyleManager1.Theme =
                        MetroFramework.MetroThemeStyle.Light;

            }
        }
    }


}
