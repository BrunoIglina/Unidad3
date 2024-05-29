using System.Collections.Generic;

namespace AcademiaABM
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void tlAlumnos_Paint(object sender, PaintEventArgs e)
        {

        }
        public class Usuario
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public string Sesion { get; set; }
            public string Email { get; set; }
            public string Estado { get; set; }



            public Usuario(int id, string nombre, string email, string apellido, string sesion, string estado)
            {
                Id = id;
                Nombre = nombre;
                Apellido = apellido;
                Sesion = sesion;
                Email = email;
                Estado = estado;

            }
        }

        public void Listar()
        {
            List<Usuario> usuarios = new List<Usuario>;
            new Usuario(123, "Juan", "Perez", "Juan123", "juanperez@gmail.com", "habilitado");
            new Usuario(456, "Juana", "Lopez", "Juana456", "juanalopez@gmail.com", "habilitado");
            new Usuario(789, "Juan", "Gonzales", "Juan789", "juangonzales@gmail.com", "habilitado");

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
