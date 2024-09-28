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
    public partial class frm_dgv : Form
    {
        public frm_dgv()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btn_accion_Click(object sender, EventArgs e)
        {
            //Verificar si los textbox estan vacios
            if (txb_nombre.Text != "" && txb_apellido.Text != "")
            {
                dgv_general.Rows.Add(txb_nombre.Text, txb_apellido.Text);
                MessageBox.Show("Datos guardados!");
                txb_nombre.Text = "";
                txb_apellido.Text = "";


            } else
            {
                MessageBox.Show("Ingrese valores validos");
            }
        }

        private void frm_dgv_Load(object sender, EventArgs e)
        {

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_general.CurrentRow != null)
            {
                if (dgv_general.CurrentRow.Index != -1)
                {
                    dgv_general.Rows.RemoveAt(dgv_general.CurrentRow.Index);
                }

            } else
            {
                MessageBox.Show("Seleccione un usuario");
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {

        }


        private void dgv_general_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int n = dgv_general.CurrentRow.Index;

        }
    }
}
