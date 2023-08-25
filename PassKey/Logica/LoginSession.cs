﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PassKey.Modelo;
using System.Data.SQLite;
namespace PassKey.Logica
{
    public class LoginSession
    {

        string connectionString = @"Data Source=../Password.db;";
        private static LoginSession _instancia = null;

        public LoginSession() { }

        public static LoginSession Instancia
        {
            get
            {
                if (_instancia == null) {

                    _instancia = new LoginSession();

                }

                return _instancia;
            }
        }

        public List<login> Listar(login obj) {

            List<login> olista = new List<login>();
            bool respuesta = true; 

            using (SQLiteConnection conexion = new SQLiteConnection(connectionString))
            {
 

                try
                {
                    conexion.Open();
                    string query = "select * from Usuario WHERE (Nombre = @Nombre and Password = @Password)";

                    SQLiteCommand cmd = new SQLiteCommand(query,conexion);

                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SQLiteDataReader dr  = cmd.ExecuteReader()) {

                        while (dr.Read())
                        {
          
                            olista.Add(new login()
          
                            {
              
                                usuario = dr["Nombre"].ToString(),
              
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
    }
}
