using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAS_Presentacion.ServicioLibros;

namespace DAS_Presentacion
{
    /// <summary>
    /// Codificación de la visualización de la información de los libros
    /// </summary>
    public partial class FormVerLibro : Form
    {
        ServicioLibrosClient lib = new ServicioLibrosClient();
        LibroEntidad libro = new LibroEntidad();
        public FormVerLibro()
        {
            InitializeComponent();
            label1.Text = MetodosPresentacion.obtenerTitulo();
            if (!MetodosPresentacion.obtenerEstado())
            {
                txtID.Enabled = false;
                txtDisponibilidad.Enabled = false;
                
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Para guardar la información se asegura si se debe esditar o guardad un nuevo libro.
        /// </summary>
        
        private void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            if (!MetodosPresentacion.obtenerEstado())
            {
                editarLibros();
            }
            else
            {
                guardarLibros();
            }
                this.Hide();
        }

        private void btnCancelarUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        /// <summary>
        /// Carga la información del libro seleccionado en el grid.
        /// </summary>
        void cargarLibro()
        {
            string id = MetodosPresentacion.obtenerId();
            libro = lib.ObtenerLibroID(id);
            txtID.Text = libro.ID_LIB;
            txtTitulo.Text = libro.TITULO_LIB;
            txtAutor.Text = libro.AUTOR_LIB;
            txtEditorial.Text = libro.EDITORIAL_LIB;
            dateTimePickerEdicion.Value = libro.FECHA_EDI_LIB;
            txtNumEdicion.Text = Convert.ToString(libro.NUM_EDI_LIB);
            txtDisponibilidad.Text = libro.DISPONIBILIDAD;
            txtEstanteria.Text = libro.ESTANTERIA;
            txtFila.Text = libro.FILA;
            txtIngreso.Text = Convert.ToString(libro.USU_ING_LIBRO);

        }
        /// <summary>
        /// Guarda un nuevo libro
        /// </summary>
        void guardarLibros()
        {

            libro.ID_LIB=txtID.Text;
            libro.TITULO_LIB=txtTitulo.Text;
            libro.AUTOR_LIB=txtAutor.Text ;
            libro.EDITORIAL_LIB=txtEditorial.Text;
            libro.FECHA_EDI_LIB=dateTimePickerEdicion.Value;
            libro.NUM_EDI_LIB=Convert.ToInt32(txtNumEdicion.Text);
            libro.DISPONIBILIDAD=txtDisponibilidad.Text ;
            libro.ESTANTERIA=txtEstanteria.Text;
            libro.FILA=txtFila.Text ;
            libro.USU_ING_LIBRO=txtIngreso.Text;
            libro.FEC_ING_SIS = DateTime.Now;
            lib.add(libro);
        }
        /// <summary>
        /// Edita el libro seleccionado del grid
        /// </summary>
        void editarLibros()
        {
            string id = MetodosPresentacion.obtenerId();
            libro = lib.ObtenerLibroID(id);
            libro.ID_LIB = txtID.Text;
            libro.TITULO_LIB = txtTitulo.Text;
            libro.AUTOR_LIB = txtAutor.Text;
            libro.EDITORIAL_LIB = txtEditorial.Text;
            libro.FECHA_EDI_LIB = dateTimePickerEdicion.Value;
            libro.NUM_EDI_LIB = Convert.ToInt32(txtNumEdicion.Text);
            libro.DISPONIBILIDAD = txtDisponibilidad.Text;
            libro.ESTANTERIA = txtEstanteria.Text;
            libro.FILA = txtFila.Text;
            libro.USU_ING_LIBRO = txtIngreso.Text;
            libro.FEC_ING_SIS = libro.FEC_ING_SIS;
            lib.edit(libro);
        }

        private void FormVerLibro_Load(object sender, EventArgs e)
        {
            if (!MetodosPresentacion.obtenerEstado())
            {
                cargarLibro();
            }
        }
    }
}
