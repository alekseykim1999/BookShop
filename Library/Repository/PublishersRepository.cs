using Library.Data;
using Library.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Repository
{
    public class PublishersRepository : Connection
    {
        public PublishersRepository()
        {
            myConnection.Open();
        }
        private List<Publisher> listBooks = new List<Publisher>();

        public List<Publisher> GetPublishers()
        {

            string query = "SELECT [PublisherId],[PublisherName] FROM [Publishers] ORDER BY [PublisherId]";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                listBooks.Add(new Publisher(reader[1].ToString())
                {
                    PublisherId = (int)reader[0]                
                });
            }
            reader.Close();

            myConnection.Close();

            return listBooks;

        }
    }
}
