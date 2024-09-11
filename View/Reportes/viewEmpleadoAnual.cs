using SistemaVentaAkira.Controller.Reporte;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentaAkira.View.Reportes
{
    public partial class viewEmpleadoAnual : Form
    {
        public int anio;
        public viewEmpleadoAnual()
        {
            InitializeComponent();
        }

        private void viewEmpleadoAnual_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            ObtenerEmpleados(); 
        }

        private void ObtenerEmpleados()
        {
            ReporteEmpleados empleados = new ReporteEmpleados();
            empleados.CrearListaEmpleadoAnual(anio);
            this.reporteEmpleadosBindingSource.DataSource = empleados.listaEmpleadoAnual;
            this.reportViewer1.RefreshReport();
        }
    }
}
