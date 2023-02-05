namespace Prueba.Aplicacion.Entidades; 

public class Dato 
{
    public int Id { get; set; } = 0;
    public string? Nombre { get; set; }
    public string? Apellido { get; set; }
    public string? Curso { get; set; }
    public DateTime Fecha { get; set; } = DateTime.Now;

    public Dato(string? nombre, string? apellido, string? curso)
    {
        Nombre = nombre;
        Apellido = apellido;
        Curso = curso; 
    }
    public Dato(int id, string? nombre, string? apellido, string? curso, DateTime fecha)
    {
        Id = id;
        Nombre = nombre;
        Apellido = apellido;
        Curso = curso;
        Fecha = fecha;
    }
    public Dato(){}
}