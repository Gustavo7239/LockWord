using System;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;
using System.IO;
using System.Windows.Forms;

public class SQLiteHelper
{
    private string connectionString;
    public static String pathImages = Path.Combine(Application.StartupPath, "Images");

    public SQLiteHelper(string dbFilePath)
    {
        connectionString = $"Data Source={dbFilePath};";
    }

    // Métodos generales

    public void ExecuteNonQuery(string query)
    {
        using (SqliteConnection connection = new SqliteConnection(connectionString))
        {
            connection.Open();
            using (SqliteCommand command = new SqliteCommand(query, connection))
            {
                command.ExecuteNonQuery();
            }
            connection.Close();
        }
    }

    public object ExecuteScalar(string query)
    {
        object result = null;
        using (SqliteConnection connection = new SqliteConnection(connectionString))
        {
            connection.Open();
            using (SqliteCommand command = new SqliteCommand(query, connection))
            {
                result = command.ExecuteScalar();
            }
            connection.Close();
        }
        return result;
    }

    // CRUD para Cuenta

    public List<Cuenta> GetAllCuentas()
    {
        List<Cuenta> cuentas = new List<Cuenta>();
        using (SqliteConnection connection = new SqliteConnection(connectionString))
        {
            connection.Open();
            string selectAllQuery = "SELECT * FROM Cuenta";
            using (SqliteCommand command = new SqliteCommand(selectAllQuery, connection))
            {
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Cuenta cuenta = new Cuenta
                        {
                            ID = reader.GetInt32(0),
                            WebSiteID = reader.GetInt32(3),
                            Correo = reader.GetString(1),
                            Contraseña = reader.GetString(2)
                        };
                        cuentas.Add(cuenta);
                    }
                }
            }
            connection.Close();
        }
        return cuentas;
    }

    public void AddCuenta(Cuenta cuenta)
    {
        using (SqliteConnection connection = new SqliteConnection(connectionString))
        {
            connection.Open();
            string insertQuery = $"INSERT INTO Cuenta (Correo, Contraseña, WebSiteID) VALUES (@Correo, @Contraseña, @WebSiteID)";
            using (SqliteCommand command = new SqliteCommand(insertQuery, connection))
            {
                command.Parameters.AddWithValue("@Correo", cuenta.Correo);
                command.Parameters.AddWithValue("@Contraseña", cuenta.Contraseña);
                command.Parameters.AddWithValue("@WebSiteID", cuenta.WebSiteID);
                command.ExecuteNonQuery();
            }
            connection.Close();
        }
    }

    public void UpdateCuenta(Cuenta cuenta)
    {
        using (SqliteConnection connection = new SqliteConnection(connectionString))
        {
            connection.Open();
            string updateQuery = $"UPDATE Cuenta SET Correo = @Correo, Contraseña = @Contraseña, WebSiteID = @WebSiteID WHERE ID = @ID";
            using (SqliteCommand command = new SqliteCommand(updateQuery, connection))
            {
                command.Parameters.AddWithValue("@Correo", cuenta.Correo);
                command.Parameters.AddWithValue("@Contraseña", cuenta.Contraseña);
                command.Parameters.AddWithValue("@WebSiteID", cuenta.WebSiteID);
                command.Parameters.AddWithValue("@ID", cuenta.ID);
                command.ExecuteNonQuery();
            }
            connection.Close();
        }
    }

    public void DeleteCuenta(int cuentaID)
    {
        using (SqliteConnection connection = new SqliteConnection(connectionString))
        {
            connection.Open();
            string deleteQuery = $"DELETE FROM Cuenta WHERE ID = @ID";
            using (SqliteCommand command = new SqliteCommand(deleteQuery, connection))
            {
                command.Parameters.AddWithValue("@ID", cuentaID);
                command.ExecuteNonQuery();
            }
            connection.Close();
        }
    }

    // CRUD para WebSite

    public List<WebSite> GetAllWebSites()
    {
        List<WebSite> webSites = new List<WebSite>();
        using (SqliteConnection connection = new SqliteConnection(connectionString))
        {
            connection.Open();
            string selectAllQuery = "SELECT * FROM WebSite";
            using (SqliteCommand command = new SqliteCommand(selectAllQuery, connection))
            {
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        WebSite webSite = new WebSite
                        {
                            ID = reader.GetInt32(0),
                            WebName = reader.GetString(1),
                            Enlace = reader.GetString(2),
                            RutaImagen = reader.GetString(3),
                            Descripcion = reader.GetString(4)
                        };
                        webSites.Add(webSite);
                    }
                }
            }
            connection.Close();
        }
        return webSites;
    }

    public void AddWebSite(WebSite webSite)
    {
        using (SqliteConnection connection = new SqliteConnection(connectionString))
        {
            connection.Open();
            string insertQuery = $"INSERT INTO WebSite (WebName, Enlace, RutaImagen, Descripcion) VALUES (@WebName, @Enlace, @RutaImagen, @Descripcion)";
            using (SqliteCommand command = new SqliteCommand(insertQuery, connection))
            {
                command.Parameters.AddWithValue("@WebName", webSite.WebName);
                command.Parameters.AddWithValue("@Enlace", webSite.Enlace);
                command.Parameters.AddWithValue("@RutaImagen", webSite.RutaImagen);
                command.Parameters.AddWithValue("@Descripcion", webSite.Descripcion);
                command.ExecuteNonQuery();
            }
            connection.Close();
        }
    }

    public void UpdateWebSite(WebSite webSite)
    {
        using (SqliteConnection connection = new SqliteConnection(connectionString))
        {
            connection.Open();
            string updateQuery = $"UPDATE WebSite SET WebName = @WebName, Enlace = @Enlace, RutaImagen = @RutaImagen, Descripcion = @Descripcion WHERE ID = @ID";
            using (SqliteCommand command = new SqliteCommand(updateQuery, connection))
            {
                command.Parameters.AddWithValue("@WebName", webSite.WebName);
                command.Parameters.AddWithValue("@Enlace", webSite.Enlace);
                command.Parameters.AddWithValue("@RutaImagen", webSite.RutaImagen);
                command.Parameters.AddWithValue("@Descripcion", webSite.Descripcion);
                command.Parameters.AddWithValue("@ID", webSite.ID);
                command.ExecuteNonQuery();
            }
            connection.Close();
        }
    }

    public void DeleteWebSite(int webSiteID)
    {
        using (SqliteConnection connection = new SqliteConnection(connectionString))
        {
            connection.Open();
            string deleteQuery = $"DELETE FROM WebSite WHERE ID = @ID";
            using (SqliteCommand command = new SqliteCommand(deleteQuery, connection))
            {
                command.Parameters.AddWithValue("@ID", webSiteID);
                command.ExecuteNonQuery();
            }
            connection.Close();
        }
    }

    public class Cuenta
    {
        public int ID { get; set; }
        public int WebSiteID { get; set; }
        public string Correo { get; set; }
        public string Contraseña { get; set; }
    }

    public class WebSite
    {
        public int ID { get; set; }
        public string WebName { get; set; }
        public string Enlace { get; set; }
        public string RutaImagen { get; set; }
        public string Descripcion { get; set; }
    }
}
