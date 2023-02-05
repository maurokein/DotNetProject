using Prueba.Aplicacion.Entidades;
using Prueba.Aplicacion.Interfaces;

namespace Prueba.Aplicacion.UseCases;

public class ListarCursosPorEstudianteUseCase
{
    private readonly IRepositorioCurso _rCurso;

    public ListarCursosPorEstudianteUseCase(IRepositorioCurso rCurso)
    {
        _rCurso = rCurso;
    }

    public List<Curso> Ejecutar(int estudianteId)
    {
        return _rCurso.GetCursosPorEstudiante(estudianteId);
    }
}