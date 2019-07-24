
using Microsoft.EntityFrameworkCore;
using DatingApp.API.Models;

namespace DatingApp.API.Data

{
    public class DataContext: DbContext
    {
        //Crear el Contexto
       public DataContext(DbContextOptions<DataContext> options) : base (options)
        {}
            
        //<Value> es la Clase Model. DatingApp.API.Models
        // Values, será el nombre de la tabla de la base
        // Startup.cs crea el servicio en ConfigureServices
         public DbSet<Value> Values { get; set; }
        
    }
}