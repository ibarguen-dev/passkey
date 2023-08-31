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
    public partial class Inicio : Form
    {

        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            mostrar();


        }

        private string guardar()
        {
            string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZÑabcdefghijklmnopqrstuvwxyzñ0123456789@$#%&/()=";

            var Charsarr = new char[16];

            Random random = new Random();

            for (int i = 0; i < Charsarr.Length; i++)
            {
                Charsarr[i] = characters[random.Next(characters.Length)];

            }

            string resultString = new string(Charsarr);

            return resultString;
        }



        private void mostrar()
        {
            DGVPassword.DataSource = null;
            DGVPassword.DataSource = Password.Instancia.list();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string pass = guardar();

            usuarios usuarios = new usuarios()
            {
                sitio = txtWeb.Text,
                correo = txtCorreo.Text,
                password = pass
            };

            bool respuesta = Password.Instancia.add(usuarios);
            limpiar();
            if (respuesta)
            {
                mostrar();
            }
        }

        public void limpiar()
        {
            txtWeb.Text = "";
            txtCorreo.Text = "";
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            string pass = guardar();

            usuarios usuarios = new usuarios()
            {
                id = Convert.ToInt32(txtId.Text),
                sitio = txtWeb.Text,
                correo = txtCorreo.Text,
                password = pass
            };

            bool respuesta = Password.Instancia.edit(usuarios);
            limpiar();
            if (respuesta)
            {
                mostrar();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            usuarios usuario = new usuarios()
            {
                id = Convert.ToInt32(txtId.Text)
            };

            bool respuesta = Password.Instancia.delete(txtId.Text);
            limpiar();
            if (respuesta)
            {
                mostrar();
            }
        }


        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cambio cambio = new cambio();

            cambio.Show();
        }

    }
}
