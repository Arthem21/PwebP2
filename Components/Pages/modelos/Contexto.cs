using Microsoft.EntityFrameworkCore;

//<Contexto entre el codigo y la base de datos (Cristobal Garcia Lopez 2023-1634)
public class Contexto: DbContext {

    //Tabla de la base de datos(Cristobal Garcia Lopez 2023-1634) 
    public DbSet < Personas > ? personas { get; set; } = null ;

    public Contexto ( DbContextOptions < Contexto > options ): base( options ){ }
}