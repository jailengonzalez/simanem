using System;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using SiManEm.Datos;
using SiManEm.Modelos;

namespace SiManEm.Formularios
{
    public partial class EmpleadoForm : Form
    {
        private static readonly CultureInfo CulturaRd = new CultureInfo("es-DO");
        private int _departamentoIdSeleccionado;
        private int _cargoIdSeleccionado;

        public Empleado DatosEmpleado { get; private set; }

        public EmpleadoForm(string titulo, Empleado empleado)
        {
            InitializeComponent();
            Text = titulo;

            var baseEmpleado = empleado ?? new Empleado
            {
                FechaInicio = DateTime.Today,
                Salario = 0m,
                Estado = "Activo"
            };

            DatosEmpleado = baseEmpleado;
            _departamentoIdSeleccionado = baseEmpleado.DepartamentoID;
            _cargoIdSeleccionado = baseEmpleado.CargoID;

            txtNombre.Text = baseEmpleado.Nombre ?? string.Empty;
            txtFechaInicio.Text = baseEmpleado.FechaInicio.ToString("yyyy-MM-dd");
            txtSalario.Text = FormatearMonedaRd(baseEmpleado.Salario);
            txtEstado.Text = baseEmpleado.Estado ?? "Activo";
            txtDepartamento.Text = ObtenerNombreDepartamentoPorId(_departamentoIdSeleccionado);
            txtCargo.Text = ObtenerNombreCargoPorId(_cargoIdSeleccionado);
        }

        private string FormatearMonedaRd(decimal valor)
        {
            return valor.ToString("C2", CulturaRd);
        }

        private bool TryParseMonedaRd(string texto, out decimal valor)
        {
            valor = 0m;
            if (string.IsNullOrWhiteSpace(texto)) return false;

            if (decimal.TryParse(texto, NumberStyles.Currency, CulturaRd, out valor))
            {
                return true;
            }

            var limpio = texto.Replace("RD$", string.Empty).Replace("$", string.Empty).Trim();
            if (decimal.TryParse(limpio, NumberStyles.Number, CulturaRd, out valor))
            {
                return true;
            }

            return decimal.TryParse(limpio, NumberStyles.Number, CultureInfo.InvariantCulture, out valor);
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

        private string ObtenerNombreCargoPorId(int id)
        {
            if (id <= 0) return string.Empty;
            using (var db = new SiManEmContexto())
            {
                var entidad = db.Cargos.AsNoTracking().FirstOrDefault(x => x.CargoID == id);
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

        private int? BuscarCargo(int departamentoId)
        {
            using (var db = new SiManEmContexto())
            {
                var datos = db.Cargos.AsNoTracking()
                    .Where(x => x.DepartamentoID == departamentoId)
                    .Select(x => new { x.CargoID, x.Nombre, x.Descripcion })
                    .ToList();

                using (var busqueda = new BusquedaSeleccionForm("Buscar Cargo", "CargoID", datos))
                {
                    return busqueda.ShowDialog(this) == DialogResult.OK ? busqueda.IdSeleccionado : null;
                }
            }
        }

        private void txtSalario_Leave(object sender, EventArgs e)
        {
            decimal valor;
            if (TryParseMonedaRd(txtSalario.Text.Trim(), out valor))
            {
                txtSalario.Text = FormatearMonedaRd(valor);
            }
        }

        private void botonBuscarDepartamento_Click(object sender, EventArgs e)
        {
            var id = BuscarDepartamento();
            if (id == null) return;

            _departamentoIdSeleccionado = id.Value;
            txtDepartamento.Text = ObtenerNombreDepartamentoPorId(id.Value);

            _cargoIdSeleccionado = 0;
            txtCargo.Text = string.Empty;
        }

        private void botonBuscarCargo_Click(object sender, EventArgs e)
        {
            if (_departamentoIdSeleccionado <= 0)
            {
                MessageBox.Show("Primero seleccione un Departamento.");
                return;
            }

            var id = BuscarCargo(_departamentoIdSeleccionado);
            if (id == null) return;

            _cargoIdSeleccionado = id.Value;
            txtCargo.Text = ObtenerNombreCargoPorId(id.Value);
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            decimal salario;
            DateTime fechaInicio;

            if (_departamentoIdSeleccionado <= 0 || _cargoIdSeleccionado <= 0)
            {
                MessageBox.Show("Debe seleccionar Departamento y Cargo.");
                return;
            }
            if (!DateTime.TryParse(txtFechaInicio.Text.Trim(), out fechaInicio))
            {
                MessageBox.Show("FechaInicio invalida.");
                return;
            }
            if (!TryParseMonedaRd(txtSalario.Text.Trim(), out salario))
            {
                MessageBox.Show("Salario invalido.");
                return;
            }

            DatosEmpleado.Nombre = txtNombre.Text.Trim();
            DatosEmpleado.DepartamentoID = _departamentoIdSeleccionado;
            DatosEmpleado.CargoID = _cargoIdSeleccionado;
            DatosEmpleado.FechaInicio = fechaInicio;
            DatosEmpleado.Salario = salario;
            DatosEmpleado.Estado = txtEstado.Text.Trim();

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
