using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Presentacion.frm_mdi;

namespace Presentacion
{
    public partial class frm_mdi : Form
    {
        public frm_mdi()
        {
            InitializeComponent();

            this.IsMdiContainer = true;
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frm_mdi_Load(object sender, EventArgs e)
        {
            MenuStrip oMenuStrip = new MenuStrip();


            List<Menu> oListaMenu = new List<Menu>()
            {
                new Menu()
                {
                    nombre = "Formularios",
                    oSubMenu = new List<SubMenu>(){
                        new SubMenu()
                        {
                            nombre = "Primer Formulario"
                        },
                        new SubMenu()
                        {
                            nombre = "TrackBar"
                        },
                        new SubMenu()
                        {
                            nombre = "ComboBox"
                        },
                        new SubMenu()
                        {
                            nombre = "Tiempo"
                        },
                        new SubMenu()
                        {
                            nombre = "Numerico up Down"
                        },
                        new SubMenu()
                        {
                            nombre = "Encuesta"
                        },
                        new SubMenu()
                        {
                            nombre = "DGV"
                        },
                        new SubMenu()
                        {
                            nombre = "Data Grid View"
                        }
                    }
                },
                new Menu()
                {
                    nombre = "Reporte",
                    oSubMenu = new List<SubMenu>(){
                        new SubMenu()
                        {
                            nombre = "Empleados"
                        }
                    }
                },
                new Menu()
                {
                    nombre = "Otros",
                    oSubMenu = new List<SubMenu>(){
                        new SubMenu()
                        {
                            nombre = "Ventas"
                        }
                    }
                },
            };

            // Este foreach itera dentro de oListaMenu para ir pintando en el formulario

            foreach (Menu oMenu in oListaMenu)
            {
                ToolStripMenuItem oMenuItem = new ToolStripMenuItem(oMenu.nombre);

                if (oMenu.oSubMenu != null)
                {
                    //Pintamos los submenus
                    foreach (SubMenu oSubMenu in oMenu.oSubMenu)
                    {
                        ToolStripMenuItem oSubMenuItem = new ToolStripMenuItem(oSubMenu.nombre,null,submenu_selected);
                        oMenuItem.DropDownItems.Add(oSubMenuItem);
                    }
                    
                }

                oMenuStrip.Items.Add(oMenuItem);
            }



            this.MainMenuStrip = oMenuStrip;
            Controls.Add(oMenuStrip);
        }

        //Evento para navegar entre formularios
        private void submenu_selected(object sender, EventArgs e)
        {
            MiPrimerFormulario oPrimerForm = new MiPrimerFormulario();
            frm_trackbar oTrackBar = new frm_trackbar();
            frm_trabajandoComboBox oFrmComboBox = new frm_trabajandoComboBox();
            frm_tiempo oFrmTiempo = new frm_tiempo();
            frm_numericupdown oFrmNumericoUpDown = new frm_numericupdown();
            Frm_encuesta oFrmEncuesta= new Frm_encuesta();
            frm_dgv oFrmDgv = new frm_dgv();
            frm_datagridview oFrmDataGridView = new frm_datagridview();

            switch (sender.ToString())
            {
                case "Primer Formulario":
                    oPrimerForm.MdiParent = this;

                    oPrimerForm.Show();

                    break;

                case "TrackBar":
                    oTrackBar.MdiParent = this;
                    oTrackBar.Show();
                    break;

                case "ComboBox":
                    oFrmComboBox.MdiParent = this;
                    oFrmComboBox.Show();
                    break;
                case "Tiempo":
                    oFrmTiempo.MdiParent = this;
                    oFrmTiempo.Show();
                    break;
                case "Numerico up Down":
                    oFrmNumericoUpDown.MdiParent = this;
                    oFrmNumericoUpDown.Show();
                    break;
                case "Encuesta":
                    oFrmEncuesta.MdiParent = this;
                    oFrmEncuesta.Show();
                    break;
                case "DGV":
                    oFrmDgv.MdiParent = this;
                    oFrmDgv.Show();
                    break;
                case "Data Grid View":
                    oFrmDataGridView.MdiParent = this;
                    oFrmDataGridView.Show();
                    break;
                default:
                    break;
            }

            
            
            //MessageBox.Show($"Click {sender}");

        }

        //---------------------------

        private class Menu
        {
            public string nombre { get; set; }
            public List<SubMenu> oSubMenu { get; set; }
        }

        public class SubMenu
        {
            public string nombre { get; set; }
        }



    }
}
