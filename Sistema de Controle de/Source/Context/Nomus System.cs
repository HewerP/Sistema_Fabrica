using Sistema_de_Controle_de.Source.Model;
using System;
using System.Data.Entity;
using System.Linq;

namespace Sistema_de_Controle_de.Source.Context
{
    public class Nomus_System : DbContext
    {
        // Your context has been configured to use a 'Nomus_System' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Sistema_de_Controle_de.Source.Context.Nomus_System' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Nomus_System' 
        // connection string in the application configuration file.
        public Nomus_System()
            : base("name=Nomus System")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

         public virtual DbSet<Endereco> Enderecos { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}