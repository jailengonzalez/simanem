using System;
using System.Windows.Forms;
using SiManEm.Modelos;

namespace SiManEm.Formularios
{
    public partial class DepartamentoForm : Form
    {
        public Departamento DatosDepartamento { get; private set; }

        public DepartamentoForm(string titulo, Departamento departamento)
        {
            InitializeComponent();
            Text = titulo;

            var baseDepartamento = departamento ?? new Departamento();
            DatosDepartamento = baseDepartamento;

            txtNombre.Text = baseDepartamento.Nombre ?? string.Empty;
            txtDescripcion.Text = baseDepartamento.Descripcion ?? string.Empty;
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            DatosDepartamento.Nombre = txtNombre.Text.Trim();
            DatosDepartamento.Descripcion = txtDescripcion.Text.Trim();

            DialogResult = DialogResult.OK;
            Close();
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
