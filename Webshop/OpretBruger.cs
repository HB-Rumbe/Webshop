﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Webshop
{
    public partial class OpretBruger : Form
    {
        public OpretBruger()
        {
            InitializeComponent();
        }

        private void OpretBruger_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void opretBruger__Click(object sender, EventArgs e)
        {
            Kunde.OpretKunde(textBox1.Text, textBox2.Text);
            MessageBox.Show("Du er nu oprettet!");
            this.Close();
        }
    }
}
