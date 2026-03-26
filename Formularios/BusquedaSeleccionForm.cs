using System;
using System.Windows.Forms;

namespace SiManEm.Formularios
{
    public partial class BusquedaSeleccionForm : Form
    {
        private readonly string _columnaId;
        public int? IdSeleccionado { get; private set; }

        public BusquedaSeleccionForm(string titulo, string columnaId, object dataSource)
        {
            InitializeComponent();
            Text = titulo;
            _columnaId = columnaId;
            gridDatos.DataSource = dataSource;
        }

        private void botonSeleccionar_Click(object sender, EventArgs e)
        {
            if (gridDatos.CurrentRow == null || gridDatos.CurrentRow.Cells[_columnaId]?.Value == null)
            {
                MessageBox.Show("Seleccione un registro.");
                return;
            }

            IdSeleccionado = Convert.ToInt32(gridDatos.CurrentRow.Cells[_columnaId].Value);
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
