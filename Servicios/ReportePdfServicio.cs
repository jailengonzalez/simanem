using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using System.IO;
using System.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;
using SiManEm.Datos;

namespace SiManEm.Servicios
{
    public class ReportePdfServicio
    {
        private static readonly CultureInfo CulturaRd = new CultureInfo("es-DO");

        private class ColumnaReporte
        {
            public string Titulo { get; set; }
            public float Ancho { get; set; }
            public bool Derecha { get; set; }
        }

        private class EventoPaginaReporte : PdfPageEventHelper
        {
            private readonly string _titulo;
            private readonly string _usuario;
            private readonly Font _fuenteTitulo = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14, BaseColor.WHITE);
            private readonly Font _fuenteSub = FontFactory.GetFont(FontFactory.HELVETICA, 9, new BaseColor(220, 235, 255));
            private readonly Font _fuentePie = FontFactory.GetFont(FontFactory.HELVETICA, 8, new BaseColor(30, 45, 69));

            public EventoPaginaReporte(string titulo, string usuario)
            {
                _titulo = titulo;
                _usuario = string.IsNullOrWhiteSpace(usuario) ? Environment.UserName : usuario.Trim();
            }

            public override void OnEndPage(PdfWriter writer, Document document)
            {
                var cb = writer.DirectContent;

                cb.SetRGBColorFill(21, 36, 63);
                cb.Rectangle(0, document.PageSize.Height - 58, document.PageSize.Width, 58);
                cb.Fill();

                cb.SetRGBColorFill(40, 62, 105);
                cb.Rectangle(24, document.PageSize.Height - 50, 28, 28);
                cb.Fill();

                ColumnText.ShowTextAligned(cb, Element.ALIGN_LEFT,
                    new Phrase("S", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 15, BaseColor.WHITE)),
                    34, document.PageSize.Height - 40, 0);

                ColumnText.ShowTextAligned(cb, Element.ALIGN_LEFT,
                    new Phrase("SiManEm - Reporte", _fuenteTitulo),
                    58, document.PageSize.Height - 28, 0);

                ColumnText.ShowTextAligned(cb, Element.ALIGN_LEFT,
                    new Phrase(_titulo, _fuenteSub),
                    58, document.PageSize.Height - 44, 0);

                ColumnText.ShowTextAligned(cb, Element.ALIGN_LEFT,
                    new Phrase(string.Format("Fecha: {0:yyyy-MM-dd HH:mm}", DateTime.Now), _fuenteSub),
                    document.PageSize.Width - 160, document.PageSize.Height - 28, 0);

                ColumnText.ShowTextAligned(cb, Element.ALIGN_LEFT,
                    new Phrase(string.Format("Pagina {0}", writer.PageNumber), _fuenteSub),
                    document.PageSize.Width - 160, document.PageSize.Height - 42, 0);

                cb.SetRGBColorFill(242, 245, 250);
                cb.Rectangle(0, 0, document.PageSize.Width, 28);
                cb.Fill();

                cb.SetRGBColorStroke(200, 208, 220);
                cb.MoveTo(0, 28);
                cb.LineTo(document.PageSize.Width, 28);
                cb.Stroke();

                ColumnText.ShowTextAligned(cb, Element.ALIGN_LEFT,
                    new Phrase("Sistema de Gestion de Empleados - SiManEm", _fuentePie),
                    24, 10, 0);
                ColumnText.ShowTextAligned(cb, Element.ALIGN_LEFT,
                    new Phrase(string.Format("Usuario: {0}", _usuario), _fuentePie),
                    310, 10, 0);
                ColumnText.ShowTextAligned(cb, Element.ALIGN_LEFT,
                    new Phrase(string.Format("{0:yyyy-MM-dd HH:mm}", DateTime.Now), _fuentePie),
                    document.PageSize.Width - 125, 10, 0);
            }
        }

        public void ExportarEmpleados(string rutaPdf, string usuarioExportador = null)
        {
            using (var db = new SiManEmContexto())
            {
                var empleados = db.Empleados
                    .Include(x => x.Departamento)
                    .Include(x => x.Cargo)
                    .AsNoTracking()
                    .OrderBy(x => x.Nombre)
                    .ToList();

                var resumen = new List<string>
                {
                    "Modulo: Empleados",
                    string.Format("Total registros: {0}", empleados.Count)
                };

                var columnas = new List<ColumnaReporte>
                {
                    new ColumnaReporte { Titulo = "ID", Ancho = 35f, Derecha = true },
                    new ColumnaReporte { Titulo = "Nombre", Ancho = 120f },
                    new ColumnaReporte { Titulo = "Departamento", Ancho = 90f },
                    new ColumnaReporte { Titulo = "Cargo", Ancho = 90f },
                    new ColumnaReporte { Titulo = "Fecha Inicio", Ancho = 70f },
                    new ColumnaReporte { Titulo = "Salario", Ancho = 70f, Derecha = true },
                    new ColumnaReporte { Titulo = "Estado", Ancho = 60f }
                };

                var filas = empleados.Select(e => new[]
                {
                    e.EmpleadoID.ToString(),
                    e.Nombre ?? string.Empty,
                    e.Departamento == null ? "N/A" : e.Departamento.Nombre,
                    e.Cargo == null ? "N/A" : e.Cargo.Nombre,
                    e.FechaInicio.ToString("yyyy-MM-dd"),
                    e.Salario.ToString("C2", CulturaRd),
                    e.Estado ?? string.Empty
                }).ToList();

                GenerarPdfConTabla("Reporte de Empleados", resumen, columnas, filas, rutaPdf, usuarioExportador);
            }
        }

        public void ExportarDepartamentos(string rutaPdf, string usuarioExportador = null)
        {
            using (var db = new SiManEmContexto())
            {
                var departamentos = db.Departamentos
                    .AsNoTracking()
                    .OrderBy(x => x.Nombre)
                    .ToList();

                var resumen = new List<string>
                {
                    "Modulo: Departamentos",
                    string.Format("Total registros: {0}", departamentos.Count)
                };

                var columnas = new List<ColumnaReporte>
                {
                    new ColumnaReporte { Titulo = "ID", Ancho = 50f, Derecha = true },
                    new ColumnaReporte { Titulo = "Nombre", Ancho = 150f },
                    new ColumnaReporte { Titulo = "Descripcion", Ancho = 330f }
                };

                var filas = departamentos.Select(d => new[]
                {
                    d.DepartamentoID.ToString(),
                    d.Nombre ?? string.Empty,
                    d.Descripcion ?? string.Empty
                }).ToList();

                GenerarPdfConTabla("Reporte de Departamentos", resumen, columnas, filas, rutaPdf, usuarioExportador);
            }
        }

        public void ExportarCargos(string rutaPdf, string usuarioExportador = null)
        {
            using (var db = new SiManEmContexto())
            {
                var cargos = db.Cargos
                    .Include(x => x.Departamento)
                    .AsNoTracking()
                    .OrderBy(x => x.Nombre)
                    .ToList();

                var resumen = new List<string>
                {
                    "Modulo: Cargos",
                    string.Format("Total registros: {0}", cargos.Count)
                };

                var columnas = new List<ColumnaReporte>
                {
                    new ColumnaReporte { Titulo = "ID", Ancho = 45f, Derecha = true },
                    new ColumnaReporte { Titulo = "Nombre", Ancho = 150f },
                    new ColumnaReporte { Titulo = "Departamento", Ancho = 150f },
                    new ColumnaReporte { Titulo = "Descripcion", Ancho = 185f }
                };

                var filas = cargos.Select(c => new[]
                {
                    c.CargoID.ToString(),
                    c.Nombre ?? string.Empty,
                    c.Departamento == null ? "N/A" : c.Departamento.Nombre,
                    c.Descripcion ?? string.Empty
                }).ToList();

                GenerarPdfConTabla("Reporte de Cargos", resumen, columnas, filas, rutaPdf, usuarioExportador);
            }
        }

        public void ExportarVacaciones(string rutaPdf, string usuarioExportador = null)
        {
            using (var db = new SiManEmContexto())
            {
                var vacaciones = db.Vacaciones
                    .Include(x => x.Empleado)
                    .AsNoTracking()
                    .OrderByDescending(x => x.FechaInicio)
                    .ToList();

                var resumen = new List<string>
                {
                    "Modulo: Vacaciones",
                    string.Format("Total registros: {0}", vacaciones.Count)
                };

                var columnas = new List<ColumnaReporte>
                {
                    new ColumnaReporte { Titulo = "ID", Ancho = 45f, Derecha = true },
                    new ColumnaReporte { Titulo = "Empleado", Ancho = 180f },
                    new ColumnaReporte { Titulo = "Fecha Inicio", Ancho = 90f },
                    new ColumnaReporte { Titulo = "Fecha Fin", Ancho = 90f },
                    new ColumnaReporte { Titulo = "Estado", Ancho = 130f }
                };

                var filas = vacaciones.Select(v => new[]
                {
                    v.VacacionID.ToString(),
                    v.Empleado == null ? "N/A" : v.Empleado.Nombre,
                    v.FechaInicio.ToString("yyyy-MM-dd"),
                    v.FechaFin.ToString("yyyy-MM-dd"),
                    v.Estado ?? string.Empty
                }).ToList();

                GenerarPdfConTabla("Reporte de Vacaciones", resumen, columnas, filas, rutaPdf, usuarioExportador);
            }
        }

        public void ExportarResumenDashboard(string rutaPdf, string usuarioExportador = null)
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

                var resumen = new List<string>
                {
                    "Resumen General de Dashboard",
                    string.Format("Total empleados: {0}", empleados.Count),
                    string.Format("AFP mensual total: {0:C2}", empleadosActivos.Sum(x => x.AFP)),
                    string.Format("ARS mensual total: {0:C2}", empleadosActivos.Sum(x => x.ARS)),
                    string.Format("ISR mensual total: {0:C2}", empleadosActivos.Sum(x => x.ISR))
                };

                var resumenDepartamentos = empleados
                    .GroupBy(x => x.Departamento == null ? "Sin Departamento" : x.Departamento.Nombre)
                    .Select(g => new
                    {
                        Departamento = g.Key,
                        Cantidad = g.Count(),
                        Activos = g.Count(x => string.Equals(x.Estado, "Activo", StringComparison.OrdinalIgnoreCase)),
                        Nomina = g.Sum(x => x.Salario),
                        Afp = g.Sum(x => x.AFP),
                        Ars = g.Sum(x => x.ARS),
                        Isr = g.Sum(x => x.ISR)
                    })
                    .OrderByDescending(x => x.Cantidad)
                    .ThenBy(x => x.Departamento)
                    .ToList();

                var columnas = new List<ColumnaReporte>
                {
                    new ColumnaReporte { Titulo = "Departamento", Ancho = 130f },
                    new ColumnaReporte { Titulo = "Empleados", Ancho = 60f, Derecha = true },
                    new ColumnaReporte { Titulo = "Activos", Ancho = 50f, Derecha = true },
                    new ColumnaReporte { Titulo = "Nomina", Ancho = 90f, Derecha = true },
                    new ColumnaReporte { Titulo = "AFP", Ancho = 70f, Derecha = true },
                    new ColumnaReporte { Titulo = "ARS", Ancho = 70f, Derecha = true },
                    new ColumnaReporte { Titulo = "ISR", Ancho = 70f, Derecha = true }
                };

                var filas = resumenDepartamentos.Select(r => new[]
                {
                    r.Departamento,
                    r.Cantidad.ToString(),
                    r.Activos.ToString(),
                    r.Nomina.ToString("C2", CulturaRd),
                    r.Afp.ToString("C2", CulturaRd),
                    r.Ars.ToString("C2", CulturaRd),
                    r.Isr.ToString("C2", CulturaRd)
                }).ToList();

                GenerarPdfConTabla("Resumen Dashboard", resumen, columnas, filas, rutaPdf, usuarioExportador);
            }
        }

        public void ExportarUsuarios(string rutaPdf, string usuarioExportador = null)
        {
            using (var db = new SiManEmContexto())
            {
                var usuarios = db.Usuarios
                    .AsNoTracking()
                    .OrderBy(x => x.NombreUsuario)
                    .ToList();

                var resumen = new List<string>
                {
                    "Modulo: Usuarios",
                    string.Format("Total registros: {0}", usuarios.Count)
                };

                var columnas = new List<ColumnaReporte>
                {
                    new ColumnaReporte { Titulo = "ID", Ancho = 60f, Derecha = true },
                    new ColumnaReporte { Titulo = "Nombre Usuario", Ancho = 210f },
                    new ColumnaReporte { Titulo = "Rol", Ancho = 150f },
                    new ColumnaReporte { Titulo = "Estado", Ancho = 145f }
                };

                var filas = usuarios.Select(u => new[]
                {
                    u.UsuarioID.ToString(),
                    u.NombreUsuario ?? string.Empty,
                    u.Rol ?? string.Empty,
                    u.Estado ?? string.Empty
                }).ToList();

                GenerarPdfConTabla("Reporte de Usuarios", resumen, columnas, filas, rutaPdf, usuarioExportador);
            }
        }

        private void GenerarPdfConTabla(string titulo, List<string> resumen, List<ColumnaReporte> columnas, List<string[]> filas, string rutaPdf, string usuarioExportador)
        {
            using (var fs = new FileStream(rutaPdf, FileMode.Create, FileAccess.Write))
            {
                var document = new Document(PageSize.A4, 24f, 24f, 74f, 38f);
                var writer = PdfWriter.GetInstance(document, fs);
                writer.PageEvent = new EventoPaginaReporte(titulo, usuarioExportador);
                document.Open();

                var fuenteResumen = FontFactory.GetFont(FontFactory.HELVETICA, 10, new BaseColor(30, 45, 69));
                foreach (var linea in resumen)
                {
                    var p = new Paragraph(linea, fuenteResumen) { SpacingAfter = 2f };
                    document.Add(p);
                }

                document.Add(new Paragraph(" "));
                var tabla = CrearTabla(columnas, filas);
                document.Add(tabla);

                document.Close();
            }
        }

        private PdfPTable CrearTabla(List<ColumnaReporte> columnas, List<string[]> filas)
        {
            var tabla = new PdfPTable(columnas.Count)
            {
                WidthPercentage = 100f,
                HeaderRows = 1
            };
            tabla.SetWidths(columnas.Select(c => c.Ancho).ToArray());

            var fuenteCabecera = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 9, BaseColor.WHITE);
            var fondoCabecera = new BaseColor(40, 62, 105);
            var bordeCabecera = new BaseColor(21, 36, 63);

            foreach (var col in columnas)
            {
                var celda = new PdfPCell(new Phrase(col.Titulo, fuenteCabecera))
                {
                    BackgroundColor = fondoCabecera,
                    BorderColor = bordeCabecera,
                    PaddingTop = 5f,
                    PaddingBottom = 5f,
                    PaddingLeft = 4f,
                    PaddingRight = 4f,
                    HorizontalAlignment = col.Derecha ? Element.ALIGN_RIGHT : Element.ALIGN_LEFT
                };
                tabla.AddCell(celda);
            }

            var fuenteFila = FontFactory.GetFont(FontFactory.HELVETICA, 9, new BaseColor(30, 45, 69));
            var bordeFila = new BaseColor(198, 208, 224);
            var zebra = new BaseColor(247, 250, 255);

            for (var i = 0; i < filas.Count; i++)
            {
                var fila = filas[i];
                var colorFondo = i % 2 == 0 ? zebra : BaseColor.WHITE;
                for (var c = 0; c < columnas.Count; c++)
                {
                    var texto = c < fila.Length ? fila[c] : string.Empty;
                    var celda = new PdfPCell(new Phrase(texto, fuenteFila))
                    {
                        BackgroundColor = colorFondo,
                        BorderColor = bordeFila,
                        PaddingTop = 4f,
                        PaddingBottom = 4f,
                        PaddingLeft = 4f,
                        PaddingRight = 4f,
                        HorizontalAlignment = columnas[c].Derecha ? Element.ALIGN_RIGHT : Element.ALIGN_LEFT
                    };
                    tabla.AddCell(celda);
                }
            }

            return tabla;
        }
    }
}
