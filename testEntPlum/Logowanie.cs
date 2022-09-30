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

            string sysUser = "ADAM";
            string sysPass = "TEST";

            username = txtLogin.Text.ToString().ToUpper().Trim();
            password = txtPass.Text.ToString().ToUpper().Trim();


            if ((username == sysUser.ToUpper().Trim()) && (password == sysPass.ToUpper().Trim()))
            {
                MessageBox.Show("Sukces");
                mainList listaLogowan = new mainList();
                listaLogowan.Show();
                txtLogin.Text = "";
                txtPass.Text = "";
            }
            else
            {
                MessageBox.Show("Nieprawidłowy login lub hasło.");
                txtLogin.Text = "";
                txtPass.Text = "";
            }
            

        }
    }
}
