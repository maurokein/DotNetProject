using Prueba.Aplicacion.Entidades;
using Prueba.Aplicacion.Interfaces;

namespace Prueba.Aplicacion.UseCases;

public class AgregarCursoUseCase
{
    private readonly IRepositorioCurso _rCurso;

    public AgregarCursoUseCase(IRepositorioCurso rCurso)
    {
        _rCurso = rCurso;
    }

    public void Ejecutar(Curso curso)
    {
        _rCurso.AgregarCurso(curso);
    }
}