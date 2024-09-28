using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frm_trabajandoComboBox : Form
    {
        public frm_trabajandoComboBox()
        {
            InitializeComponent();
        }


        private void cmb_curos_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_resultado.Text = $"Cursos selecionado: {cmb_curos.SelectedItem} y se encuentra en la posición: {cmb_curos.SelectedIndex + 1}";
        }

        private void btn_registraR_Click(object sender, EventArgs e)
        {
            cmb_curos.Items.Add(txt_nuevo.Text);
            MessageBox.Show("Curso registrado");


            txt_nuevo.Text = string.Empty;

            
        }
    }
}
