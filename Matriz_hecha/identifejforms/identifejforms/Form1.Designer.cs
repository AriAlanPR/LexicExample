namespace identifejforms
{
    partial class identif
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btncapturar = new System.Windows.Forms.Button();
            this.txtcadena = new System.Windows.Forms.TextBox();
            this.dgvmatrizt = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Letra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Digito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Guion_bajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FDC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmatrizt)).BeginInit();
            this.SuspendLayout();
            // 
            // btncapturar
            // 
            this.btncapturar.Location = new System.Drawing.Point(165, 25);
            this.btncapturar.Name = "btncapturar";
            this.btncapturar.Size = new System.Drawing.Size(75, 23);
            this.btncapturar.TabIndex = 0;
            this.btncapturar.Text = "&Capturar";
            this.btncapturar.UseVisualStyleBackColor = true;
            this.btncapturar.Click += new System.EventHandler(this.btncapturar_Click);
            // 
            // txtcadena
            // 
            this.txtcadena.Location = new System.Drawing.Point(30, 28);
            this.txtcadena.Name = "txtcadena";
            this.txtcadena.Size = new System.Drawing.Size(129, 20);
            this.txtcadena.TabIndex = 1;
            // 
            // dgvmatrizt
            // 
            this.dgvmatrizt.AllowUserToAddRows = false;
            this.dgvmatrizt.AllowUserToDeleteRows = false;
            this.dgvmatrizt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvmatrizt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmatrizt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Estado,
            this.Letra,
            this.Digito,
            this.Guion_bajo,
            this.FDC,
            this.CAT});
            this.dgvmatrizt.Location = new System.Drawing.Point(12, 86);
            this.dgvmatrizt.Name = "dgvmatrizt";
            this.dgvmatrizt.ReadOnly = true;
            this.dgvmatrizt.Size = new System.Drawing.Size(535, 146);
            this.dgvmatrizt.TabIndex = 2;
            this.dgvmatrizt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(472, 279);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "&Finalizar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // Letra
            // 
            this.Letra.HeaderText = "Letra";
            this.Letra.Name = "Letra";
            this.Letra.ReadOnly = true;
            // 
            // Digito
            // 
            this.Digito.HeaderText = "Digito";
            this.Digito.Name = "Digito";
            this.Digito.ReadOnly = true;
            // 
            // Guion_bajo
            // 
            this.Guion_bajo.HeaderText = "_";
            this.Guion_bajo.Name = "Guion_bajo";
            this.Guion_bajo.ReadOnly = true;
            // 
            // FDC
            // 
            this.FDC.HeaderText = "FDC";
            this.FDC.Name = "FDC";
            this.FDC.ReadOnly = true;
            // 
            // CAT
            // 
            this.CAT.HeaderText = "CAT";
            this.CAT.Name = "CAT";
            this.CAT.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(317, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // identif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 322);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvmatrizt);
            this.Controls.Add(this.txtcadena);
            this.Controls.Add(this.btncapturar);
            this.Name = "identif";
            this.Text = "Verificador identificador";
            this.Load += new System.EventHandler(this.identif_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvmatrizt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncapturar;
        private System.Windows.Forms.TextBox txtcadena;
        private System.Windows.Forms.DataGridView dgvmatrizt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Letra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Digito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Guion_bajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FDC;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAT;
        private System.Windows.Forms.Button button1;
    }
}

