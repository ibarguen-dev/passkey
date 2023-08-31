using PassKey.Logica;
using PassKey.Modelo;
namespace PassKey
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // se verifica si el usuario puso la clave de restablecimiento
            if (txtUsuario.Text == "admin" && txtPassword.Text == "admin")
            {
                // se verifica si el restableciemto fue verdadero
                if (LoginSession.Instancia.restablecer())
                {
                    // se crea un mensaje que le indica el usuario que la restblecimento fue bueno
                    MessageBox.Show("La contraseña se a restablecido", "informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // se crea un mensaje donde se indica que hubo un error en el restablecimiento
                    MessageBox.Show("La hubo un error al momento de restablecer la contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // se crea un objecto donde se agrega el usuario y contraseña
                login login = new login()
                {
                    usuario = txtUsuario.Text,
                    password = txtPassword.Text,
                };

                // se crea un objecto lista
                List<login> list = new List<login>();

                // se recibe una lista de usuario
                list = LoginSession.Instancia.Listar(login);

                // se verifica que la lista es igual a cerp
                if (list.Count == 0)
                {
                    // se indica al usuario o la contraseña no son validos
                    MessageBox.Show("Usuario o contraseña son invalidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // se crea un objecto de el formulario inicio
                    Inicio inicio = new Inicio();

                    // se abre el formulario de inicio
                    inicio.Show();

                    //se esconde le formulario de login
                    this.Hide();
                    // se crea un objecto de que si cierra el formulario de inicio
                    inicio.FormClosing += frm_closing;
                }
            }

        }


        // se crea un funcion de tipo cierre 
        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            txtUsuario.Text = "";
            txtPassword.Text = "";
            this.Show();
        }
    }
}