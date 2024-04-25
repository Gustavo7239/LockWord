using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;

public class SQLiteHelper
{
    private string connectionString;

    public SQLiteHelper(string dbFilePath)
    {
        connectionString = $"Data Source={dbFilePath};Version=3;";
    }

    public void ExecuteNonQuery(string query)
    {
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.ExecuteNonQuery();
            }

            connection.Close();
        }
    }

    public object ExecuteScalar(string query)
    {
        object result = null;

        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                result = command.ExecuteScalar();
            }

            connection.Close();
        }

        return result;
    }

    // CRUD para WebSite

    public List<WebSite> GetAllWebSites()
    {
        List<WebSite> webSites = new List<WebSite>();

        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            string selectAllQuery = "SELECT * FROM WebSite";

            using (SQLiteCommand command = new SQLiteCommand(selectAllQuery, connection))
            {
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        WebSite webSite = new WebSite
                        {
                            ID = Convert.ToInt32(reader["ID"]),
                            WebName = reader["WebName"].ToString(),
                            Enlace = reader["Enlace"].ToString(),
                            RutaImagen = reader["RutaImagen"].ToString(),
                            Descripcion = reader["Descripcion"].ToString()
                        };
                        webSites.Add(webSite);
                    }
                }
            }

            connection.Close();
        }

        return webSites;
    }
    public WebSite GetWebSiteByID(int id)
    {
        WebSite webSite = null;

        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            string selectQuery = $"SELECT * FROM WebSite WHERE ID = {id}";

            using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
            {
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        webSite = new WebSite
                        {
                            ID = Convert.ToInt32(reader["ID"]),
                            WebName = reader["WebName"].ToString(),
                            Enlace = reader["Enlace"].ToString(),
                            RutaImagen = reader["RutaImagen"].ToString(),
                            Descripcion = reader["Descripcion"].ToString()
                        };
                    }
                }
            }

            connection.Close();
        }

        return webSite;
    }

    public void AddWebSite(WebSite webSite)
    {
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            string insertQuery = $"INSERT INTO WebSite (WebName, Enlace, RutaImagen, Descripcion) VALUES ('{webSite.WebName}', '{webSite.Enlace}', '{webSite.RutaImagen}', '{webSite.Descripcion}')";

            ExecuteNonQuery(insertQuery);

            connection.Close();
        }
    }

    public void UpdateWebSite(WebSite webSite)
    {
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            string updateQuery = $"UPDATE WebSite SET WebName = '{webSite.WebName}', Enlace = '{webSite.Enlace}', RutaImagen = '{webSite.RutaImagen}', Descripcion = '{webSite.Descripcion}' WHERE ID = {webSite.ID}";

            ExecuteNonQuery(updateQuery);

            connection.Close();
        }
    }

    public void DeleteWebSite(int webSiteID)
    {
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            string deleteQuery = $"DELETE FROM WebSite WHERE ID = {webSiteID}";

            ExecuteNonQuery(deleteQuery);

            connection.Close();
        }
    }

    // CRUD para Cuenta

    public List<Cuenta> GetAllCuentas()
    {
        List<Cuenta> cuentas = new List<Cuenta>();

        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            string selectAllQuery = "SELECT * FROM Cuenta";

            using (SQLiteCommand command = new SQLiteCommand(selectAllQuery, connection))
            {
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Cuenta cuenta = new Cuenta
                        {
                            ID = Convert.ToInt32(reader["ID"]),
                            WebSiteID = Convert.ToInt32(reader["WebSiteID"]),
                            Correo = reader["Correo"].ToString(),
                            Contraseña = reader["Contraseña"].ToString()
                        };
                        cuentas.Add(cuenta);
                    }
                }
            }

            connection.Close();
        }

        return cuentas;
    }

    public Cuenta GetCuentaByID(int id)
    {
        Cuenta cuenta = null;

        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            string selectQuery = $"SELECT * FROM Cuenta WHERE ID = {id}";

            using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
            {
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        cuenta = new Cuenta
                        {
                            ID = Convert.ToInt32(reader["ID"]),
                            WebSiteID = Convert.ToInt32(reader["WebSiteID"]),
                            Correo = reader["Correo"].ToString(),
                            Contraseña = reader["Contraseña"].ToString()
                        };
                    }
                }
            }

            connection.Close();
        }

        return cuenta;
    }

    public void AddCuenta(Cuenta cuenta)
    {
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            string insertQuery = $"INSERT INTO Cuenta (Correo, Contraseña, WebSiteID) VALUES ('{cuenta.Correo}', '{cuenta.Contraseña}', {cuenta.WebSiteID})";

            ExecuteNonQuery(insertQuery);

            connection.Close();
        }
    }

    public void UpdateCuenta(Cuenta cuenta)
    {
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            string updateQuery = $"UPDATE Cuenta SET Correo = '{cuenta.Correo}', Contraseña = '{cuenta.Contraseña}', WebSiteID = {cuenta.WebSiteID} WHERE ID = {cuenta.ID}";

            ExecuteNonQuery(updateQuery);

            connection.Close();
        }
    }

    public void DeleteCuenta(int cuentaID)
    {
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            string deleteQuery = $"DELETE FROM Cuenta WHERE ID = {cuentaID}";

            ExecuteNonQuery(deleteQuery);

            connection.Close();
        }
    }

    // CRUD para Card

    public List<Card> GetAllCards()
    {
        List<Card> cards = new List<Card>();

        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            string selectAllQuery = "SELECT * FROM Card";

            using (SQLiteCommand command = new SQLiteCommand(selectAllQuery, connection))
            {
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Card card = new Card
                        {
                            ID = Convert.ToInt32(reader["ID"]),
                            BankName = reader["BankName"].ToString(),
                            FullOwnerName = reader["FullOwnerName"].ToString(),
                            BankAccount = reader["BankAccount"].ToString(),
                            Date = reader["Date"].ToString(),
                            CVC = Convert.ToInt32(reader["CVC"]),
                            Country = reader["Country"].ToString(),
                            TypeCard = reader["TypeCard"].ToString(),
                            IsDebit = Convert.ToBoolean(reader["IsDebit"]),
                            CardColor = reader["CardColor"].ToString()
                        };
                        cards.Add(card);
                    }
                }
            }

            connection.Close();
        }

        return cards;
    }

    public Card GetCardByID(int id)
    {
        Card card = null;

        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            string selectQuery = $"SELECT * FROM Card WHERE ID = {id}";

            using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
            {
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        card = new Card
                        {
                            ID = Convert.ToInt32(reader["ID"]),
                            BankName = reader["BankName"].ToString(),
                            FullOwnerName = reader["FullOwnerName"].ToString(),
                            BankAccount = reader["BankAccount"].ToString(),
                            Date = reader["Date"].ToString(),
                            CVC = Convert.ToInt32(reader["CVC"]),
                            Country = reader["Country"].ToString(),
                            TypeCard = reader["TypeCard"].ToString(),
                            IsDebit = Convert.ToBoolean(reader["IsDebit"]),
                            CardColor = reader["CardColor"].ToString()
                        };
                    }
                }
            }

            connection.Close();
        }

        return card;
    }

    public void AddCard(Card card)
    {
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            string insertQuery = $@"INSERT INTO Card 
                                (BankName, FullOwnerName, BankAccount, Date, CVC, Country, TypeCard, IsDebit, CardColor) 
                                VALUES 
                                ('{card.BankName}', '{card.FullOwnerName}', '{card.BankAccount}', '{card.Date}', {card.CVC}, '{card.Country}', '{card.TypeCard}', {Convert.ToInt32(card.IsDebit)}, '{card.CardColor}')";

            ExecuteNonQuery(insertQuery);

            connection.Close();
        }
    }

    public void UpdateCard(Card card)
    {
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            string updateQuery = $@"UPDATE Card 
                                SET 
                                BankName = '{card.BankName}', 
                                FullOwnerName = '{card.FullOwnerName}', 
                                BankAccount = '{card.BankAccount}', 
                                Date = '{card.Date}', 
                                CVC = {card.CVC}, 
                                Country = '{card.Country}', 
                                TypeCard = '{card.TypeCard}', 
                                IsDebit = {Convert.ToInt32(card.IsDebit)}, 
                                CardColor = '{card.CardColor}' 
                                WHERE ID = {card.ID}";

            ExecuteNonQuery(updateQuery);

            connection.Close();
        }
    }

    public void DeleteCard(int cardID)
    {
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            string deleteQuery = $"DELETE FROM Card WHERE ID = {cardID}";

            ExecuteNonQuery(deleteQuery);

            connection.Close();
        }
    }

}
