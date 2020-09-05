using Library.Data.Models;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.IO;
using Library.Data;

namespace Library.WorkClasses
{
    /*класс для сохранения в БД*/
    public class Saviour : Connection
    {

        OleDbCommand worker = new OleDbCommand();
        public Saviour()
        {
            myConnection.Open();

        }
        public void SaveAuthorToAccess(Author _author)
        {

            worker.Connection = myConnection;
            worker.CommandType = CommandType.Text;
            worker.CommandText = ("INSERT INTO [Authors]([AuthorName]) VALUES (@name)");
            worker.Parameters.AddWithValue("@name", _author.AuthorName);
            worker.ExecuteNonQuery();

            myConnection.Close();

            /*attempt to use Nhibernate*/
            
            //using (ISession session = HibernateHelper.OpenSession())
            //{
            //    using (ITransaction transaction = session.BeginTransaction())
            //    {
            //        session.Save(_author);
            //        transaction.Commit();
            //    }
            //}

        }

        public void SavePublisherToAccess(Publisher _publisher)
        {

            worker.Connection = myConnection;
            worker.CommandType = CommandType.Text;
            worker.CommandText = ("INSERT INTO [Publishers]([PublisherName]) VALUES (@name)");
            worker.Parameters.AddWithValue("@name", _publisher.PublisherName);
            worker.ExecuteNonQuery();

            myConnection.Close();
        }

        public void SaveBookToAccess(Book _book)
        {

            worker.Connection = myConnection;
            worker.CommandType = CommandType.Text;
            worker.CommandText = ("INSERT INTO [Books]([BookName],[Description],[Price],[PublishedAt],[IdPublisher]) VALUES (@name,@descr,@price,@release,@pub)");
            worker.Parameters.AddWithValue("@name", _book.BookName);
            worker.Parameters.AddWithValue("@descr", _book.Description);
            worker.Parameters.AddWithValue("@price", _book.Price);
            worker.Parameters.AddWithValue("@price", _book.ReleaseDate);
            worker.Parameters.AddWithValue("@pub",GetPublisherName(_book.Publisher,myConnection));
            worker.ExecuteNonQuery();

            myConnection.Close();
        }


        private int GetPublisherName(string _name, OleDbConnection _con)
        {
            int id=0;
            string query = "SELECT [PublisherId] FROM [Publishers] WHERE [PublisherName] = '" + _name + "'";
            OleDbCommand command = new OleDbCommand(query, _con);
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                id = (int)reader[0];
            }
            reader.Close();

            return id;
        }
    }

}
