using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PassKey.Modelo;
using System.Data.SQLite;
namespace PassKey.Logica
{
    public class Password
    {
        string connectionString = @"Data Source=../Password.db;";
        private static Password _instancia = null;

        public Password() { }

        public static Password Instancia
        {
            get
            {
                if (_instancia == null)
                {

                    _instancia = new Password();

                }

                return _instancia;
            }
        }

        public List<usuarios> list()
        {
            List<usuarios> olista = new List<usuarios>();

            using (SQLiteConnection conexion = new SQLiteConnection(connectionString))
            {


                try
                {
                    conexion.Open();
                    string query = "select * from Password";

                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                    cmd.CommandType = System.Data.CommandType.Text;
                    using (SQLiteDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read())
                        {

                            olista.Add(new usuarios()

                            {
                                id = Convert.ToInt32( dr["id"]),

                                sitio = dr["Sitioweb"].ToString(),

                                correo = dr["Correo"].ToString(),

                                password = dr["Password"].ToString()

                            });
                        }
                    }
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Error de conexión: " + ex.Message);
                }
            }

            return olista;
        }

        public bool add(usuarios obj)
        {

            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(connectionString))
            {


                try
                {
                    conexion.Open();
                    string query = "INSERT INTO Password (Sitioweb,Correo,Password) VALUES(@Sitioweb,@Correo,@Password)";

                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                    
                    cmd.CommandType = System.Data.CommandType.Text;

                    cmd.Parameters.Add(new SQLiteParameter("@Sitioweb",obj.sitio));

                    cmd.Parameters.Add(new SQLiteParameter("@Correo",obj.correo));

                    cmd.Parameters.Add(new SQLiteParameter("@Password",obj.password));

                    if(cmd.ExecuteNonQuery() < 1)
                    {
                        respuesta = false;
                    }
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Error de conexión: " + ex.Message);
                }
            }
            return respuesta;
        }

        public bool edit(usuarios obj)
        {

            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(connectionString))
            {


                try
                {
                    conexion.Open();
                    string query = "UPDATE Password SET Sitioweb = @Sitioweb, Correo = @Correo, Password = @Password WHERE id = @id)";

                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                    cmd.CommandType = System.Data.CommandType.Text;

                    cmd.Parameters.Add(new SQLiteParameter("@Sitioweb", obj.sitio));

                    cmd.Parameters.Add(new SQLiteParameter("@Correo", obj.correo));

                    cmd.Parameters.Add(new SQLiteParameter("@Password", obj.password));

                    cmd.Parameters.Add(new SQLiteParameter("@id", obj.id));

                    if (cmd.ExecuteNonQuery() < 1)
                    {
                        respuesta = false;
                    }
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Error de conexión: " + ex.Message);
                }
            }
            return respuesta;
        }


        public bool delete(string obj)
        {

            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(connectionString))
            {


                try
                {
                    conexion.Open();
                    string query = "DELETE FROM Password WHERE id = @id)";

                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                    cmd.CommandType = System.Data.CommandType.Text;

                    cmd.Parameters.Add(new SQLiteParameter("@id", obj));


                    if (cmd.ExecuteNonQuery() < 1)
                    {
                        respuesta = false;
                    }
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Error de conexión: " + ex.Message);
                }
            }
            return respuesta;
        }
    }
}
