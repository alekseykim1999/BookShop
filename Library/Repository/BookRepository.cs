using Library.Data;
using Library.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Repository
{
    public class PublisherRepository : Connection
    {


        public PublisherRepository()
        {
            myConnection.Open();
        }
        private List<Book> listBooks = new List<Book>();
        public List<Book> GetBooks()
        {

            string query = "SELECT [BookId],[BookName],[Description],[Price],[PublishedAt],[PublisherName] FROM [Books],[Publishers] " +
                "WHERE [Books].[IdPublisher] = [Publishers].[PublisherId] " +
                "ORDER BY [BookId]";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                listBooks.Add(new Book
                {
                    BookId = (int)reader[0],
                    BookName = reader[1].ToString(),
                    Description = reader[2].ToString(),
                    Price = (int)reader[3],
                    ReleaseDate = reader[4].ToString(),
                    Publisher = reader[5].ToString()

                });
            }
            reader.Close();

            myConnection.Close();

            return listBooks;

        }

    }
}
