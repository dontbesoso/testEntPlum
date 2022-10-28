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
    public partial class frmAddEditEmployee : Form
    {
        int currentEmployee = 0;
        public frmAddEditEmployee(int idPracownika = 0)
        {
            InitializeComponent();
            MessageBox.Show(idPracownika.ToString());
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
            // if () waliduj poprawność numeru karty
            string cardNumber = this.txtCardNumber.ToString();
            string employeeName = this.txtEmployeeName.ToString();
            if (currentEmployee != 0)
            {
                using (var context = new Adam_AsprovaEntities1())
                {
                    var pracownik = context.plum_pracownicy.First(k => k.id == currentEmployee);

                    pracownik.cardId = this.txtCardNumber.Text.Trim();
                    pracownik.name = this.txtEmployeeName.Text.Trim();
                    context.SaveChanges();
                }
            } else
            {
                // add
            }

        }
    }
}
