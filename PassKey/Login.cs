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
            login login = new login()
            {
                usuario = txtUsuario.Text,
                password = txtPassword.Text,
            };

            List<login> list = new List<login>();

            list = LoginSession.Instancia.Listar(login);


            if (list.Count == 0)
            {
                MessageBox.Show("Usuario o contraseña son invalidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Inicio inicio = new Inicio();

                inicio.Show();

                this.Hide();

                inicio.FormClosing += frm_closing;
            }

        }



        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            txtUsuario.Text = "";
            txtPassword.Text = "";
            this.Show();
        }
    }
}