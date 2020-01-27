namespace Saarthi
{
    using Saarthi.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class DBEF : DbContext
    {
        // Your context has been configured to use a 'DBEF' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Saarthi.DBEF' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'DBEF' 
        // connection string in the application configuration file.
        public DBEF()
            : base("name=DBEF")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

         public virtual DbSet<Learner> Learners { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}