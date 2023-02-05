using Prueba.Aplicacion.Entidades;
using Prueba.Aplicacion.Interfaces;

namespace Prueba.Aplicacion.UseCases;

public class ListarCursosUseCase
{
    private readonly IRepositorioCurso _rCurso;

    public ListarCursosUseCase(IRepositorioCurso rCurso)
    {
        _rCurso = rCurso;
    }

    public List<Curso> Ejecutar()
    {
        return _rCurso.GetCursos();
    }
}