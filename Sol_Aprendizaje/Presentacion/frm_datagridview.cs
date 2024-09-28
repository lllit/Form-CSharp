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
    public partial class frm_datagridview : Form
    {
        //static int seleccionFila;

        public frm_datagridview()
        {
            
            InitializeComponent();
            
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            
            //Valido si los cambos nombres y email estan vacios
            if (txt_nombres.Text != "" && txt_email.Text != "" && txt_apellidos.Text != "" && txt_id.Text != "")
            {

                dtv_datos.Rows.Add(txt_id.Text,txt_nombres.Text,txt_apellidos.Text,txt_email.Text);
                txt_id.Text = "";
                txt_nombres.Text = "";
                txt_apellidos.Text = "";
                txt_email.Text = "";
                MessageBox.Show("Datos guardados");
            }
        }

        

        private void dtv_datos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dtv_datos.SelectedRows.Count > 0 )
            {
                foreach (DataGridViewRow Rw in dtv_datos.SelectedRows)
                {
                    dtv_datos.Rows.Remove(Rw);
                }
            }
        }
    }
}
