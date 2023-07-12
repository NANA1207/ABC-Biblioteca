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
    /// Codificación del Login de la aplicación
    /// </summary>
    public partial class Form1 : Form
    {
        ServicioUsuarioClient usu = new ServicioUsuarioClient();
        UsuarioEntidad usuario = new UsuarioEntidad();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            
            ingresar();
        }

        /// <summary>
        /// Codigo para ingresar al Sistema mediante el uso del servicio Login
        /// Solo ingresará si tiene credenciales correctas.
        /// </summary>
        void ingresar()
        {
            string user = txtUsuario.Text;
            string contra = txtContrasena.Text;
            if (user.Equals("") || contra.Equals(""))
            {
                MessageBox.Show("Llenar todos los campos");
            }
            else
            {
                usuario= usu.login(user,contra);
                if (usuario.TIPO_USU!= "A")
                {
                    MessageBox.Show(this, "Datos Incorrectos", "Datos Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MetodosPresentacion.enviarUsuario(usuario);
                    FormInicio finicio = new FormInicio();
                    this.Hide();
                    finicio.Show();
                }
            }
        }

        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
