using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Frm_encuesta : Form
    {
        public Frm_encuesta()
        {
            InitializeComponent();
        }

        private void btn_procesar_Click(object sender, EventArgs e)
        {
            string Resultado;
            Resultado = "";

            if (chk_vfp.Checked == true)
            {
                Resultado += chk_vfp.Text+", "; 
            }
            if (chk_csharp.Checked == true)
            {
                Resultado += chk_csharp.Text + ", ";
            }
            if (chk_vbnet.Checked == true)
            {
                Resultado += chk_vbnet.Text + ", ";
            }
            if (chk_java.Checked == true)
            {
                Resultado += chk_java.Text + ", ";
            }


            // Evaluando proceso de seleccion del radio button

            if (rdb_presencial.Checked)
            {
                Resultado += "------ "+rdb_presencial.Text+" ------ ";
            }
            else if (rdb_online.Checked)
            {
                Resultado += "------ " + rdb_online.Text + " ------ ";
            }

            txtResultado.Text = Resultado;
        }
    }
}
