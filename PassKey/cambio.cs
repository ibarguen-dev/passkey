using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PassKey.Logica;
using PassKey.Modelo;
namespace PassKey
{
    public partial class cambio : Form
    {
        public cambio()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            login login = new login()
            {
                usuario = txtUsuario.Text,
                password = txtPassword.Text,
            };

            if (LoginSession.Instancia.edit(login))
            {
                MessageBox.Show("Contrase actualizada");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al actualizar la contraseña");
            }
        }
    }
}
