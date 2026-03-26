using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using SiManEm.Datos;
using SiManEm.Modelos;

namespace SiManEm.Formularios
{
    public partial class CargoForm : Form
    {
        private int _departamentoIdSeleccionado;
        public Cargo DatosCargo { get; private set; }

        public CargoForm(string titulo, Cargo cargo)
        {
            InitializeComponent();
            Text = titulo;

            var baseCargo = cargo ?? new Cargo();
            DatosCargo = baseCargo;
            _departamentoIdSeleccionado = baseCargo.DepartamentoID;

            txtNombre.Text = baseCargo.Nombre ?? string.Empty;
            txtDescripcion.Text = baseCargo.Descripcion ?? string.Empty;
            txtDepartamento.Text = ObtenerNombreDepartamentoPorId(_departamentoIdSeleccionado);
        }

        private string ObtenerNombreDepartamentoPorId(int id)
        {
            if (id <= 0) return string.Empty;
            using (var db = new SiManEmContexto())
            {
                var entidad = db.Departamentos.AsNoTracking().FirstOrDefault(x => x.DepartamentoID == id);
                return entidad == null ? string.Empty : entidad.Nombre;
            }
        }

        private int? BuscarDepartamento()
        {
            using (var db = new SiManEmContexto())
            {
                var datos = db.Departamentos.AsNoTracking()
                    .Select(x => new { x.DepartamentoID, x.Nombre, x.Descripcion })
                    .ToList();

                using (var busqueda = new BusquedaSeleccionForm("Buscar Departamento", "DepartamentoID", datos))
                {
                    return busqueda.ShowDialog(this) == DialogResult.OK ? busqueda.IdSeleccionado : null;
                }
            }
        }

        private void botonBuscarDepartamento_Click(object sender, EventArgs e)
        {
            var id = BuscarDepartamento();
            if (id == null) return;

            _departamentoIdSeleccionado = id.Value;
            txtDepartamento.Text = ObtenerNombreDepartamentoPorId(id.Value);
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            if (_departamentoIdSeleccionado <= 0)
            {
                MessageBox.Show("Debe seleccionar un Departamento.");
                return;
            }

            DatosCargo.Nombre = txtNombre.Text.Trim();
            DatosCargo.DepartamentoID = _departamentoIdSeleccionado;
            DatosCargo.Descripcion = txtDescripcion.Text.Trim();

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
