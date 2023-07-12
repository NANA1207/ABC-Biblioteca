using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAS_Presentacion.ServicioUsuario;
using DAS_Entidades;

namespace DAS_Presentacion
{
    /// <summary>
    /// Codificacion de la parte de la información del usuario.
    /// </summary>
    public partial class FormVerUsuario : Form
    {
        ServicioUsuarioClient usu = new ServicioUsuarioClient();
        UsuarioEntidad usuario = new UsuarioEntidad();
        public FormVerUsuario()
        {

            InitializeComponent();
            label1.Text = MetodosPresentacion.obtenerTitulo();
            if (!MetodosPresentacion.obtenerEstado())
            {
                txtCedula.Enabled = false;
                

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Se asegura de que el dato sea nuevo para ingresarlo, caso contrario lo edita.
        /// </summary>
    
        private void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            if (!MetodosPresentacion.obtenerEstado())
            {
                editarUsuario();
            }
            else
            {
                guardarUsuario();
            }
                this.Hide();
        }

        private void btnCancelarUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        /// <summary>
        /// Carga los datos del Usuario seleccionado del grid.
        /// </summary>
        void cargarUsuario()
        {
            string id = MetodosPresentacion.obtenerId();
            usuario = usu.obtenerUsuarioID(id);
            txtCedula.Text = usuario.CED_USU;
            txtNombre.Text = usuario.NOM_USU;
            txtApellido.Text = usuario.APE_USU;
            txtEmail.Text = usuario.EMAIL_USU;
            txtTelefono.Text = usuario.TEL_USU;
            txtContrasena.Text = usuario.CONTRA_USU;
            txtEstado.Text = usuario.ESTADO_USU;
            txtSexo.Text = usuario.SEXO_USU;
            txtTipo.Text = usuario.TIPO_USU;
        }
        /// <summary>
        /// guarda un nuevo usuario
        /// </summary>
        void guardarUsuario()
        {


            usuario.CED_USU=txtCedula.Text;
            usuario.NOM_USU=txtNombre.Text ;
            usuario.APE_USU=txtApellido.Text;
            usuario.EMAIL_USU=txtEmail.Text;
            usuario.TEL_USU=txtTelefono.Text;
            usuario.CONTRA_USU=txtContrasena.Text;
            usuario.ESTADO_USU=txtEstado.Text ;
            usuario.SEXO_USU=txtSexo.Text;
            usuario.TIPO_USU=txtTipo.Text;
            usuario.FEC_ING_SIS = DateTime.Now;
            usu.add(usuario);
        }
        /// <summary>
        /// edita el uduario seleccionado
        /// </summary>
        void editarUsuario()
        {

            string id = MetodosPresentacion.obtenerId();
            usuario = usu.obtenerUsuarioID(id);
            usuario.CED_USU = txtCedula.Text;
            usuario.NOM_USU = txtNombre.Text;
            usuario.APE_USU = txtApellido.Text;
            usuario.EMAIL_USU = txtEmail.Text;
            usuario.TEL_USU = txtTelefono.Text;
            usuario.CONTRA_USU = txtContrasena.Text;
            usuario.ESTADO_USU = txtEstado.Text;
            usuario.SEXO_USU = txtSexo.Text;
            usuario.TIPO_USU = txtTipo.Text;
            usuario.FEC_ING_SIS = DateTime.Now;
            usu.edit(usuario);
        }

        private void FormVerUsuario_Load(object sender, EventArgs e)
        {
            if (!MetodosPresentacion.obtenerEstado())
            {
                cargarUsuario();
            }
        }
    }
}
