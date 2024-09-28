namespace Presentacion
{
    partial class frm_trabajandoComboBox
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
            this.cmb_curos = new System.Windows.Forms.ComboBox();
            this.cmb_cursos = new System.Windows.Forms.Label();
            this.txt_resultado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nuevo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_registraR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmb_curos
            // 
            this.cmb_curos.FormattingEnabled = true;
            this.cmb_curos.Items.AddRange(new object[] {
            "Visual FoxPro",
            "C Sharp",
            "VB.NET"});
            this.cmb_curos.Location = new System.Drawing.Point(563, 23);
            this.cmb_curos.Name = "cmb_curos";
            this.cmb_curos.Size = new System.Drawing.Size(215, 21);
            this.cmb_curos.TabIndex = 0;
            this.cmb_curos.Text = "Seleccione un curso";
            this.cmb_curos.SelectedIndexChanged += new System.EventHandler(this.cmb_curos_SelectedIndexChanged);
            // 
            // cmb_cursos
            // 
            this.cmb_cursos.AutoSize = true;
            this.cmb_cursos.Location = new System.Drawing.Point(460, 26);
            this.cmb_cursos.Name = "cmb_cursos";
            this.cmb_cursos.Size = new System.Drawing.Size(97, 13);
            this.cmb_cursos.TabIndex = 1;
            this.cmb_cursos.Text = "Cursos disponibles:";
            // 
            // txt_resultado
            // 
            this.txt_resultado.Location = new System.Drawing.Point(463, 92);
            this.txt_resultado.Multiline = true;
            this.txt_resultado.Name = "txt_resultado";
            this.txt_resultado.ReadOnly = true;
            this.txt_resultado.Size = new System.Drawing.Size(315, 105);
            this.txt_resultado.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(460, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Curso selecionado:";
            // 
            // txt_nuevo
            // 
            this.txt_nuevo.Location = new System.Drawing.Point(119, 27);
            this.txt_nuevo.Name = "txt_nuevo";
            this.txt_nuevo.Size = new System.Drawing.Size(193, 20);
            this.txt_nuevo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Curso nuevo:";
            // 
            // btn_registraR
            // 
            this.btn_registraR.Location = new System.Drawing.Point(119, 53);
            this.btn_registraR.Name = "btn_registraR";
            this.btn_registraR.Size = new System.Drawing.Size(193, 39);
            this.btn_registraR.TabIndex = 6;
            this.btn_registraR.Text = "Registrar";
            this.btn_registraR.UseVisualStyleBackColor = true;
            this.btn_registraR.Click += new System.EventHandler(this.btn_registraR_Click);
            // 
            // frm_trabajandoComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 249);
            this.Controls.Add(this.btn_registraR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nuevo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_resultado);
            this.Controls.Add(this.cmb_cursos);
            this.Controls.Add(this.cmb_curos);
            this.Name = "frm_trabajandoComboBox";
            this.Text = "frm_trabajandoComboBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_curos;
        private System.Windows.Forms.Label cmb_cursos;
        private System.Windows.Forms.TextBox txt_resultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nuevo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_registraR;
    }
}