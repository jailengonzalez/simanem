using System;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using SiManEm.Datos;
using SiManEm.Modelos;

namespace SiManEm.Formularios
{
    public partial class ConfiguracionNominaForm : Form
    {
        private static readonly CultureInfo CulturaRd = new CultureInfo("es-DO");

        public ConfiguracionNominaForm()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            using (var db = new SiManEmContexto())
            {
                var config = db.ConfiguracionesNomina.AsNoTracking().FirstOrDefault();
                if (config == null)
                {
                    _txtAfp.Text = FormatearPorcentajeSimple(3.04m);
                    _txtArs.Text = FormatearPorcentajeSimple(3.04m);
                }
                else
                {
                    _txtAfp.Text = FormatearPorcentajeSimple(config.PorcentajeAfp);
                    _txtArs.Text = FormatearPorcentajeSimple(config.PorcentajeArs);
                }

                var escalas = db.EscalasIsr
                    .AsNoTracking()
                    .OrderBy(x => x.LimiteInferior)
                    .Select(x => new
                    {
                        x.EscalaIsrID,
                        x.LimiteInferior,
                        x.LimiteSuperior,
                        x.Tasa,
                        x.CuotaFija
                    })
                    .ToList();

                _gridEscalas.DataSource = escalas;
                AplicarFormatoMonedaEnGrid(_gridEscalas);
            }
        }

        private void AplicarFormatoMonedaEnGrid(DataGridView grid)
        {
            if (grid == null || grid.Columns == null) return;

            foreach (DataGridViewColumn columna in grid.Columns)
            {
                var nombre = (columna.Name ?? string.Empty).ToLowerInvariant();
                var encabezado = (columna.HeaderText ?? string.Empty).ToLowerInvariant();
                var esMoneda = nombre.Contains("limite") || nombre.Contains("cuota")
                               || encabezado.Contains("limite") || encabezado.Contains("cuota");
                var esPorcentaje = nombre.Contains("tasa") || encabezado.Contains("tasa");

                if (esMoneda)
                {
                    columna.DefaultCellStyle.Format = "C2";
                    columna.DefaultCellStyle.FormatProvider = CulturaRd;
                    columna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
                else if (esPorcentaje)
                {
                    columna.DefaultCellStyle.Format = "P2";
                    columna.DefaultCellStyle.FormatProvider = CulturaRd;
                    columna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            }
        }

        private string FormatearPorcentajeSimple(decimal valor)
        {
            return string.Format(CulturaRd, "{0:N2} %", valor);
        }

        private bool TryParsePorcentajeSimple(string texto, out decimal valor)
        {
            valor = 0m;
            if (string.IsNullOrWhiteSpace(texto)) return false;

            var limpio = texto.Replace("%", string.Empty).Trim();
            if (decimal.TryParse(limpio, NumberStyles.Number, CulturaRd, out valor))
            {
                return true;
            }

            return decimal.TryParse(limpio, NumberStyles.Number, CultureInfo.InvariantCulture, out valor);
        }


        private void _txtAfp_Leave(object sender, EventArgs e)
        {
            decimal valor;
            if (TryParsePorcentajeSimple(_txtAfp.Text.Trim(), out valor))
            {
                _txtAfp.Text = FormatearPorcentajeSimple(valor);
            }
        }

        private void _txtArs_Leave(object sender, EventArgs e)
        {
            decimal valor;
            if (TryParsePorcentajeSimple(_txtArs.Text.Trim(), out valor))
            {
                _txtArs.Text = FormatearPorcentajeSimple(valor);
            }
        }

        private void _btnRecargar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void _gridEscalas_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            AplicarFormatoMonedaEnGrid(_gridEscalas);
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            decimal afp;
            decimal ars;
            if (!TryParsePorcentajeSimple(_txtAfp.Text.Trim(), out afp) || !TryParsePorcentajeSimple(_txtArs.Text.Trim(), out ars))
            {
                MessageBox.Show("AFP y ARS deben ser numericos.");
                return;
            }

            using (var db = new SiManEmContexto())
            {
                var config = db.ConfiguracionesNomina.FirstOrDefault();
                if (config == null)
                {
                    config = new ConfiguracionNomina();
                    db.ConfiguracionesNomina.Add(config);
                }

                config.PorcentajeAfp = afp;
                config.PorcentajeArs = ars;
                db.SaveChanges();
            }

            _txtAfp.Text = FormatearPorcentajeSimple(afp);
            _txtArs.Text = FormatearPorcentajeSimple(ars);
            MessageBox.Show("Configuracion guardada.");
            CargarDatos();
        }

        private int? ObtenerEscalaSeleccionada()
        {
            if (_gridEscalas.CurrentRow == null || _gridEscalas.CurrentRow.Cells["EscalaIsrID"]?.Value == null)
            {
                return null;
            }
            return Convert.ToInt32(_gridEscalas.CurrentRow.Cells["EscalaIsrID"].Value);
        }

        private EscalaIsr MostrarFormularioEscala(string titulo, EscalaIsr escala)
        {
            using (var formulario = new EscalaIsrForm(titulo, escala))
            {
                if (formulario.ShowDialog(this) != DialogResult.OK)
                {
                    return null;
                }

                return formulario.DatosEscala;
            }
        }

        private void BtnAgregarEscala_Click(object sender, EventArgs e)
        {
            var datos = MostrarFormularioEscala("Agregar Escala ISR", null);
            if (datos == null) return;

            using (var db = new SiManEmContexto())
            {
                db.EscalasIsr.Add(new EscalaIsr
                {
                    LimiteInferior = datos.LimiteInferior,
                    LimiteSuperior = datos.LimiteSuperior,
                    Tasa = datos.Tasa,
                    CuotaFija = datos.CuotaFija
                });
                db.SaveChanges();
            }

            CargarDatos();
        }

        private void BtnEditarEscala_Click(object sender, EventArgs e)
        {
            var id = ObtenerEscalaSeleccionada();
            if (id == null) return;

            using (var db = new SiManEmContexto())
            {
                var escala = db.EscalasIsr.FirstOrDefault(x => x.EscalaIsrID == id.Value);
                if (escala == null) return;

                var datos = MostrarFormularioEscala("Editar Escala ISR", new EscalaIsr
                {
                    EscalaIsrID = escala.EscalaIsrID,
                    LimiteInferior = escala.LimiteInferior,
                    LimiteSuperior = escala.LimiteSuperior,
                    Tasa = escala.Tasa,
                    CuotaFija = escala.CuotaFija
                });
                if (datos == null) return;

                escala.LimiteInferior = datos.LimiteInferior;
                escala.LimiteSuperior = datos.LimiteSuperior;
                escala.Tasa = datos.Tasa;
                escala.CuotaFija = datos.CuotaFija;
                db.SaveChanges();
            }

            CargarDatos();
        }

        private void BtnEliminarEscala_Click(object sender, EventArgs e)
        {
            var id = ObtenerEscalaSeleccionada();
            if (id == null) return;

            if (MessageBox.Show("Desea eliminar la escala seleccionada?", "Confirmar", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                return;
            }

            using (var db = new SiManEmContexto())
            {
                var escala = db.EscalasIsr.FirstOrDefault(x => x.EscalaIsrID == id.Value);
                if (escala == null) return;
                db.EscalasIsr.Remove(escala);
                db.SaveChanges();
            }

            CargarDatos();
        }
    }
}
