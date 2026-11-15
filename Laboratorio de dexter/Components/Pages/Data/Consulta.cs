
//SQLite y DbContextFactory	
//Cumplido: Inyección de IDbContextFactory<AppDbContext>, 
//    archivo dexter.db 
//    (SQLite) y clases de entidad en la carpeta Data 
//    (AppDbContext.cs, Consulta.cs)



public class Consulta
{
    public int Id { get; set; }
    public string Nombre { get; set; } = "";
    public string Equipo { get; set; } = "";
    public string Falla { get; set; } = "";
    public DateTime Fecha { get; set; } = DateTime.Now;
}