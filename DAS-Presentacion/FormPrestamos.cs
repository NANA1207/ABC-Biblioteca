using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAS_Presentacion.ServicioDetalle;
using DAS_Presentacion.ServicioPrestamo;
namespace DAS_Presentacion
{
    /// <summary>
    /// Codificación de el detalle del préstamoo.
    /// </summary>
    public partial class FormPrestamos : Form
    {
        ServicioDetalleClient det = new ServicioDetalleClient();

        public FormPrestamos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        /// <summary>
        /// Busca los libros del préstamo seleccionado.
        /// </summary>
        
        private void FormPrestamos_Load(object sender, EventArgs e)
        {
            string id = (MetodosPresentacion.obtenerId());
            dataGridViewPrestamo.DataSource = det.buscar(id,3);
        }
    }
}
