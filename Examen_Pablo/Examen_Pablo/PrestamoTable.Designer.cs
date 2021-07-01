
namespace Examen_Pablo
{
    partial class PrestamoTable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.btnAdd = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnVisual = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(169)))), ((int)(((byte)(124)))));
            this.panel1.Controls.Add(this.btnVisual);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.dgvTable);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(339, 24);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(82, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Prestamos";
            // 
            // dgvTable
            // 
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Location = new System.Drawing.Point(12, 74);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.Size = new System.Drawing.Size(776, 297);
            this.dgvTable.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.Depth = 0;
            this.btnAdd.Location = new System.Drawing.Point(186, 399);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Primary = false;
            this.btnAdd.Size = new System.Drawing.Size(57, 36);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Nuevo";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnVisual
            // 
            this.btnVisual.AutoSize = true;
            this.btnVisual.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVisual.Depth = 0;
            this.btnVisual.Location = new System.Drawing.Point(481, 399);
            this.btnVisual.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVisual.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVisual.Name = "btnVisual";
            this.btnVisual.Primary = false;
            this.btnVisual.Size = new System.Drawing.Size(88, 36);
            this.btnVisual.TabIndex = 3;
            this.btnVisual.Text = "Visualizar";
            this.btnVisual.UseVisualStyleBackColor = true;
            this.btnVisual.Click += new System.EventHandler(this.btnVisual_Click);
            // 
            // PrestamoTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "PrestamoTable";
            this.Text = "PrestamoTable";
            this.Load += new System.EventHandler(this.PrestamoTable_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialFlatButton btnVisual;
        private MaterialSkin.Controls.MaterialFlatButton btnAdd;
        private System.Windows.Forms.DataGridView dgvTable;
    }
}