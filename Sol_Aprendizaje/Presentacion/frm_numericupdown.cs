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
    public partial class frm_numericupdown : Form
    {
        public frm_numericupdown()
        {
            InitializeComponent();
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            //Recibir la informacion del numeric
            decimal Nrodia;
            Nrodia = num_nroDia.Value;

            //Crear variable para almacenar el nombre de la variable
            string diaTexto;

            switch (Nrodia)
            {
                case 1:
                    diaTexto = "Lunes";
                    break;
                case 2:
                    diaTexto = "Martes";
                    break;
                case 3:
                    diaTexto = "Miercoles";
                    break;
                case 4:
                    diaTexto = "Jueves";
                    break;
                case 5:
                    diaTexto = "Viernes";
                    break;
                case 6:
                    diaTexto = "Sabado";
                    break;
                case 7:
                    diaTexto = "Domingo";
                    break;
                
                default:
                    diaTexto = "";
                    break;
            }

            txt_resultado.Text = diaTexto;

        }
    }
}
