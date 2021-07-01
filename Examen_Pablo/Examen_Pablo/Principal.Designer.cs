
namespace Examen_Pablo
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.txtPlazo = new System.Windows.Forms.TextBox();
            this.txtTasa = new System.Windows.Forms.TextBox();
            this.cmbPeriodo = new System.Windows.Forms.ComboBox();
            this.btnCalc = new MaterialSkin.Controls.MaterialFlatButton();
            this.dgvPrestamo = new System.Windows.Forms.DataGridView();
            this.btnAceptar = new MaterialSkin.Controls.MaterialFlatButton();
            this.isOk = new System.Windows.Forms.PictureBox();
            this.isOknt = new System.Windows.Forms.PictureBox();
            this.isOknt2 = new System.Windows.Forms.PictureBox();
            this.isOk2 = new System.Windows.Forms.PictureBox();
            this.isOknt1 = new System.Windows.Forms.PictureBox();
            this.isOk1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isOk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isOknt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isOknt2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isOk2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isOknt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isOk1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(169)))), ((int)(((byte)(124)))));
            this.panel1.Controls.Add(this.isOknt1);
            this.panel1.Controls.Add(this.isOk1);
            this.panel1.Controls.Add(this.isOknt2);
            this.panel1.Controls.Add(this.isOk2);
            this.panel1.Controls.Add(this.isOknt);
            this.panel1.Controls.Add(this.isOk);
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Controls.Add(this.dgvPrestamo);
            this.panel1.Controls.Add(this.btnCalc);
            this.panel1.Controls.Add(this.cmbPeriodo);
            this.panel1.Controls.Add(this.txtTasa);
            this.panel1.Controls.Add(this.txtPlazo);
            this.panel1.Controls.Add(this.txtMonto);
            this.panel1.Controls.Add(this.materialLabel4);
            this.panel1.Controls.Add(this.materialLabel3);
            this.panel1.Controls.Add(this.materialLabel2);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 538);
            this.panel1.TabIndex = 0;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(27, 54);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(53, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Monto";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(27, 129);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(46, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Plazo";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(305, 54);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(61, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Periodo";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(305, 129);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(42, 19);
            this.materialLabel4.TabIndex = 3;
            this.materialLabel4.Text = "Tasa";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(103, 55);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(138, 20);
            this.txtMonto.TabIndex = 4;
            this.txtMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonto_KeyPress);
            // 
            // txtPlazo
            // 
            this.txtPlazo.Location = new System.Drawing.Point(103, 130);
            this.txtPlazo.Name = "txtPlazo";
            this.txtPlazo.Size = new System.Drawing.Size(138, 20);
            this.txtPlazo.TabIndex = 5;
            this.txtPlazo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonto_KeyPress);
            // 
            // txtTasa
            // 
            this.txtTasa.Location = new System.Drawing.Point(382, 130);
            this.txtTasa.Name = "txtTasa";
            this.txtTasa.Size = new System.Drawing.Size(138, 20);
            this.txtTasa.TabIndex = 6;
            this.txtTasa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonto_KeyPress);
            // 
            // cmbPeriodo
            // 
            this.cmbPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPeriodo.FormattingEnabled = true;
            this.cmbPeriodo.Items.AddRange(new object[] {
            "Anual",
            "Mensual"});
            this.cmbPeriodo.Location = new System.Drawing.Point(382, 53);
            this.cmbPeriodo.Name = "cmbPeriodo";
            this.cmbPeriodo.Size = new System.Drawing.Size(138, 21);
            this.cmbPeriodo.TabIndex = 7;
            // 
            // btnCalc
            // 
            this.btnCalc.AutoSize = true;
            this.btnCalc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCalc.Depth = 0;
            this.btnCalc.Location = new System.Drawing.Point(31, 185);
            this.btnCalc.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCalc.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Primary = false;
            this.btnCalc.Size = new System.Drawing.Size(81, 36);
            this.btnCalc.TabIndex = 8;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // dgvPrestamo
            // 
            this.dgvPrestamo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamo.Location = new System.Drawing.Point(12, 251);
            this.dgvPrestamo.Name = "dgvPrestamo";
            this.dgvPrestamo.Size = new System.Drawing.Size(564, 196);
            this.dgvPrestamo.TabIndex = 9;
            // 
            // btnAceptar
            // 
            this.btnAceptar.AutoSize = true;
            this.btnAceptar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAceptar.Depth = 0;
            this.btnAceptar.Location = new System.Drawing.Point(212, 487);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAceptar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Primary = false;
            this.btnAceptar.Size = new System.Drawing.Size(73, 36);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // isOk
            // 
            this.isOk.Image = global::Examen_Pablo.Properties.Resources.comprobado;
            this.isOk.Location = new System.Drawing.Point(247, 55);
            this.isOk.Name = "isOk";
            this.isOk.Size = new System.Drawing.Size(37, 30);
            this.isOk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.isOk.TabIndex = 11;
            this.isOk.TabStop = false;
            // 
            // isOknt
            // 
            this.isOknt.Image = global::Examen_Pablo.Properties.Resources.cancelar;
            this.isOknt.Location = new System.Drawing.Point(247, 56);
            this.isOknt.Name = "isOknt";
            this.isOknt.Size = new System.Drawing.Size(37, 29);
            this.isOknt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.isOknt.TabIndex = 12;
            this.isOknt.TabStop = false;
            // 
            // isOknt2
            // 
            this.isOknt2.Image = global::Examen_Pablo.Properties.Resources.cancelar;
            this.isOknt2.Location = new System.Drawing.Point(526, 130);
            this.isOknt2.Name = "isOknt2";
            this.isOknt2.Size = new System.Drawing.Size(37, 29);
            this.isOknt2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.isOknt2.TabIndex = 16;
            this.isOknt2.TabStop = false;
            // 
            // isOk2
            // 
            this.isOk2.Image = global::Examen_Pablo.Properties.Resources.comprobado;
            this.isOk2.Location = new System.Drawing.Point(526, 129);
            this.isOk2.Name = "isOk2";
            this.isOk2.Size = new System.Drawing.Size(37, 30);
            this.isOk2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.isOk2.TabIndex = 15;
            this.isOk2.TabStop = false;
            // 
            // isOknt1
            // 
            this.isOknt1.Image = global::Examen_Pablo.Properties.Resources.cancelar;
            this.isOknt1.Location = new System.Drawing.Point(247, 130);
            this.isOknt1.Name = "isOknt1";
            this.isOknt1.Size = new System.Drawing.Size(37, 29);
            this.isOknt1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.isOknt1.TabIndex = 18;
            this.isOknt1.TabStop = false;
            // 
            // isOk1
            // 
            this.isOk1.Image = global::Examen_Pablo.Properties.Resources.comprobado;
            this.isOk1.Location = new System.Drawing.Point(247, 129);
            this.isOk1.Name = "isOk1";
            this.isOk1.Size = new System.Drawing.Size(37, 30);
            this.isOk1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.isOk1.TabIndex = 17;
            this.isOk1.TabStop = false;
            this.isOk1.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 538);
            this.Controls.Add(this.panel1);
            this.Name = "Principal";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isOk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isOknt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isOknt2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isOk2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isOknt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isOk1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialFlatButton btnAceptar;
        private System.Windows.Forms.DataGridView dgvPrestamo;
        private MaterialSkin.Controls.MaterialFlatButton btnCalc;
        private System.Windows.Forms.ComboBox cmbPeriodo;
        private System.Windows.Forms.TextBox txtTasa;
        private System.Windows.Forms.TextBox txtPlazo;
        private System.Windows.Forms.TextBox txtMonto;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.PictureBox isOknt;
        private System.Windows.Forms.PictureBox isOk;
        private System.Windows.Forms.PictureBox isOknt2;
        private System.Windows.Forms.PictureBox isOk2;
        private System.Windows.Forms.PictureBox isOknt1;
        private System.Windows.Forms.PictureBox isOk1;
    }
}

