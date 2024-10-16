namespace BibliotecaApp2
{
    partial class Form1
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
            this.dataGridViewLibros = new System.Windows.Forms.DataGridView();
            this.btnCargarLibros = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLibros
            // 
            this.dataGridViewLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLibros.Location = new System.Drawing.Point(117, 43);
            this.dataGridViewLibros.Name = "dataGridViewLibros";
            this.dataGridViewLibros.Size = new System.Drawing.Size(382, 246);
            this.dataGridViewLibros.TabIndex = 0;
            // 
            // btnCargarLibros
            // 
            this.btnCargarLibros.Location = new System.Drawing.Point(254, 325);
            this.btnCargarLibros.Name = "btnCargarLibros";
            this.btnCargarLibros.Size = new System.Drawing.Size(129, 23);
            this.btnCargarLibros.TabIndex = 1;
            this.btnCargarLibros.Text = "Cargar Libros";
            this.btnCargarLibros.UseVisualStyleBackColor = true;
            this.btnCargarLibros.Click += new System.EventHandler(this.btnCargarLibros_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 386);
            this.Controls.Add(this.btnCargarLibros);
            this.Controls.Add(this.dataGridViewLibros);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLibros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLibros;
        private System.Windows.Forms.Button btnCargarLibros;
    }
}

