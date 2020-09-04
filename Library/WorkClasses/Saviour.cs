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
    //класс для сохранения в БД

   
    public class Saviour : Connection
    {   
        public Saviour()
        {
            myConnection.Open();
        }
        public void SaveAuthorToAccess(Author _author)
        {



            OleDbCommand worker = new OleDbCommand();
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
            


            OleDbCommand worker = new OleDbCommand();
            worker.Connection = myConnection;
            worker.CommandType = CommandType.Text;
            worker.CommandText = ("INSERT INTO [Publishers]([PublisherName]) VALUES (@name)");
            worker.Parameters.AddWithValue("@name", _publisher.PublisherName);
            worker.ExecuteNonQuery();

            myConnection.Close();
        }

        public void SaveBookToAccess(Book _book)
        {
           
            OleDbCommand worker = new OleDbCommand();
            worker.Connection = myConnection;
            worker.CommandType = CommandType.Text;
            worker.CommandText = ("INSERT INTO [Publishers]([PublisherName]) VALUES (@name)");
            worker.Parameters.AddWithValue("@name", _book.BookName);
            worker.ExecuteNonQuery();

            myConnection.Close();
        }

    }
}
