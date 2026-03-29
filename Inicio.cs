using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using SiManEm.Datos;
using SiManEm.Formularios;
using SiManEm.Modelos;
using SiManEm.Servicios;

namespace SiManEm
{
    public partial class Inicio : Form
    {
        private static readonly CultureInfo CulturaRd = new CultureInfo("es-DO");
        private readonly ReportePdfServicio _reportePdfServicio = new ReportePdfServicio();
        private readonly string _usuarioLogueado;
        private bool _cargandoComboDashboard;

        private class OpcionDepartamentoDashboard
        {
            public int? DepartamentoID { get; set; }
            public string Nombre { get; set; }
            public override string ToString()
            {
                return Nombre;
            }
        }

        public Inicio(string usuarioLogueado)
        {
            _usuarioLogueado = string.IsNullOrWhiteSpace(usuarioLogueado) ? "UsuarioSistema" : usuarioLogueado.Trim();
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
            botonTabUsuarios.BackColor = colorNormal;

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
            else if (indiceActivo == 5)
            {
                botonTabUsuarios.BackColor = colorActivo;
            }
        }

        private void botonTabInicio_Click(object sender, System.EventArgs e)
        {
            SeleccionarPestana(0);
            etiquetaTituloInicio.Text = "Dashboard";
        }

        private void botonTabEmpleados_Click(object sender, System.EventArgs e)
        {
            SeleccionarPestana(1);
            etiquetaTituloInicio.Text = "Empleados";
        }

        private void botonTabDepartamentos_Click(object sender, System.EventArgs e)
        {
            SeleccionarPestana(2);
            etiquetaTituloInicio.Text = "Departamentos";
        }

        private void botonTabCargos_Click(object sender, System.EventArgs e)
        {
            SeleccionarPestana(3);
            etiquetaTituloInicio.Text = "Cargos";
        }

        private void botonTabVacaciones_Click(object sender, System.EventArgs e)
        {
            SeleccionarPestana(4);
            etiquetaTituloInicio.Text = "Vacaciones";
        }

        private void botonTabUsuarios_Click(object sender, System.EventArgs e)
        {
            SeleccionarPestana(5);
            etiquetaTituloInicio.Text = "Usuarios";
        }

        private void botonMinimizar_Click(object sender, System.EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void botonCerrar_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
            CargarDepartamentos();
            CargarCargos();
            CargarVacaciones();
            CargarUsuarios();
        }

        private void CargarDashboard()
        {
            using (var db = new SiManEmContexto())
            {
                var empleados = db.Empleados
                    .Include(x => x.Departamento)
                    .AsNoTracking()
                    .ToList();

                var empleadosActivos = empleados
                    .Where(x => string.Equals(x.Estado, "Activo", StringComparison.OrdinalIgnoreCase))
                    .ToList();

                etiquetaDashboardTotalEmpleadosValor.Text = empleados.Count.ToString();
                etiquetaDashboardAfpValor.Text = FormatearMonedaRd(empleadosActivos.Sum(x => x.AFP));
                etiquetaDashboardArsValor.Text = FormatearMonedaRd(empleadosActivos.Sum(x => x.ARS));
                etiquetaDashboardIsrValor.Text = FormatearMonedaRd(empleadosActivos.Sum(x => x.ISR));

                var resumenDepartamentos = empleados
                    .GroupBy(x => x.Departamento == null ? "Sin Departamento" : x.Departamento.Nombre)
                    .Select(g => new
                    {
                        Departamento = g.Key,
                        CantidadEmpleados = g.Count(),
                        EmpleadosActivos = g.Count(x => string.Equals(x.Estado, "Activo", StringComparison.OrdinalIgnoreCase)),
                        NominaMensual = g.Sum(x => x.Salario),
                        DescuentoAFP = g.Sum(x => x.AFP),
                        DescuentoARS = g.Sum(x => x.ARS),
                        DescuentoISR = g.Sum(x => x.ISR)
                    })
                    .OrderByDescending(x => x.CantidadEmpleados)
                    .ThenBy(x => x.Departamento)
                    .ToList();

                gridDashboardDepartamentos.DataSource = resumenDepartamentos;
                AplicarFormatoMonedaEnGrid(gridDashboardDepartamentos);

                CargarComboDashboardDepartamentos(db);
            }

            ActualizarCantidadPorDepartamentoDashboard();
        }

        private void CargarComboDashboardDepartamentos(SiManEmContexto db)
        {
            var seleccionadoActual = comboDashboardDepartamento.SelectedItem as OpcionDepartamentoDashboard;
            var seleccionadoId = seleccionadoActual?.DepartamentoID;

            var departamentos = db.Departamentos
                .AsNoTracking()
                .OrderBy(x => x.Nombre)
                .Select(x => new OpcionDepartamentoDashboard
                {
                    DepartamentoID = x.DepartamentoID,
                    Nombre = x.Nombre
                })
                .ToList();

            _cargandoComboDashboard = true;
            comboDashboardDepartamento.Items.Clear();
            comboDashboardDepartamento.Items.Add(new OpcionDepartamentoDashboard
            {
                DepartamentoID = null,
                Nombre = "Todos"
            });

            foreach (var depto in departamentos)
            {
                comboDashboardDepartamento.Items.Add(depto);
            }

            OpcionDepartamentoDashboard opcionSeleccionada = null;
            if (seleccionadoId != null)
            {
                opcionSeleccionada = comboDashboardDepartamento.Items
                    .OfType<OpcionDepartamentoDashboard>()
                    .FirstOrDefault(x => x.DepartamentoID == seleccionadoId);
            }

            comboDashboardDepartamento.SelectedItem = opcionSeleccionada ?? comboDashboardDepartamento.Items[0];
            _cargandoComboDashboard = false;
        }

        private void ActualizarCantidadPorDepartamentoDashboard()
        {
            var opcion = comboDashboardDepartamento.SelectedItem as OpcionDepartamentoDashboard;
            if (opcion == null)
            {
                etiquetaDashboardDepartamentoValor.Text = "0";
                return;
            }

            using (var db = new SiManEmContexto())
            {
                int cantidad;
                if (opcion.DepartamentoID == null)
                {
                    cantidad = db.Empleados.Count();
                }
                else
                {
                    var id = opcion.DepartamentoID.Value;
                    cantidad = db.Empleados.Count(x => x.DepartamentoID == id);
                }

                etiquetaDashboardDepartamentoValor.Text = cantidad.ToString();
            }
        }

        private void CargarEmpleados()
        {
            using (var db = new SiManEmContexto())
            {
                var datos = db.Empleados
                    .Include(x => x.Departamento)
                    .Include(x => x.Cargo)
                    .AsNoTracking()
                    .Select(x => new
                    {
                        x.EmpleadoID,
                        x.Nombre,
                        Departamento = x.Departamento.Nombre,
                        Cargo = x.Cargo.Nombre,
                        x.FechaInicio,
                        x.Salario,
                        x.Estado
                    })
                    .ToList();

                gridEmpleados.DataSource = datos;
                AplicarFormatoMonedaEnGrid(gridEmpleados);
            }

            CargarDashboard();
        }

        private void CargarDepartamentos()
        {
            using (var db = new SiManEmContexto())
            {
                gridDepartamentos.DataSource = db.Departamentos
                    .AsNoTracking()
                    .Select(x => new
                    {
                        x.DepartamentoID,
                        x.Nombre,
                        x.Descripcion
                    })
                    .ToList();

                AplicarFormatoMonedaEnGrid(gridDepartamentos);
            }

            CargarDashboard();
        }

        private void CargarCargos()
        {
            using (var db = new SiManEmContexto())
            {
                gridCargos.DataSource = db.Cargos
                    .Include(x => x.Departamento)
                    .AsNoTracking()
                    .Select(x => new
                    {
                        x.CargoID,
                        x.Nombre,
                        Departamento = x.Departamento.Nombre,
                        x.Descripcion
                    })
                    .ToList();

                AplicarFormatoMonedaEnGrid(gridCargos);
            }
        }

        private void CargarVacaciones()
        {
            using (var db = new SiManEmContexto())
            {
                var datos = db.Vacaciones
                    .Include(x => x.Empleado)
                    .AsNoTracking()
                    .Select(x => new
                    {
                        x.VacacionID,
                        Empleado = x.Empleado.Nombre,
                        x.FechaInicio,
                        x.FechaFin,
                        x.Estado
                    })
                    .ToList();

                gridVacaciones.DataSource = datos;
                AplicarFormatoMonedaEnGrid(gridVacaciones);
            }
        }

        private void CargarUsuarios()
        {
            using (var db = new SiManEmContexto())
            {
                gridUsuarios.DataSource = db.Usuarios
                    .AsNoTracking()
                    .Select(x => new
                    {
                        x.UsuarioID,
                        x.NombreUsuario,
                        x.Rol,
                        x.Estado
                    })
                    .ToList();
            }
        }

        private void AplicarFormatoMonedaEnGrid(DataGridView grid)
        {
            if (grid == null || grid.Columns == null) return;

            foreach (DataGridViewColumn columna in grid.Columns)
            {
                var nombre = (columna.Name ?? string.Empty).ToLowerInvariant();
                var encabezado = (columna.HeaderText ?? string.Empty).ToLowerInvariant();
                var esMoneda = nombre.Contains("salario")
                               || nombre.Contains("cuota")
                               || nombre.Contains("limite")
                               || encabezado.Contains("salario")
                               || encabezado.Contains("cuota")
                               || encabezado.Contains("limite");

                if (esMoneda)
                {
                    columna.DefaultCellStyle.Format = "C2";
                    columna.DefaultCellStyle.FormatProvider = CulturaRd;
                    columna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            }
        }

        private string FormatearMonedaRd(decimal valor)
        {
            return valor.ToString("C2", CulturaRd);
        }

        private string ObtenerRutaExportacionPdf(string nombreBase)
        {
            var carpetaPublica = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments),
                "SiManEm",
                "Reportes");

            Directory.CreateDirectory(carpetaPublica);

            return Path.Combine(carpetaPublica, string.Format("{0}_{1:yyyyMMdd_HHmmss}.pdf", nombreBase, DateTime.Now));
        }

        private void AbrirPdfExportado(string ruta)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = ruta,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("El PDF se guardo, pero no se pudo abrir automaticamente: " + ex.Message);
            }
        }

        private int? ObtenerIdSeleccionado(DataGridView grid, string nombreColumna)
        {
            if (grid.CurrentRow == null) return null;
            if (grid.CurrentRow.Cells[nombreColumna]?.Value == null) return null;

            return Convert.ToInt32(grid.CurrentRow.Cells[nombreColumna].Value);
        }

        private void botonNuevoEmpleado_Click(object sender, EventArgs e)
        {
            using (var formulario = new EmpleadoForm("Nuevo Empleado", null))
            {
                if (formulario.ShowDialog(this) != DialogResult.OK) return;

                using (var db = new SiManEmContexto())
                {
                    db.Empleados.Add(formulario.DatosEmpleado);
                    db.SaveChanges();
                }
            }

            CargarEmpleados();
        }

        private void botonEditarEmpleado_Click(object sender, EventArgs e)
        {
            var id = ObtenerIdSeleccionado(gridEmpleados, "EmpleadoID");
            if (id == null) return;

            using (var db = new SiManEmContexto())
            {
                var entidad = db.Empleados.FirstOrDefault(x => x.EmpleadoID == id.Value);
                if (entidad == null) return;

                var copia = new Empleado
                {
                    EmpleadoID = entidad.EmpleadoID,
                    Nombre = entidad.Nombre,
                    DepartamentoID = entidad.DepartamentoID,
                    CargoID = entidad.CargoID,
                    FechaInicio = entidad.FechaInicio,
                    Salario = entidad.Salario,
                    Estado = entidad.Estado
                };

                using (var formulario = new EmpleadoForm("Editar Empleado", copia))
                {
                    if (formulario.ShowDialog(this) != DialogResult.OK) return;

                    entidad.Nombre = formulario.DatosEmpleado.Nombre;
                    entidad.DepartamentoID = formulario.DatosEmpleado.DepartamentoID;
                    entidad.CargoID = formulario.DatosEmpleado.CargoID;
                    entidad.FechaInicio = formulario.DatosEmpleado.FechaInicio;
                    entidad.Salario = formulario.DatosEmpleado.Salario;
                    entidad.Estado = formulario.DatosEmpleado.Estado;
                }
                db.SaveChanges();
            }

            CargarEmpleados();
        }

        private void botonEliminarEmpleado_Click(object sender, EventArgs e)
        {
            var id = ObtenerIdSeleccionado(gridEmpleados, "EmpleadoID");
            if (id == null) return;

            if (MessageBox.Show("Desea eliminar el empleado?", "Confirmar", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            try
            {
                using (var db = new SiManEmContexto())
                {
                    var entidad = db.Empleados.FirstOrDefault(x => x.EmpleadoID == id.Value);
                    if (entidad == null) return;
                    db.Empleados.Remove(entidad);
                    db.SaveChanges();
                }
                CargarEmpleados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar: " + ex.Message);
            }
        }

        private void botonRefrescarEmpleado_Click(object sender, EventArgs e)
        {
            CargarEmpleados();
        }

        private void botonExportarEmpleados_Click(object sender, EventArgs e)
        {
            var ruta = ObtenerRutaExportacionPdf("Reporte_Empleados");
            if (string.IsNullOrWhiteSpace(ruta)) return;

            _reportePdfServicio.ExportarEmpleados(ruta, _usuarioLogueado);
            AbrirPdfExportado(ruta);
        }

        private void botonNuevoDepartamento_Click(object sender, EventArgs e)
        {
            using (var formulario = new DepartamentoForm("Nuevo Departamento", null))
            {
                if (formulario.ShowDialog(this) != DialogResult.OK) return;

                using (var db = new SiManEmContexto())
                {
                    db.Departamentos.Add(formulario.DatosDepartamento);
                    db.SaveChanges();
                }
            }

            CargarDepartamentos();
        }

        private void botonEditarDepartamento_Click(object sender, EventArgs e)
        {
            var id = ObtenerIdSeleccionado(gridDepartamentos, "DepartamentoID");
            if (id == null) return;

            using (var db = new SiManEmContexto())
            {
                var entidad = db.Departamentos.FirstOrDefault(x => x.DepartamentoID == id.Value);
                if (entidad == null) return;

                var copia = new Departamento
                {
                    DepartamentoID = entidad.DepartamentoID,
                    Nombre = entidad.Nombre,
                    Descripcion = entidad.Descripcion
                };

                using (var formulario = new DepartamentoForm("Editar Departamento", copia))
                {
                    if (formulario.ShowDialog(this) != DialogResult.OK) return;

                    entidad.Nombre = formulario.DatosDepartamento.Nombre;
                    entidad.Descripcion = formulario.DatosDepartamento.Descripcion;
                }
                db.SaveChanges();
            }
            CargarDepartamentos();
        }

        private void botonEliminarDepartamento_Click(object sender, EventArgs e)
        {
            var id = ObtenerIdSeleccionado(gridDepartamentos, "DepartamentoID");
            if (id == null) return;

            if (MessageBox.Show("Desea eliminar el departamento?", "Confirmar", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            try
            {
                using (var db = new SiManEmContexto())
                {
                    var entidad = db.Departamentos.FirstOrDefault(x => x.DepartamentoID == id.Value);
                    if (entidad == null) return;
                    db.Departamentos.Remove(entidad);
                    db.SaveChanges();
                }
                CargarDepartamentos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar: " + ex.Message);
            }
        }

        private void botonRefrescarDepartamento_Click(object sender, EventArgs e)
        {
            CargarDepartamentos();
        }

        private void botonExportarDepartamentos_Click(object sender, EventArgs e)
        {
            var ruta = ObtenerRutaExportacionPdf("Reporte_Departamentos");
            if (string.IsNullOrWhiteSpace(ruta)) return;

            _reportePdfServicio.ExportarDepartamentos(ruta, _usuarioLogueado);
            AbrirPdfExportado(ruta);
        }

        private void botonNuevoCargo_Click(object sender, EventArgs e)
        {
            using (var formulario = new CargoForm("Nuevo Cargo", null))
            {
                if (formulario.ShowDialog(this) != DialogResult.OK) return;

                using (var db = new SiManEmContexto())
                {
                    db.Cargos.Add(formulario.DatosCargo);
                    db.SaveChanges();
                }
            }

            CargarCargos();
        }

        private void botonEditarCargo_Click(object sender, EventArgs e)
        {
            var id = ObtenerIdSeleccionado(gridCargos, "CargoID");
            if (id == null) return;

            using (var db = new SiManEmContexto())
            {
                var entidad = db.Cargos.FirstOrDefault(x => x.CargoID == id.Value);
                if (entidad == null) return;

                var copia = new Cargo
                {
                    CargoID = entidad.CargoID,
                    Nombre = entidad.Nombre,
                    DepartamentoID = entidad.DepartamentoID,
                    Descripcion = entidad.Descripcion
                };

                using (var formulario = new CargoForm("Editar Cargo", copia))
                {
                    if (formulario.ShowDialog(this) != DialogResult.OK) return;

                    entidad.Nombre = formulario.DatosCargo.Nombre;
                    entidad.DepartamentoID = formulario.DatosCargo.DepartamentoID;
                    entidad.Descripcion = formulario.DatosCargo.Descripcion;
                    db.SaveChanges();
                }
            }

            CargarCargos();
        }

        private void botonEliminarCargo_Click(object sender, EventArgs e)
        {
            var id = ObtenerIdSeleccionado(gridCargos, "CargoID");
            if (id == null) return;

            if (MessageBox.Show("Desea eliminar el cargo?", "Confirmar", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            try
            {
                using (var db = new SiManEmContexto())
                {
                    var entidad = db.Cargos.FirstOrDefault(x => x.CargoID == id.Value);
                    if (entidad == null) return;
                    db.Cargos.Remove(entidad);
                    db.SaveChanges();
                }
                CargarCargos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar: " + ex.Message);
            }
        }

        private void botonRefrescarCargo_Click(object sender, EventArgs e)
        {
            CargarCargos();
        }

        private void botonExportarCargos_Click(object sender, EventArgs e)
        {
            var ruta = ObtenerRutaExportacionPdf("Reporte_Cargos");
            if (string.IsNullOrWhiteSpace(ruta)) return;

            _reportePdfServicio.ExportarCargos(ruta, _usuarioLogueado);
            AbrirPdfExportado(ruta);
        }

        private void botonNuevaVacacion_Click(object sender, EventArgs e)
        {
            using (var formulario = new VacacionForm("Nueva Vacacion", null))
            {
                if (formulario.ShowDialog(this) != DialogResult.OK) return;

                using (var db = new SiManEmContexto())
                {
                    db.Vacaciones.Add(formulario.DatosVacacion);
                    db.SaveChanges();
                }
            }

            CargarVacaciones();
        }

        private void botonEditarVacacion_Click(object sender, EventArgs e)
        {
            var id = ObtenerIdSeleccionado(gridVacaciones, "VacacionID");
            if (id == null) return;

            using (var db = new SiManEmContexto())
            {
                var entidad = db.Vacaciones.FirstOrDefault(x => x.VacacionID == id.Value);
                if (entidad == null) return;

                var copia = new Vacaciones
                {
                    VacacionID = entidad.VacacionID,
                    EmpleadoID = entidad.EmpleadoID,
                    FechaInicio = entidad.FechaInicio,
                    FechaFin = entidad.FechaFin,
                    Estado = entidad.Estado
                };

                using (var formulario = new VacacionForm("Editar Vacacion", copia))
                {
                    if (formulario.ShowDialog(this) != DialogResult.OK) return;

                    entidad.EmpleadoID = formulario.DatosVacacion.EmpleadoID;
                    entidad.FechaInicio = formulario.DatosVacacion.FechaInicio;
                    entidad.FechaFin = formulario.DatosVacacion.FechaFin;
                    entidad.Estado = formulario.DatosVacacion.Estado;
                }
                db.SaveChanges();
            }
            CargarVacaciones();
        }

        private void botonEliminarVacacion_Click(object sender, EventArgs e)
        {
            var id = ObtenerIdSeleccionado(gridVacaciones, "VacacionID");
            if (id == null) return;

            if (MessageBox.Show("Desea eliminar la vacacion?", "Confirmar", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            using (var db = new SiManEmContexto())
            {
                var entidad = db.Vacaciones.FirstOrDefault(x => x.VacacionID == id.Value);
                if (entidad == null) return;
                db.Vacaciones.Remove(entidad);
                db.SaveChanges();
            }
            CargarVacaciones();
        }

        private void botonRefrescarVacacion_Click(object sender, EventArgs e)
        {
            CargarVacaciones();
        }

        private void botonExportarVacaciones_Click(object sender, EventArgs e)
        {
            var ruta = ObtenerRutaExportacionPdf("Reporte_Vacaciones");
            if (string.IsNullOrWhiteSpace(ruta)) return;

            _reportePdfServicio.ExportarVacaciones(ruta, _usuarioLogueado);
            AbrirPdfExportado(ruta);
        }

        private void botonNuevoUsuario_Click(object sender, EventArgs e)
        {
            using (var formulario = new UsuarioForm("Nuevo Usuario", null))
            {
                if (formulario.ShowDialog(this) != DialogResult.OK) return;

                if (string.IsNullOrWhiteSpace(formulario.ContrasenaTexto))
                {
                    MessageBox.Show("La contraseña es obligatoria.");
                    return;
                }

                using (var db = new SiManEmContexto())
                {
                    db.Usuarios.Add(new Usuario
                    {
                        NombreUsuario = formulario.NombreUsuario,
                        Contrasena = AutenticacionServicio.ObtenerHash(formulario.ContrasenaTexto),
                        Rol = formulario.Rol,
                        Estado = formulario.Estado
                    });
                    db.SaveChanges();
                }
            }

            CargarUsuarios();
        }

        private void botonEditarUsuario_Click(object sender, EventArgs e)
        {
            var id = ObtenerIdSeleccionado(gridUsuarios, "UsuarioID");
            if (id == null) return;

            using (var db = new SiManEmContexto())
            {
                var entidad = db.Usuarios.FirstOrDefault(x => x.UsuarioID == id.Value);
                if (entidad == null) return;

                var copia = new Usuario
                {
                    UsuarioID = entidad.UsuarioID,
                    NombreUsuario = entidad.NombreUsuario,
                    Rol = entidad.Rol,
                    Estado = entidad.Estado
                };

                using (var formulario = new UsuarioForm("Editar Usuario", copia))
                {
                    if (formulario.ShowDialog(this) != DialogResult.OK) return;

                    entidad.NombreUsuario = formulario.NombreUsuario;
                    entidad.Rol = formulario.Rol;
                    entidad.Estado = formulario.Estado;

                    if (!string.IsNullOrWhiteSpace(formulario.ContrasenaTexto))
                    {
                        entidad.Contrasena = AutenticacionServicio.ObtenerHash(formulario.ContrasenaTexto);
                    }
                }
                db.SaveChanges();
            }

            CargarUsuarios();
        }

        private void botonEliminarUsuario_Click(object sender, EventArgs e)
        {
            var id = ObtenerIdSeleccionado(gridUsuarios, "UsuarioID");
            if (id == null) return;

            if (MessageBox.Show("Desea eliminar el usuario?", "Confirmar", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            using (var db = new SiManEmContexto())
            {
                var entidad = db.Usuarios.FirstOrDefault(x => x.UsuarioID == id.Value);
                if (entidad == null) return;
                db.Usuarios.Remove(entidad);
                db.SaveChanges();
            }
            CargarUsuarios();
        }

        private void botonRefrescarUsuario_Click(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private void botonExportarUsuarios_Click(object sender, EventArgs e)
        {
            var ruta = ObtenerRutaExportacionPdf("Reporte_Usuarios");
            if (string.IsNullOrWhiteSpace(ruta)) return;

            _reportePdfServicio.ExportarUsuarios(ruta, _usuarioLogueado);
            AbrirPdfExportado(ruta);
        }

        private void comboDashboardDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_cargandoComboDashboard)
            {
                return;
            }

            ActualizarCantidadPorDepartamentoDashboard();
        }

        private void botonDashboardRefrescar_Click(object sender, EventArgs e)
        {
            CargarDashboard();
        }

        private void botonExportarDashboard_Click(object sender, EventArgs e)
        {
            var ruta = ObtenerRutaExportacionPdf("Reporte_Dashboard");
            if (string.IsNullOrWhiteSpace(ruta)) return;

            _reportePdfServicio.ExportarResumenDashboard(ruta, _usuarioLogueado);
            AbrirPdfExportado(ruta);
        }

        private void botonConfigNomina_Click(object sender, EventArgs e)
        {
            using (var formulario = new ConfiguracionNominaForm())
            {
                formulario.ShowDialog(this);
            }

            CargarEmpleados();
        }
    }
}
