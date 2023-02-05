using Prueba.Aplicacion.Entidades;
using Prueba.Aplicacion.Interfaces;

namespace Prueba.Aplicacion.UseCases;

public class ModificarCursoUseCase
{
    private readonly IRepositorioCurso _rCurso;

    public ModificarCursoUseCase(IRepositorioCurso rCurso)
    {
        _rCurso = rCurso;
    }

    public void Ejecutar(Curso curso)
    {
        _rCurso.ModificarCurso(curso);
    }
}