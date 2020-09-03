using Library.Data.Models;
using NHibernate;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.WorkClasses
{
    //класс для сохранения в БД

   
    public class Saviour
    {

        private Configuration myConfiguration;
        private ISessionFactory mySessionFactory;
        private ISession mySession;

        public Saviour()
        {
            myConfiguration = new Configuration();
            myConfiguration.Configure();

            mySessionFactory = myConfiguration.BuildSessionFactory();
            mySession = mySessionFactory.OpenSession();
        }
        public void SaveAuthorToAccess(Author _author)
        {

            using (mySession.BeginTransaction())
            {
                mySession.Save(_author);
                mySession.Transaction.Commit();
            }
                
        }

        public void SavePublisherToAccess(Publisher _publisher)
        {

            using (mySession.BeginTransaction())
            {
                mySession.Save(_publisher);
                mySession.Transaction.Commit();
            }

        }

    }
}
