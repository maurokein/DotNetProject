using Prueba.Aplicacion.Entidades;
using Prueba.Aplicacion.Interfaces;

namespace Prueba.Aplicacion.UseCases;

public class EliminarCursoUseCase
{
    private readonly IRepositorioCurso _rCurso;

    public EliminarCursoUseCase(IRepositorioCurso rCurso)
    {
        _rCurso = rCurso;
    }

    public void Ejecutar(int id)
    {
        _rCurso.EliminarCurso(id);
    }
}