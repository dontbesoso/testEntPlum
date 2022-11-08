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
        private static int tmpUser = -1;
        public frmZmianaHasla(int user)
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

            tmpNewPass = txtNewPass.Text.ToString();
            tmpConfirmNewPass = txtConfirmNewPass.Text.ToString();

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
                        using (var context = new Adam_AsprovaEntities1())
                        {


                            var std = context.plum_uzytkownicy.First(p => p.id == tmpUser);
                            if (std != null)
                            {
                                try
                                {
                                    DateTime newPassDate = DateTime.Now;
                                    std.passdate = DateTime.Parse(newPassDate.ToShortDateString());
                                    std.password = Logowanie.SHA256(tmpNewPass).ToUpper();
                                    //MessageBox.Show("Hasło użytkownika zostało zmienione." + " data: " + std.passdate.ToString() + " hasło: " + std.password.ToString());
                                    context.SaveChanges();
                                    Close();
                                } catch(Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                            }
                        }
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
