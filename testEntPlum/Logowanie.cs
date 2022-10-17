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

        public static string SHA256(string randomString)
        {
            var crypt = new System.Security.Cryptography.SHA256Managed();
            var hash = new System.Text.StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(randomString));
            foreach (byte theByte in crypto)
            {
                hash.Append(theByte.ToString("x2"));
            }
            return hash.ToString();
        }

        public static string MD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                 StringBuilder sb = new System.Text.StringBuilder();
                 for (int i = 0; i < hashBytes.Length; i++)
                 {
                     sb.Append(hashBytes[i].ToString("X2"));
                 }
                 return sb.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string password, username;

            username = txtLogin.Text.ToString().ToUpper().Trim();
            password = SHA256(txtPass.Text.ToString().Trim());
            
            using (var context = new Adam_AsprovaEntities1())
            {

                var std = context.plum_uzytkownicy_
                    .FirstOrDefault((a => a.username == username));
                    if (std != null)
                        if (std.password.ToString() == password.ToUpper())
                        {
                            DateTime czasLogowania = DateTime.Now;
                            DateTime czasHasla =(DateTime)std.passdate;

                            int timePeriod = (int)(czasLogowania - czasHasla).TotalDays;
                            if (timePeriod > 30) {
                                frmZmianaHasla newPassForm = new frmZmianaHasla(std.id);
                            newPassForm.Show();
                            }
                            else {
                            mainList oknoProgramu = new mainList(std.id);
                            oknoProgramu.Show();
                            txtLogin.Text = "";
                            txtPass.Text = "";
                            }
                        } else {
                            
                            MessageBox.Show("Nieprawidłowy login lub hasło"  );
                        }
                    else {
                        MessageBox.Show("Nieprawidłowy login lub hasło");
                    }
                
            }

     


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
