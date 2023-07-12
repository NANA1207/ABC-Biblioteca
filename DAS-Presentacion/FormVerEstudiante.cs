using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAS_Presentacion.ServicioEstudiante;

namespace DAS_Presentacion
{
    /// <summary>
    /// Codificación de la visualización de la información del estudiante.
    /// </summary>
    public partial class FormVerEstudiante : Form
    {
        ServicioEstudianteClient es = new ServicioEstudianteClient();
        ServicioEstudiante.EstudianteEntidad estudiante = new ServicioEstudiante.EstudianteEntidad();
        public FormVerEstudiante()
        {
            InitializeComponent();
            if (!MetodosPresentacion.obtenerEstado())
            {
                
                txtCedula.Enabled = false;
                txtMatricula.Enabled = false;
            }
            
        }

        private void btnGuardarEstudiante_Click(object sender, EventArgs e)
        {
            guardarEstudiante();
            this.Hide();
        }

        private void btnCancelarEstudiante_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        /// <summary>
        /// Carga la información del estudiante seleccionado del grid
        /// </summary>
        void cargarEstudiante()
        {
            
            string id = MetodosPresentacion.obtenerId();
            estudiante = es.ObtenerEstudianteID(id);
            txtCedula.Text = estudiante.CED_EST;
            txtNombre.Text = estudiante.NOM1_EST;
            txtNombre2.Text = estudiante.NOM2_EST;
            txtApellido.Text = estudiante.APE1_EST;
            txtApellido2.Text = estudiante.APE2_EST;
            dateTimePickerFechaNacimiento.Value = estudiante.FEC_NAC_EST;
            textBoxDireccion.Text = estudiante.DIR_EST;
            txtEmail.Text = estudiante.EMAIL_EST;
            txtMatricula.Text = Convert.ToString(estudiante.NUM_MAT_EST);
            txtRepre.Text = estudiante.CEL_REPRESENTANTE_EST;
            textLibros.Text = Convert.ToString(estudiante.CANT_LIBROS);


        }
        /// <summary>
        /// Edita un estudiante
        /// </summary>
        void guardarEstudiante()
        {
            string id = MetodosPresentacion.obtenerId();
            estudiante = es.ObtenerEstudianteID(id);
            estudiante.CED_EST = txtCedula.Text;
            estudiante.NOM1_EST =txtNombre.Text;
            estudiante.NOM2_EST=txtNombre2.Text ;
            estudiante.APE1_EST=txtApellido.Text ;
            estudiante.APE2_EST=txtApellido2.Text ;
            estudiante.FEC_NAC_EST=dateTimePickerFechaNacimiento.Value;
            estudiante.DIR_EST=textBoxDireccion.Text ;
            estudiante.EMAIL_EST=txtEmail.Text ;
            estudiante.NUM_MAT_EST=Convert.ToInt32(txtMatricula.Text);
            estudiante.CEL_REPRESENTANTE_EST=txtRepre.Text;
            estudiante.CANT_LIBROS=Convert.ToInt32(textLibros.Text );
            estudiante.FEC_ING_SISTEMA_EST = estudiante.FEC_ING_SISTEMA_EST;
            es.edit(estudiante);

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void FormVerEstudiante_Load(object sender, EventArgs e)
        {
            cargarEstudiante();
        }
    }
}
