using Prueba.Aplicacion.Entidades;
using Prueba.Aplicacion.Interfaces;

namespace Prueba.Aplicacion.UseCases;

public class ObtenerCursoUseCase
{
    private readonly IRepositorioCurso _rCurso;

    public ObtenerCursoUseCase(IRepositorioCurso rCurso)
    {
        _rCurso = rCurso;
    }

    public Curso? Ejecutar(int id)
    {
        return _rCurso.GetCurso(id);
    }

    public Curso? Ejecutar(string titulo)
    {
        return _rCurso.GetCurso(titulo);
    }
}