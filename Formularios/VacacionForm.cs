using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using SiManEm.Datos;
using SiManEm.Modelos;

namespace SiManEm.Formularios
{
    public partial class VacacionForm : Form
    {
        private int _empleadoIdSeleccionado;
        public Vacaciones DatosVacacion { get; private set; }

        public VacacionForm(string titulo, Vacaciones vacacion)
        {
            InitializeComponent();
            Text = titulo;

            var baseVacacion = vacacion ?? new Vacaciones
            {
                FechaInicio = DateTime.Today,
                FechaFin = DateTime.Today.AddDays(7),
                Estado = "Pendiente"
            };

            DatosVacacion = baseVacacion;
            _empleadoIdSeleccionado = baseVacacion.EmpleadoID;

            txtEmpleado.Text = ObtenerNombreEmpleadoPorId(_empleadoIdSeleccionado);
            txtFechaInicio.Text = baseVacacion.FechaInicio.ToString("yyyy-MM-dd");
            txtFechaFin.Text = baseVacacion.FechaFin.ToString("yyyy-MM-dd");
            txtEstado.Text = baseVacacion.Estado ?? "Pendiente";
        }

        private string ObtenerNombreEmpleadoPorId(int id)
        {
            if (id <= 0) return string.Empty;
            using (var db = new SiManEmContexto())
            {
                var entidad = db.Empleados.AsNoTracking().FirstOrDefault(x => x.EmpleadoID == id);
                return entidad == null ? string.Empty : entidad.Nombre;
            }
        }

        private int? BuscarEmpleado()
        {
            using (var db = new SiManEmContexto())
            {
                var datos = db.Empleados.AsNoTracking()
                    .Select(x => new { x.EmpleadoID, x.Nombre, x.Estado })
                    .ToList();

                using (var busqueda = new BusquedaSeleccionForm("Buscar Empleado", "EmpleadoID", datos))
                {
                    return busqueda.ShowDialog(this) == DialogResult.OK ? busqueda.IdSeleccionado : null;
                }
            }
        }

        private void botonBuscarEmpleado_Click(object sender, EventArgs e)
        {
            var id = BuscarEmpleado();
            if (id == null) return;

            _empleadoIdSeleccionado = id.Value;
            txtEmpleado.Text = ObtenerNombreEmpleadoPorId(id.Value);
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio;
            DateTime fechaFin;

            if (_empleadoIdSeleccionado <= 0)
            {
                MessageBox.Show("Debe seleccionar un Empleado.");
                return;
            }
            if (!DateTime.TryParse(txtFechaInicio.Text.Trim(), out fechaInicio) ||
                !DateTime.TryParse(txtFechaFin.Text.Trim(), out fechaFin))
            {
                MessageBox.Show("Fechas invalidas.");
                return;
            }

            DatosVacacion.EmpleadoID = _empleadoIdSeleccionado;
            DatosVacacion.FechaInicio = fechaInicio;
            DatosVacacion.FechaFin = fechaFin;
            DatosVacacion.Estado = txtEstado.Text.Trim();

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
