using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testEntPlum
{
    public partial class frmAddEditEmployee : Form
    {
        int currentEmployee = 0;
        public frmAddEditEmployee(int idPracownika = 0)
        {
            InitializeComponent();
            if (idPracownika != 0)
            {
                currentEmployee = idPracownika;
                using (var context = new Adam_AsprovaEntities1())
                {
                    var pracownik = context.plum_pracownicy.First(k => k.id == currentEmployee);

                    this.txtCardNumber.Text = pracownik.cardId;
                    this.txtEmployeeName.Text = pracownik.name;
                }

            }
        }

        private void btnAddSave_Click(object sender, EventArgs e)
        {
            string cardNumber = this.txtCardNumber.ToString();
            string employeeName = this.txtEmployeeName.ToString();
            if (currentEmployee != 0)
            {
                MessageBox.Show(this.txtCardNumber.Text.Length.ToString());

                if (!valCardNumber(this.txtCardNumber.Text.Trim()))
                {
                    MessageBox.Show("Nieprawidłowy numer karty. Numer karty to ...");
                } else
                {
                    using (var context = new Adam_AsprovaEntities1())
                    {

                        var pracownik = context.plum_pracownicy.First(k => k.id == currentEmployee);

                        pracownik.cardId = this.txtCardNumber.Text.Trim();
                        pracownik.name = this.txtEmployeeName.Text.Trim();
                        context.SaveChanges();
                    }
                    Close();
                }
                
            }
            else
            {
                if (!valCardNumber(this.txtCardNumber.Text.Trim()))
                {
                    MessageBox.Show("Nieprawidłowy numer karty. Numer karty to ...");
                }
                else
                {
                    var tmpPracownik = new plum_pracownicy { cardId = this.txtCardNumber.Text.Trim(), name = this.txtEmployeeName.Text.Trim(), description = "", hasAdmin = "false" };
                    using (var context = new Adam_AsprovaEntities1())
                    {
                        context.plum_pracownicy.Add(tmpPracownik);
                        context.SaveChanges();

                    }
                    Close();
                }
            }
            

        }

        private bool valCardNumber(string cardId)
        {
            Regex pattern = new Regex(@"(?<!\d)\d{10}(?!\d)");

            if (pattern.IsMatch(cardId))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
