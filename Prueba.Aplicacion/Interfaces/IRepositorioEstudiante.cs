using Prueba.Aplicacion.Entidades;

namespace Prueba.Aplicacion.Interfaces;

public interface IRepositorioEstudiante
{
    void AgregarEstudiante(Estudiante estudiante);

    void ModificarEstudiante(Estudiante estudiante);

    void EliminarEstudiante(int id);

    Estudiante? GetEstudiante(int id);

    Estudiante? GetEstudiante(int dni, string apellido);  

    List<Estudiante> GetEstudiantes();

    List<Dato> GetEstudiantesConCursoEnProceso();

    List<Dato> GetEstudiantesConCursoTerminado();

    List<Estudiante> GetEstudiantesPorCurso(int cursoId);
}