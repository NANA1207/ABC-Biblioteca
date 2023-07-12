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
using DAS_Presentacion.ServicioEstudiante;
using DAS_Presentacion.ServicioLibros;
using DAS_Presentacion.ServicioPrestamo;
using DAS_Presentacion.ServicioDetalle;
using DAS_Entidades;

namespace DAS_Presentacion
{
    /// <summary>
    /// Codificación del Inicio y demás módulos.
    /// </summary>
    public partial class FormInicio : Form
    {
        ServicioUsuarioClient usu = new ServicioUsuarioClient();
        ServicioEstudianteClient es = new ServicioEstudianteClient();
        ServicioLibrosClient lib = new ServicioLibrosClient();
        ServicioPrestamoClient pres = new ServicioPrestamoClient();
        ServicioDetalleClient det = new ServicioDetalleClient();

        UsuarioEntidad usuario = new UsuarioEntidad();
        UsuarioEntidad admin = new UsuarioEntidad();
        ServicioEstudiante.EstudianteEntidad estudiante = new ServicioEstudiante.EstudianteEntidad();
        ServicioLibros.LibroEntidad libro = new ServicioLibros.LibroEntidad();
        PrestamoEntidad prestamo = new PrestamoEntidad();
        ServicioDetalle.DetallePrestamoEntidad detalle = new ServicioDetalle.DetallePrestamoEntidad();
        public FormInicio()
        {
            InitializeComponent();
            admin = MetodosPresentacion.obtenerUsuiario();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            MetodosPresentacion.enviarId(usuario.CED_USU);
            
            MetodosPresentacion.enviarEstado(false);
            MetodosPresentacion.enviarTitulo("Ver Usuario");
            FormVerUsuario fvu = new FormVerUsuario();
            fvu.Show();
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevoUsuarios_Click(object sender, EventArgs e)
        {
            MetodosPresentacion.enviarId(" ");
            MetodosPresentacion.enviarEstado(true);
            MetodosPresentacion.enviarTitulo("Nuevo Usuario");
            FormVerUsuario fvu = new FormVerUsuario();
            fvu.Show();
   
        }

        private void BTNVerClientes_Click(object sender, EventArgs e)
        {
            MetodosPresentacion.enviarId(estudiante.CED_EST);
            MetodosPresentacion.enviarEstado(false);
            FormVerEstudiante fvc = new FormVerEstudiante();
            fvc.Show();
        }

        private void btnVerLibros_Click(object sender, EventArgs e)
        {
            MetodosPresentacion.enviarId(libro.ID_LIB);
            MetodosPresentacion.enviarEstado(false);
            MetodosPresentacion.enviarTitulo("Ver Libro");
            FormVerLibro fvl = new FormVerLibro();
            fvl.Show();
        }

        private void btnNuevoLibro_Click(object sender, EventArgs e)
        {
            MetodosPresentacion.enviarId(" ");
            MetodosPresentacion.enviarEstado(true);
            MetodosPresentacion.enviarTitulo("Nuevo Libro");
            FormVerLibro fvl = new FormVerLibro();
            fvl.Show();
        }

        private void btnVerPrestamo_Click(object sender, EventArgs e)
        {
            string id = Convert.ToString(prestamo.ID_PRES);
            MetodosPresentacion.enviarId(id);
            FormPrestamos fvp = new FormPrestamos();
            fvp.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        /// <summary>
        /// Carga los grid con los datos respectivos.
        /// </summary>
        private void FormInicio_Load(object sender, EventArgs e)
        {
            dataGridViewUsuarios.DataSource = usu.obtenerUsuarios();
            dataGridClientes.DataSource = es.ObtenerEstudiantes();
            dataGridViewLibros.DataSource = lib.ObtenerLibros();
            dataGridViewPrestamo.DataSource = pres.obtenerPrestamos();
            cargarDatosAdmin();
        }

        /// <summary>
        /// Selecciona el Usuario del grid
        /// </summary>
       
        private void dataGridViewUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //buttonVerRepartidor.Enabled = true;
            var filaSeleccionada = dataGridViewUsuarios.CurrentRow;
            if (filaSeleccionada != null && !filaSeleccionada.Cells[0].Value.ToString().Equals(""))
            {
                string id = Convert.ToString(filaSeleccionada.Cells[0].Value);
                usuario = usu.obtenerUsuarioID(id);
            }
        }
        /// <summary>
        /// Selecciona el EStudiante del grid
        /// </summary>
        private void dataGridClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var filaSeleccionada = dataGridClientes.CurrentRow;
            if (filaSeleccionada != null && !filaSeleccionada.Cells[3].Value.ToString().Equals(""))

            {

                string id = Convert.ToString(filaSeleccionada.Cells[3].Value);
                estudiante =  es.ObtenerEstudianteID(id);
            }
        }
        /// <summary>
        /// Selecciona el Libro del grid
        /// </summary>
        private void dataGridViewLibros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var filaSeleccionada = dataGridViewLibros.CurrentRow;
            if (filaSeleccionada != null && !filaSeleccionada.Cells[7].Value.ToString().Equals(""))

            {

                string id = Convert.ToString(filaSeleccionada.Cells[7].Value);
                libro = lib.ObtenerLibroID(id);
            }
        }
        /// <summary>
        /// Selecciona el Préstamo del grid
        /// </summary>
        private void dataGridViewPrestamo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var filaSeleccionada = dataGridViewPrestamo.CurrentRow;
            if (filaSeleccionada != null && !filaSeleccionada.Cells[0].Value.ToString().Equals(""))

            {

                int id = Convert.ToInt32(filaSeleccionada.Cells[0].Value);
                prestamo = pres.obtenerPrestamoID(id);
                
            }
        }

        /// <summary>
        /// Genera ´varias búsquedas para ser convocadas en la parte del código correspondiente.
        /// 1. Busca usuario por cédula
        /// 2. Busca estudiante por cédula
        /// 3. Busca libro por nombre
        /// 4. Busca préstamo por CI de estudiante
        /// 5. Ve el estado del préstamo.
        /// </summary>
        /// <param name="num"> Numero de 1-5 para la busqueda respectiva</param>
        /// <param name="id">Parámetro de búsqueda.</param>
        void buscar(int num, string id)
        {
            switch (num)
            {
                //busca por cedula el usuario
                case 1:
                    dataGridViewUsuarios.DataSource = usu.buscar(id,1);
                    break;
                //busca por cedula el estudiante
                case 2:
                    dataGridClientes.DataSource = es.buscar(id,1);
                    break;
                //busca por nombre el libro
                case 3:
                    dataGridViewLibros.DataSource = lib.buscar(id,4);
                    break;
                //busca por cedula el prestamo
                case 4:
                    dataGridViewPrestamo.DataSource = pres.buscar(id,3);
                    break;
                    //estado de prestamo
                case 5:
                    dataGridViewPrestamo.DataSource = pres.buscar(id, 1);
                    break;
            }
        }

        private void btnBorrarBusqueda_Click(object sender, EventArgs e)
        {
            dataGridViewUsuarios.DataSource = usu.obtenerUsuarios();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridClientes.DataSource = es.ObtenerEstudiantes();
            
        }

        private void btnEliminarBusquedaLibro_Click(object sender, EventArgs e)
        {
            dataGridViewLibros.DataSource = lib.ObtenerLibros();
            
        }

        private void btnBorrarBusuqedaPrestamo_Click(object sender, EventArgs e)
        {
            dataGridViewPrestamo.DataSource = pres.obtenerPrestamos();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dataGridViewPrestamo.DataSource = pres.obtenerPrestamos();
        }

        private void btnVerPendientes_Click(object sender, EventArgs e)
        {
            buscar(5, "Pendiente");
        }

        private void btnEliminarLibro_Click(object sender, EventArgs e)
        {
            lib.delete(libro);
            dataGridViewLibros.DataSource = lib.ObtenerLibros();
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            usu.delete(usuario);
            dataGridViewUsuarios.DataSource = usu.obtenerUsuarios();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            
            actualizarAdmin();
            MessageBox.Show("Datos actualizados");
        }
        /// <summary>
        /// Carga los datos del usuario logueado en la parte de inicio
        /// </summary>
        void cargarDatosAdmin()
        {
            txtNombre.Text = admin.NOM_USU;
            txtApellido.Text = admin.APE_USU;
            txtEmail.Text = admin.EMAIL_USU;
            txtTelefono.Text = admin.TEL_USU;
            txtContrasena.Text = admin.CONTRA_USU;
            txtEstado.Text = admin.ESTADO_USU;
            txtSexo.Text = admin.SEXO_USU;
            txtTipo.Text = admin.TIPO_USU;
        }
        /// <summary>
        /// Actualiza la información del Admin
        /// </summary>
        void actualizarAdmin()
        {
            admin.NOM_USU = txtNombre.Text;
            admin.APE_USU = txtApellido.Text;
            admin.EMAIL_USU=txtEmail.Text;
            admin.TEL_USU=txtTelefono.Text ;
            admin.CONTRA_USU=txtContrasena.Text;
            admin.ESTADO_USU= txtEstado.Text;
            admin.SEXO_USU= txtSexo.Text;
            admin.TIPO_USU=txtTipo.Text;
            admin.FEC_ING_SIS = DateTime.Now;
            usu.edit(admin);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            dataGridViewUsuarios.DataSource = usu.obtenerUsuarios();
            dataGridClientes.DataSource = es.ObtenerEstudiantes();
            dataGridViewLibros.DataSource = lib.ObtenerLibros();
            dataGridViewPrestamo.DataSource = pres.obtenerPrestamos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar(1, txtBuscarUsuario.Text);
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            buscar(2, txtBuscarCliente.Text);
        }

        private void btnLibros_Click(object sender, EventArgs e)
        {
            buscar(3, txtBuscarLibros.Text);
        }

        private void btnBuscarPres_Click(object sender, EventArgs e)
        {
            buscar(4, txtBuscarPrestamo.Text);
        }

        private void txtSalir_Click(object sender, EventArgs e)
        {   
            Form1 sal = new Form1();
            this.Hide();
            sal.Show();
        }

        private void dataGridViewPrestamo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
