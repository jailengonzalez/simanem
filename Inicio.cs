using System.Windows.Forms;

namespace SiManEm
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            SeleccionarPestana(0);
        }

        private void SeleccionarPestana(int indice)
        {
            tabControlContenido.SelectedIndex = indice;
            ActualizarBotonesMenu(indice);
        }

        private void ActualizarBotonesMenu(int indiceActivo)
        {
            var colorActivo = System.Drawing.Color.FromArgb(40, 62, 105);
            var colorNormal = System.Drawing.Color.FromArgb(21, 36, 63);

            botonTabInicio.BackColor = colorNormal;
            botonTabEmpleados.BackColor = colorNormal;
            botonTabDepartamentos.BackColor = colorNormal;
            botonTabCargos.BackColor = colorNormal;
            botonTabVacaciones.BackColor = colorNormal;

            if (indiceActivo == 0)
            {
                botonTabInicio.BackColor = colorActivo;
            }
            else if (indiceActivo == 1)
            {
                botonTabEmpleados.BackColor = colorActivo;
            }
            else if (indiceActivo == 2)
            {
                botonTabDepartamentos.BackColor = colorActivo;
            }
            else if (indiceActivo == 3)
            {
                botonTabCargos.BackColor = colorActivo;
            }
            else if (indiceActivo == 4)
            {
                botonTabVacaciones.BackColor = colorActivo;
            }
        }

        private void botonTabInicio_Click(object sender, System.EventArgs e)
        {
            SeleccionarPestana(0);
        }

        private void botonTabEmpleados_Click(object sender, System.EventArgs e)
        {
            SeleccionarPestana(1);
        }

        private void botonTabDepartamentos_Click(object sender, System.EventArgs e)
        {
            SeleccionarPestana(2);
        }

        private void botonTabCargos_Click(object sender, System.EventArgs e)
        {
            SeleccionarPestana(3);
        }

        private void botonTabVacaciones_Click(object sender, System.EventArgs e)
        {
            SeleccionarPestana(4);
        }

        private void botonMinimizar_Click(object sender, System.EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void botonCerrar_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
