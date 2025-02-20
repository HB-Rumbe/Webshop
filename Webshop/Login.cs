using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Webshop
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void brugernavnBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void adgangskodeBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void login__Click(object sender, EventArgs e)
        {
            Bruger loggedInUser = Bruger._Login(brugernavnBox.Text, adgangskodeBox.Text); ;

            if (loggedInUser != null)
            {
                WebshopForm webshop = new WebshopForm();
                this.Hide();
                webshop.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Ukendt bruger");
            }

        }
        private void opretBruger__Click(object sender, EventArgs e)
        {
            OpretBruger opretBruger = new OpretBruger();
            this.Hide();
            opretBruger.ShowDialog();
            this.Show();
        }
    }
}
