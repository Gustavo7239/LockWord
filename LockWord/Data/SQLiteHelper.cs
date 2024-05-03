using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
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
                            Link = reader["Link"].ToString(),
                            ImageName = reader["ImageName"].ToString(),
                            Description = reader["Description"].ToString(),
                            IsFontWhite = Convert.ToBoolean(reader["IsFontWhite"]),
                            ItemColor = Color.FromName(reader["ItemColor"].ToString()) // Cambiar a itemColor
                        };
                        webSites.Add(webSite);
                    }
                }
            }
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
                            Link = reader["Link"].ToString(),
                            ImageName = reader["ImageName"].ToString(),
                            Description = reader["Description"].ToString(),
                            IsFontWhite = Convert.ToBoolean(reader["IsFontWhite"]),
                            ItemColor = Color.FromName(reader["ItemColor"].ToString()) // Cambiar a itemColor
                        };
                    }
                }
            }
        }

        return webSite;
    }

    public void AddWebSite(WebSite webSite)
    {
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            string insertQuery = $"INSERT INTO WebSite (WebName, Link, ImageName, Description, IsFontWhite, ItemColor) VALUES ('{webSite.WebName}', '{webSite.Link}', '{webSite.ImageName}', '{webSite.Description}', {Convert.ToInt32(webSite.IsFontWhite)}, '{webSite.ItemColor.Name}')";

            ExecuteNonQuery(insertQuery);
        }
    }

    public void UpdateWebSite(WebSite webSite)
    {
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            string updateQuery = $"UPDATE WebSite SET WebName = '{webSite.WebName}', Link = '{webSite.Link}', ImageName = '{webSite.ImageName}', Description = '{webSite.Description}', IsFontWhite = {Convert.ToInt32(webSite.IsFontWhite)}, ItemColor = '{webSite.ItemColor.Name}' WHERE ID = {webSite.ID}";

            ExecuteNonQuery(updateQuery);
        }
    }


    public void DeleteWebSite(int webSiteID)
    {
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            string deleteQuery = $"DELETE FROM WebSite WHERE ID = {webSiteID}";

            ExecuteNonQuery(deleteQuery);
        }
    }


    // CRUD para Account

    public List<Account> GetAllAccounts()
    {
        List<Account> accounts = new List<Account>();

        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            string selectAllQuery = "SELECT * FROM Account";

            using (SQLiteCommand command = new SQLiteCommand(selectAllQuery, connection))
            {
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Account account = new Account
                        {
                            ID = Convert.ToInt32(reader["ID"]),
                            WebSiteID = Convert.ToInt32(reader["WebSiteID"]),
                            UserName = reader["UserName"].ToString(),
                            Mail = reader["Mail"].ToString(),
                            Password = reader["Password"].ToString()
                        };
                        accounts.Add(account);
                    }
                }
            }
        }

        return accounts;
    }

    public Account GetAccountByID(int id)
    {
        Account account = null;

        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            string selectQuery = $"SELECT * FROM Account WHERE ID = {id}";

            using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
            {
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        account = new Account
                        {
                            ID = Convert.ToInt32(reader["ID"]),
                            WebSiteID = Convert.ToInt32(reader["WebSiteID"]),
                            UserName = reader["UserName"].ToString(),
                            Mail = reader["Mail"].ToString(),
                            Password = reader["Password"].ToString()
                        };
                    }
                }
            }
        }

        return account;
    }

    public void AddAccount(Account account)
    {
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            string insertQuery = $"INSERT INTO Account (WebSiteID, UserName, Mail, Password) VALUES ({account.WebSiteID}, '{account.UserName}', '{account.Mail}', '{account.Password}')";

            ExecuteNonQuery(insertQuery);
        }
    }

    public void UpdateAccount(Account account)
    {
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            string updateQuery = $"UPDATE Account SET WebSiteID = {account.WebSiteID}, UserName = '{account.UserName}', Mail = '{account.Mail}', Password = '{account.Password}' WHERE ID = {account.ID}";

            ExecuteNonQuery(updateQuery);
        }
    }

    public void DeleteAccount(int accountID)
    {
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            string deleteQuery = $"DELETE FROM Account WHERE ID = {accountID}";

            ExecuteNonQuery(deleteQuery);
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
                            Month = Convert.ToInt32(reader["Month"]),
                            Year = Convert.ToInt32(reader["Year"]),
                            CVC = Convert.ToInt32(reader["CVC"]),
                            Country = reader["Country"].ToString(),
                            TypeCard = (IconChar)Enum.Parse(typeof(IconChar), reader["TypeCard"].ToString()), // Convertir el string a Enum
                            IsDebit = Convert.ToBoolean(reader["IsDebit"]),
                            CardColor = Color.FromName(reader["CardColor"].ToString())
                        };
                        cards.Add(card);
                    }
                }
            }
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
                            Month = Convert.ToInt32(reader["Month"]),
                            Year = Convert.ToInt32(reader["Year"]),
                            CVC = Convert.ToInt32(reader["CVC"]),
                            Country = reader["Country"].ToString(),
                            TypeCard = (IconChar)Enum.Parse(typeof(IconChar), reader["TypeCard"].ToString()), // Convertir el string a Enum
                            IsDebit = Convert.ToBoolean(reader["IsDebit"]),
                            CardColor = Color.FromName(reader["CardColor"].ToString())
                        };
                    }
                }
            }
        }

        return card;
    }

    public void AddCard(Card card)
    {
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            string insertQuery = $@"INSERT INTO Card 
                                (BankName, FullOwnerName, BankAccount, Month, Year, CVC, Country, TypeCard, IsDebit, CardColor) 
                                VALUES 
                                ('{card.BankName}', '{card.FullOwnerName}', '{card.BankAccount}', {card.Month}, {card.Year}, {card.CVC}, '{card.Country}', '{card.TypeCard.ToString()}', {Convert.ToInt32(card.IsDebit)}, '{card.CardColor}')";

            ExecuteNonQuery(insertQuery);
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
                                Month = {card.Month}, 
                                Year = {card.Year}, 
                                CVC = {card.CVC}, 
                                Country = '{card.Country}', 
                                TypeCard = '{card.TypeCard.ToString()}', 
                                IsDebit = {Convert.ToInt32(card.IsDebit)}, 
                                CardColor = '{card.CardColor}' 
                                WHERE ID = {card.ID}";

            ExecuteNonQuery(updateQuery);
        }
    }

    public void DeleteCard(int cardID)
    {
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            string deleteQuery = $"DELETE FROM Card WHERE ID = {cardID}";

            ExecuteNonQuery(deleteQuery);
        }
    }

}
