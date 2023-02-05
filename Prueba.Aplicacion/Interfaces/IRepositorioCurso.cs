using Prueba.Aplicacion.Entidades;

namespace Prueba.Aplicacion.Interfaces;

public interface IRepositorioCurso
{
    void AgregarCurso(Curso curso);

    void ModificarCurso(Curso curso);

    void EliminarCurso(int id);

    Curso? GetCurso(int id);

    Curso? GetCurso(string titulo);

    List<Curso> GetCursos();

    List<Curso> GetCursosPorEstudiante(int estudianteId);
}