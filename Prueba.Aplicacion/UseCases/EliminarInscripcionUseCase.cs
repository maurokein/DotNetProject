using Prueba.Aplicacion.Entidades;
using Prueba.Aplicacion.Interfaces;

namespace Prueba.Aplicacion.UseCases;

public class EliminarInscripcionUseCase
{
    private readonly IRepositorioInscripcion _rInscripcion;

    public EliminarInscripcionUseCase(IRepositorioInscripcion rInscripcion)
    {
        _rInscripcion = rInscripcion;
    }

    public void Ejecutar(int id)
    {
        _rInscripcion.EliminarInscripcion(id);
    }
}