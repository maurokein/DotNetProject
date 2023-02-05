using Prueba.Aplicacion.Entidades;
using Prueba.Aplicacion.Interfaces;

namespace Prueba.Aplicacion.UseCases;

public class ListarInscripcionesUseCase
{
    private readonly IRepositorioInscripcion _rInscripcion;

    public ListarInscripcionesUseCase(IRepositorioInscripcion rInscripcion)
    {
        _rInscripcion = rInscripcion;
    }

    public List<Dato> Ejecutar()
    {
        return _rInscripcion.GetInscripciones();
    }
}