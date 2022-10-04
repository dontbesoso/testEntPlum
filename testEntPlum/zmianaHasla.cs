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
    public partial class frmZmianaHasla : Form
    {
        private static string tmpUser = "";
        public frmZmianaHasla(string user)
        {
            tmpUser = user;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tmpNewPass = "", tmpConfirmNewPass = "";

            tmpNewPass = txtNewPass.Text.ToString().ToUpper();
            tmpConfirmNewPass = txtConfirmNewPass.Text.ToString().ToUpper();

            if (tmpNewPass.Length > 0)
            {
                if (tmpNewPass != tmpConfirmNewPass)
                {
                    MessageBox.Show("nowe hasło musi być równe...");
                }
                else
                {
                    if (tmpNewPass.Length < 6)
                    {
                        // dodać regex.compare
                        MessageBox.Show("Nowe hasło musi zawierać 6 znaków");
                    }
                    else
                    {
                        // właściwa zmiana hasła
                    }
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
