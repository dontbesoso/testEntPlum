using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testEntPlum
{
    public partial class mainList : Form
    {
        private static int loggedInUser = -1;
        public mainList(int user)
        {
            loggedInUser = user;
            InitializeComponent();
            cmbGniazdo.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string wybraneGniazdo = cmbGniazdo.SelectedItem.ToString();
            string wybranaData = cldDataLogowania.SelectionStart.ToString();


            using (var context = new Adam_AsprovaEntities1())
            {
                DateTime myDate = DateTime.Parse(wybranaData);
                context.it_ZasilPlumDzien(myDate);

                var std = context.itZestawieniaPlums
                        .Where(k => k.machineName.Contains(wybraneGniazdo.Substring(1, 2)))
                        .OrderBy(k => k.timeIn).ToList();
                grdLogowania.DataSource = std;
            }
            
        }

        private void zmieńHasłoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmZmianaHasla oknoHasla = new frmZmianaHasla(loggedInUser);
                oknoHasla.Show();
        }

        private void pracownicyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            employeeList listaPracownikow = new employeeList();
                listaPracownikow.Show();
        }
    }
}
