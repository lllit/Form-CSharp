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
    public partial class frm_trackbar : Form
    {
        public frm_trackbar()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lbl_porcentaje.Text = $"Porcentaje {trackBar1.Value.ToString()}%";

            if (trackBar1.Value > 50 )
            {
                lbl_porcentaje.ForeColor = Color.Red;
            } else
            {
                lbl_porcentaje.ForeColor = Color.Black;
            }
        }
    }
}
