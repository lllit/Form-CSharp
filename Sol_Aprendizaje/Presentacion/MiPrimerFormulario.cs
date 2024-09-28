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
    public partial class MiPrimerFormulario : Form
    {
        
        public MiPrimerFormulario()
        {
            InitializeComponent();
        }


        // INICIO DE VARIABLES
        int NestadoGuarda = 0;


        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            NestadoGuarda = 1; //Nuevo registro


            lst_mantenimiento.Enabled = false;

            txt_codigo.Text = "";
            txt_descripcion.Text = "";
            
            grb_mantenimiento.Enabled = true;

            txt_codigo.Enabled = true;
            grb_funciones.Enabled = false;



            txt_codigo.Focus();

            
        }

        private void MiPrimerFormulario_Load(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            txt_codigo.Text = "";
            txt_descripcion.Text = "";

            grb_mantenimiento.Enabled = false;

            grb_funciones.Enabled = true;

            lst_mantenimiento.Enabled = true;

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lst_mantenimiento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            //Enviar registro al checkbox
            string Registro;
            Registro = ($"{txt_codigo.Text.Trim()} | {txt_descripcion.Text.Trim()}");

            if (NestadoGuarda == 1) // Nuevo registro
            {

                lst_mantenimiento.Items.Add(Registro);
                MessageBox.Show("Datos guardados correctamente");

            } else // Actualizar registro
            {
                int ElementoSeleccionado = lst_mantenimiento.SelectedIndex;
                lst_mantenimiento.Items.Remove(lst_mantenimiento.SelectedItem);
                lst_mantenimiento.Items.Insert(ElementoSeleccionado,Registro);
                MessageBox.Show("Datos actualizados correctamente");
            }

            


            
            

            //Limpiar y bloquear botones
            txt_codigo.Text = "";
            txt_descripcion.Text = "";
            grb_mantenimiento.Enabled = false;
            grb_funciones.Enabled = true;

            lst_mantenimiento.Enabled = true;

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            lst_mantenimiento.Items.Remove(lst_mantenimiento.SelectedItem);
            txt_codigo.Text = "";
            txt_descripcion.Text = "";
            MessageBox.Show("Elemento Eliminado");
        }

        private void lst_mantenimiento_Click(object sender, EventArgs e)
        {
            //Selecionando un elemento de la listBox
            string TextoSeleccionado;
            int LongitudText;
            try
            {
                TextoSeleccionado = lst_mantenimiento.SelectedItem.ToString().Trim();
                LongitudText = TextoSeleccionado.Length;

                txt_codigo.Text = TextoSeleccionado.Substring(0, 3);
                txt_descripcion.Text = TextoSeleccionado.Substring(6, LongitudText - 6);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            

        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            NestadoGuarda = 2; //Actualizar registro

            lst_mantenimiento.Enabled = false;

            grb_mantenimiento.Enabled = true;
            txt_codigo.Enabled = false;
            grb_funciones.Enabled = false;
            txt_descripcion.Focus();
        }
    }
}           
