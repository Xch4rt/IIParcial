using Examen_Pablo.Poco;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_Pablo
{
    public partial class PrestamoTable : Form
    {
        List<Prestamo> prestamos = new List<Prestamo>();
        DataTable tab = new DataTable();
        public PrestamoTable()
        {
            InitializeComponent();
        }

        private void PrestamoTable_Load(object sender, EventArgs e)
        {
            string[] headers = new string[] { "Monto", "Plazo", "Perìodo", "Tasa" };
            foreach (string s in headers)
            {
                tab.Columns.Add(s);
            }
            dgvTable.DataSource = tab;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Principal p = new Principal();
            p.Show();
        }

        private void btnVisual_Click(object sender, EventArgs e)
        {
            
        }
    }
}
