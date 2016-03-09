namespace TicketSystem
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class CodeFirstTicketSystem : DbContext
    {
        // Your context has been configured to use a 'CodeFirstTicketSystem' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'TicketSystem.CodeFirstTicketSystem' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'CodeFirstTicketSystem' 
        // connection string in the application configuration file.
        public CodeFirstTicketSystem()
            : base("name=CodeFirstTicketSystem")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<CodeFirstTicketSystem, TicketSystem.Migrations.Configuration>("CodeFirstTicketSystem"));
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Schedule> Schedules { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }
        public virtual DbSet<Trains> Trains { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Seat> Seats { get; set; }
        public virtual DbSet<DiscountCard> DiscountCard { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}