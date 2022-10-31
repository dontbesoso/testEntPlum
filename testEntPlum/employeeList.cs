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
    public partial class employeeList : Form
    {
        public employeeList()
        {
            InitializeComponent();
            updateGridCaption();
        }

        private void FormClosed(object sender, FormClosedEventArgs e)
        {
            updateGridCaption();
        }

        private void updateGridCaption()
        {

            using (var context = new Adam_AsprovaEntities1())
            {
                var std = context.plum_pracownicy
                        .Select(p => new { p.id, p.name, p.cardId })
                        .OrderBy(p => p.name).ToList();
                grdEmployee.DataSource = std;

            }

            foreach (DataGridViewColumn column in grdEmployee.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int rowindex = grdEmployee.CurrentRow.Index;
            DataGridViewRow selectedRow = grdEmployee.Rows[rowindex];
            
            frmAddEditEmployee oknoPracownika = new frmAddEditEmployee(Convert.ToInt32(selectedRow.Cells["id"].Value));
            oknoPracownika.FormClosed += FormClosed;
                oknoPracownika.Show();
            
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            frmAddEditEmployee oknoPracownika = new frmAddEditEmployee();
            oknoPracownika.FormClosed += FormClosed;
            oknoPracownika.Show();
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Czy na pewno usunąć wskazanego pracownika?", "Potwierdzenie", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int rowindex = grdEmployee.CurrentRow.Index;
                DataGridViewRow selectedRow = grdEmployee.Rows[rowindex];
                int delIndex = Convert.ToInt32(selectedRow.Cells["id"].Value);

                using (var context = new Adam_AsprovaEntities1())
                {
                    var pracownik = context.plum_pracownicy.First(k => k.id == delIndex);
                    context.plum_pracownicy.Remove(pracownik);
                    context.SaveChanges();


                }

            }
            updateGridCaption();
           
        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
