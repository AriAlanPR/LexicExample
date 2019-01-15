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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(identif));
            this.btncapturar = new System.Windows.Forms.Button();
            this.txtcadena = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvmatrizt = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnconectar = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmatrizt)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btncapturar
            // 
            this.btncapturar.Location = new System.Drawing.Point(165, 36);
            this.btncapturar.Name = "btncapturar";
            this.btncapturar.Size = new System.Drawing.Size(75, 23);
            this.btncapturar.TabIndex = 0;
            this.btncapturar.Text = "&Capturar";
            this.btncapturar.UseVisualStyleBackColor = true;
            this.btncapturar.Click += new System.EventHandler(this.btncapturar_Click);
            // 
            // txtcadena
            // 
            this.txtcadena.Location = new System.Drawing.Point(30, 39);
            this.txtcadena.Name = "txtcadena";
            this.txtcadena.Size = new System.Drawing.Size(129, 20);
            this.txtcadena.TabIndex = 1;
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
            // dgvmatrizt
            // 
            this.dgvmatrizt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvmatrizt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmatrizt.Location = new System.Drawing.Point(30, 81);
            this.dgvmatrizt.Name = "dgvmatrizt";
            this.dgvmatrizt.Size = new System.Drawing.Size(517, 150);
            this.dgvmatrizt.TabIndex = 5;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnconectar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(568, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnconectar
            // 
            this.tsbtnconectar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnconectar.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnconectar.Image")));
            this.tsbtnconectar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnconectar.Name = "tsbtnconectar";
            this.tsbtnconectar.Size = new System.Drawing.Size(59, 22);
            this.tsbtnconectar.Text = "Conectar";
            this.tsbtnconectar.Click += new System.EventHandler(this.tsbtnconectar_Click);
            // 
            // identif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 322);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvmatrizt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtcadena);
            this.Controls.Add(this.btncapturar);
            this.Name = "identif";
            this.Text = "Verificador identificador";
            this.Load += new System.EventHandler(this.identif_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvmatrizt)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncapturar;
        private System.Windows.Forms.TextBox txtcadena;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvmatrizt;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnconectar;
    }
}

