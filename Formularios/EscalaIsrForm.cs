using System;
using System.Globalization;
using System.Windows.Forms;
using SiManEm.Modelos;

namespace SiManEm.Formularios
{
    public partial class EscalaIsrForm : Form
    {
        private static readonly CultureInfo CulturaRd = new CultureInfo("es-DO");

        public EscalaIsr DatosEscala { get; private set; }

        public EscalaIsrForm(string titulo, EscalaIsr escala)
        {
            InitializeComponent();
            Text = titulo;

            var escalaBase = escala ?? new EscalaIsr();
            DatosEscala = escalaBase;

            txtLimiteInferior.Text = FormatearMonedaRd(escalaBase.LimiteInferior);
            txtLimiteSuperior.Text = FormatearMonedaRd(escalaBase.LimiteSuperior);
            txtTasa.Text = FormatearPorcentajeTasa(escalaBase.Tasa);
            txtCuotaFija.Text = FormatearMonedaRd(escalaBase.CuotaFija);
        }

        private string FormatearMonedaRd(decimal valor)
        {
            return valor.ToString("C2", CulturaRd);
        }

        private string FormatearPorcentajeTasa(decimal valor)
        {
            return valor.ToString("P2", CulturaRd);
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

        private bool TryParsePorcentajeTasa(string texto, out decimal valor)
        {
            valor = 0m;
            if (string.IsNullOrWhiteSpace(texto)) return false;

            var limpio = texto.Replace("%", string.Empty).Trim();
            if (!decimal.TryParse(limpio, NumberStyles.Number, CulturaRd, out valor) &&
                !decimal.TryParse(limpio, NumberStyles.Number, CultureInfo.InvariantCulture, out valor))
            {
                return false;
            }

            if (valor > 1m)
            {
                valor = valor / 100m;
            }

            return true;
        }

        private void txtLimiteInferior_Leave(object sender, EventArgs e)
        {
            decimal valor;
            if (TryParseMonedaRd(txtLimiteInferior.Text.Trim(), out valor))
            {
                txtLimiteInferior.Text = FormatearMonedaRd(valor);
            }
        }

        private void txtLimiteSuperior_Leave(object sender, EventArgs e)
        {
            decimal valor;
            if (TryParseMonedaRd(txtLimiteSuperior.Text.Trim(), out valor))
            {
                txtLimiteSuperior.Text = FormatearMonedaRd(valor);
            }
        }

        private void txtTasa_Leave(object sender, EventArgs e)
        {
            decimal valor;
            if (TryParsePorcentajeTasa(txtTasa.Text.Trim(), out valor))
            {
                txtTasa.Text = FormatearPorcentajeTasa(valor);
            }
        }

        private void txtCuotaFija_Leave(object sender, EventArgs e)
        {
            decimal valor;
            if (TryParseMonedaRd(txtCuotaFija.Text.Trim(), out valor))
            {
                txtCuotaFija.Text = FormatearMonedaRd(valor);
            }
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            decimal limiteInferior;
            decimal limiteSuperior;
            decimal tasa;
            decimal cuotaFija;

            if (!TryParseMonedaRd(txtLimiteInferior.Text.Trim(), out limiteInferior) ||
                !TryParseMonedaRd(txtLimiteSuperior.Text.Trim(), out limiteSuperior) ||
                !TryParsePorcentajeTasa(txtTasa.Text.Trim(), out tasa) ||
                !TryParseMonedaRd(txtCuotaFija.Text.Trim(), out cuotaFija))
            {
                MessageBox.Show("Datos invalidos.");
                return;
            }

            DatosEscala.LimiteInferior = limiteInferior;
            DatosEscala.LimiteSuperior = limiteSuperior;
            DatosEscala.Tasa = tasa;
            DatosEscala.CuotaFija = cuotaFija;

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
