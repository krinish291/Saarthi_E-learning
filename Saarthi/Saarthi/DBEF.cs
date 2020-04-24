namespace WindowsFormsApplication1
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using Models;
    public class DBEF : DbContext
    {
        // Your context has been configured to use a 'testEntity' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'WindowsFormsApplication1.testEntity' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'testEntity' 
        // connection string in the application configuration file.
        public DBEF()
            : base("name=testEntity")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Learner> Learners { get; set; }

        public virtual DbSet<Standard> Standards { get; set; }

        public virtual DbSet<Subject> Subjects { get; set; }

        public virtual DbSet<Chapter> Chapters { get; set; }

        public virtual DbSet<Question> Questions { get; set; }

        public virtual DbSet<Result> Results { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}