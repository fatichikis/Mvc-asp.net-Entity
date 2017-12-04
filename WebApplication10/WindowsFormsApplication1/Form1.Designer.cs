namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtnombrelugar = new System.Windows.Forms.TextBox();
            this.txtdescripcionlugar = new System.Windows.Forms.TextBox();
            this.lugaresDataSet = new WindowsFormsApplication1.lugaresDataSet();
            this.lugaresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lugaresTableAdapter = new WindowsFormsApplication1.lugaresDataSetTableAdapters.lugaresTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lugaresDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lugaresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(436, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(138, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(249, 23);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // txtnombrelugar
            // 
            this.txtnombrelugar.Location = new System.Drawing.Point(46, 73);
            this.txtnombrelugar.Name = "txtnombrelugar";
            this.txtnombrelugar.Size = new System.Drawing.Size(100, 20);
            this.txtnombrelugar.TabIndex = 4;
            // 
            // txtdescripcionlugar
            // 
            this.txtdescripcionlugar.Location = new System.Drawing.Point(175, 73);
            this.txtdescripcionlugar.Name = "txtdescripcionlugar";
            this.txtdescripcionlugar.Size = new System.Drawing.Size(100, 20);
            this.txtdescripcionlugar.TabIndex = 5;
            // 
            // lugaresDataSet
            // 
            this.lugaresDataSet.DataSetName = "lugaresDataSet";
            this.lugaresDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lugaresBindingSource
            // 
            this.lugaresBindingSource.DataMember = "lugares";
            this.lugaresBindingSource.DataSource = this.lugaresDataSet;
            // 
            // lugaresTableAdapter
            // 
            this.lugaresTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 261);
            this.Controls.Add(this.txtdescripcionlugar);
            this.Controls.Add(this.txtnombrelugar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lugaresDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lugaresBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtnombrelugar;
        private System.Windows.Forms.TextBox txtdescripcionlugar;
        private lugaresDataSet lugaresDataSet;
        private System.Windows.Forms.BindingSource lugaresBindingSource;
        private lugaresDataSetTableAdapters.lugaresTableAdapter lugaresTableAdapter;
    }
}

