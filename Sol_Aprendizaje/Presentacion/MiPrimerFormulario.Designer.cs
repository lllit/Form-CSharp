namespace Presentacion
{
    partial class MiPrimerFormulario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MiPrimerFormulario));
            this.grb_mantenimiento = new System.Windows.Forms.GroupBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grb_funciones = new System.Windows.Forms.GroupBox();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_reporte = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.lst_mantenimiento = new System.Windows.Forms.ListBox();
            this.grb_mantenimiento.SuspendLayout();
            this.grb_funciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_mantenimiento
            // 
            this.grb_mantenimiento.BackColor = System.Drawing.Color.Silver;
            this.grb_mantenimiento.Controls.Add(this.btn_guardar);
            this.grb_mantenimiento.Controls.Add(this.btn_cancelar);
            this.grb_mantenimiento.Controls.Add(this.txt_descripcion);
            this.grb_mantenimiento.Controls.Add(this.label2);
            this.grb_mantenimiento.Controls.Add(this.txt_codigo);
            this.grb_mantenimiento.Controls.Add(this.label1);
            this.grb_mantenimiento.Enabled = false;
            this.grb_mantenimiento.Location = new System.Drawing.Point(37, 34);
            this.grb_mantenimiento.Name = "grb_mantenimiento";
            this.grb_mantenimiento.Size = new System.Drawing.Size(469, 179);
            this.grb_mantenimiento.TabIndex = 10;
            this.grb_mantenimiento.TabStop = false;
            this.grb_mantenimiento.Text = "Mantenimiento";
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_guardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_guardar.Location = new System.Drawing.Point(180, 116);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(88, 33);
            this.btn_guardar.TabIndex = 15;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_cancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_cancelar.Location = new System.Drawing.Point(86, 116);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(88, 33);
            this.btn_cancelar.TabIndex = 14;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(86, 66);
            this.txt_descripcion.MaxLength = 30;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(210, 20);
            this.txt_descripcion.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Descripción:";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(86, 30);
            this.txt_codigo.MaxLength = 3;
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(100, 20);
            this.txt_codigo.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Codigo:";
            // 
            // grb_funciones
            // 
            this.grb_funciones.Controls.Add(this.btn_salir);
            this.grb_funciones.Controls.Add(this.btn_reporte);
            this.grb_funciones.Controls.Add(this.btn_eliminar);
            this.grb_funciones.Controls.Add(this.btn_actualizar);
            this.grb_funciones.Controls.Add(this.btn_nuevo);
            this.grb_funciones.Location = new System.Drawing.Point(37, 219);
            this.grb_funciones.Name = "grb_funciones";
            this.grb_funciones.Size = new System.Drawing.Size(469, 100);
            this.grb_funciones.TabIndex = 11;
            this.grb_funciones.TabStop = false;
            this.grb_funciones.Text = "Funciones";
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_salir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_salir.Image")));
            this.btn_salir.Location = new System.Drawing.Point(371, 30);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(83, 55);
            this.btn_salir.TabIndex = 12;
            this.btn_salir.Text = "Salir";
            this.btn_salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_reporte
            // 
            this.btn_reporte.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_reporte.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_reporte.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_reporte.Image = ((System.Drawing.Image)(resources.GetObject("btn_reporte.Image")));
            this.btn_reporte.Location = new System.Drawing.Point(282, 30);
            this.btn_reporte.Name = "btn_reporte";
            this.btn_reporte.Size = new System.Drawing.Size(83, 55);
            this.btn_reporte.TabIndex = 11;
            this.btn_reporte.Text = "Reporte";
            this.btn_reporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_reporte.UseVisualStyleBackColor = false;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_eliminar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("btn_eliminar.Image")));
            this.btn_eliminar.Location = new System.Drawing.Point(193, 30);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(83, 55);
            this.btn_eliminar.TabIndex = 10;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_actualizar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_actualizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_actualizar.Image")));
            this.btn_actualizar.Location = new System.Drawing.Point(101, 30);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(83, 55);
            this.btn_actualizar.TabIndex = 9;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_actualizar.UseVisualStyleBackColor = false;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_nuevo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_nuevo.Image = ((System.Drawing.Image)(resources.GetObject("btn_nuevo.Image")));
            this.btn_nuevo.Location = new System.Drawing.Point(12, 30);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(83, 55);
            this.btn_nuevo.TabIndex = 8;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_nuevo.UseVisualStyleBackColor = false;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // lst_mantenimiento
            // 
            this.lst_mantenimiento.FormattingEnabled = true;
            this.lst_mantenimiento.Location = new System.Drawing.Point(557, 40);
            this.lst_mantenimiento.Name = "lst_mantenimiento";
            this.lst_mantenimiento.Size = new System.Drawing.Size(371, 173);
            this.lst_mantenimiento.TabIndex = 12;
            this.lst_mantenimiento.Click += new System.EventHandler(this.lst_mantenimiento_Click);
            this.lst_mantenimiento.SelectedIndexChanged += new System.EventHandler(this.lst_mantenimiento_SelectedIndexChanged);
            // 
            // MiPrimerFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(961, 327);
            this.Controls.Add(this.lst_mantenimiento);
            this.Controls.Add(this.grb_funciones);
            this.Controls.Add(this.grb_mantenimiento);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "MiPrimerFormulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Mantenimiento";
            this.Load += new System.EventHandler(this.MiPrimerFormulario_Load);
            this.grb_mantenimiento.ResumeLayout(false);
            this.grb_mantenimiento.PerformLayout();
            this.grb_funciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_mantenimiento;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grb_funciones;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_reporte;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.ListBox lst_mantenimiento;
    }
}