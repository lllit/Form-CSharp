namespace Presentacion
{
    partial class frm_numericupdown
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
            this.num_nroDia = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_mostrar = new System.Windows.Forms.Button();
            this.txt_resultado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.num_nroDia)).BeginInit();
            this.SuspendLayout();
            // 
            // num_nroDia
            // 
            this.num_nroDia.Location = new System.Drawing.Point(45, 69);
            this.num_nroDia.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.num_nroDia.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_nroDia.Name = "num_nroDia";
            this.num_nroDia.ReadOnly = true;
            this.num_nroDia.Size = new System.Drawing.Size(110, 20);
            this.num_nroDia.TabIndex = 0;
            this.num_nroDia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_nroDia.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero de la semana:";
            // 
            // btn_mostrar
            // 
            this.btn_mostrar.Location = new System.Drawing.Point(45, 109);
            this.btn_mostrar.Name = "btn_mostrar";
            this.btn_mostrar.Size = new System.Drawing.Size(110, 23);
            this.btn_mostrar.TabIndex = 2;
            this.btn_mostrar.Text = "Mostrar Dia";
            this.btn_mostrar.UseVisualStyleBackColor = true;
            this.btn_mostrar.Click += new System.EventHandler(this.btn_mostrar_Click);
            // 
            // txt_resultado
            // 
            this.txt_resultado.Location = new System.Drawing.Point(216, 69);
            this.txt_resultado.Name = "txt_resultado";
            this.txt_resultado.ReadOnly = true;
            this.txt_resultado.Size = new System.Drawing.Size(217, 20);
            this.txt_resultado.TabIndex = 3;
            // 
            // frm_numericupdown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 291);
            this.Controls.Add(this.txt_resultado);
            this.Controls.Add(this.btn_mostrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.num_nroDia);
            this.Name = "frm_numericupdown";
            this.Text = "frm_numericupdown";
            ((System.ComponentModel.ISupportInitialize)(this.num_nroDia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown num_nroDia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_mostrar;
        private System.Windows.Forms.TextBox txt_resultado;
    }
}