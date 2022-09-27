using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testEntPlum
{
    public partial class Logowanie : Form
    {
        public Logowanie()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string password, username;

            password = txtLogin.Text.ToString().ToUpper();
            username = txtPass.Text.ToString().ToUpper();

            if ((string.Compare(username, "ADAM") == 0) && (string.Compare(password, "TEST") == 0))
                MessageBox.Show(password + " " + username);
            else
            {
                MessageBox.Show(password + " " + username);
                txtLogin.Text = "";
                txtPass.Text = "";
            }
            

        }
    }
}
