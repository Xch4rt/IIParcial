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
    public partial class Principal : Form
    {
        DataTable tab = new DataTable();
        public Principal()
        {
            InitializeComponent();
            string[] header = new string[] { "No.", "Cuota", "Abono", "Interes", "Saldo" };
            foreach (string s in header)
            {
                tab.Columns.Add(s);
            }
            dgvPrestamo.DataSource = tab;
            isOk.Visible = false;
            isOknt.Visible = false;
            isOk1.Visible = false;
            isOknt1.Visible = false;
            isOk2.Visible = false;
            isOknt2.Visible = false;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double monto = isO(Convert.ToDouble(txtMonto.Text))? Convert.ToDouble(txtMonto.Text):0;
            double tasa = isO(Convert.ToDouble(txtTasa.Text))? Convert.ToDouble(txtTasa.Text): 0;
            string periodo = "Anual";//cmbPeriodo.SelectedValue.ToString();
            int plazo = isO(Convert.ToInt32(txtPlazo.Text))? Convert.ToInt32(txtPlazo.Text): 0 ;

            if (monto == 0)
                isOknt.Visible = true;
            else if (tasa == 0)
                isOknt1.Visible = true;
            else if (plazo == 0)
                isOknt2.Visible = true;
            else
                isOk.Visible = true; isOk1.Visible = true; isOk2.Visible = true;

            Prestamo pr = new Prestamo()
            {
                Monto = monto,
                Plazo = plazo,
                Periodo = periodo,
                Tasa = tasa
            };

            addToTable(pr);
        }


        public void addToTable(Prestamo pr)
        {
            tab.Rows.Clear();
            tab.Rows.Add();

            double abono = pr.Monto / pr.Plazo; 
            double saldo = pr.Monto; 
            double tasa = pr.Tasa / 100; 
            double cuota, intereses = 0;

            //para el anio 0
            object[] f0 = new object[] { 0, "", "", "", saldo };// fila 0
            tab.Rows.Add(f0);

            for (int i = 1; i <= pr.Plazo; i++)
            {
                intereses = saldo * tasa;
                cuota = abono + intereses;
                saldo -= abono;
                object[] Fila = new object[] { i, cuota, abono, intereses, saldo };
                tab.Rows.Add(Fila);
            }

            dgvPrestamo.DataSource = tab;

        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;// solo acepta las teclas numericas
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true; //solo acepta un punto
            }
        }
        private Boolean isO(Object a)
        {
            if (a.Equals(null))
            {
                return false;
            }
            return true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
