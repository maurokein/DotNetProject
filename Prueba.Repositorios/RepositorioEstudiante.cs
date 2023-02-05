using Microsoft.EntityFrameworkCore;

using Prueba.Aplicacion.Entidades;
using Prueba.Aplicacion.Interfaces;

namespace Prueba.Repositorios;

public class RepositorioEstudiante : IRepositorioEstudiante
{
    public void AgregarEstudiante(Estudiante estudiante)
    {
        using (var db = new InstitucionEducativaContext())
        {
            db.Add(estudiante);
            db.SaveChanges();
        }
    }

    public void ModificarEstudiante(Estudiante estudiante)
    {
        using (var db = new InstitucionEducativaContext())
        {
            var estudianteAModificar = db.Estudiantes.Where(e => e.Id == estudiante.Id).SingleOrDefault();
            
            if(estudianteAModificar != null)
            {
                estudianteAModificar.Dni = estudiante.Dni;
                estudianteAModificar.Nombre = estudiante.Nombre;
                estudianteAModificar.Apellido = estudiante.Apellido;
                estudianteAModificar.Email = estudiante.Email;
            }
            db.SaveChanges();
        }
    }

    public void EliminarEstudiante(int id)
    {
        using (var db = new InstitucionEducativaContext())
        {
            var estudianteAEliminar = db.Estudiantes.Where(e => e.Id == id).SingleOrDefault();
            
            if(estudianteAEliminar != null)
            {
                db.Remove(estudianteAEliminar);
            }
            db.SaveChanges();
        }
    }

    public Estudiante? GetEstudiante(int id)
    {
        using(var db = new InstitucionEducativaContext())
        {
            var estudianteBuscado = db.Estudiantes.Where(e => e.Id == id).SingleOrDefault();
            return estudianteBuscado;
        }
    }

    public Estudiante? GetEstudiante(int dni, string apellido)
    {
        using(var db = new InstitucionEducativaContext())
        {
            var estudianteBuscado = db.Estudiantes.Where(e => ((e.Dni == dni) && (e.Apellido == apellido))).SingleOrDefault();
            return estudianteBuscado;
        }
    }

    public List<Estudiante> GetEstudiantes()
    {
        using(var db = new InstitucionEducativaContext())
        {
            List<Estudiante> lista = db.Estudiantes.ToList();
            return lista; 
        }
    }


    public List<Dato> GetEstudiantesConCursoEnProceso()
    {
        using (var db = new InstitucionEducativaContext())
        {
            List<Dato> data = new List<Dato>();
            Estudiante? _e = null; 
            Curso? _c = null; 
            int comparacion = 0;
            IRepositorioCurso repositorioCurso = new RepositorioCurso();
            foreach(Inscripcion i in db.Inscripciones)
            {
                _c = repositorioCurso.GetCurso(i.CursoId);
                if(_c is not null)
                {
                    comparacion = DateTime.Compare(_c.FechaDeFin, DateTime.Now);
                }
                if(comparacion > 0)
                {
                    _e = this.GetEstudiante(i.EstudianteId);
                    if(_e is not  null && _c is not null)
                    {
                        data.Add(new Dato(_e.Nombre,_e.Apellido,_c.Titulo));
                    }
                }
            }
            return data; 
        }
    }

    public List<Dato> GetEstudiantesConCursoTerminado()
    {
        using (var db = new InstitucionEducativaContext())
        {
            List<Dato> data = new List<Dato>();
            Estudiante? _e = null; 
            Curso? _c = null;
            int comparacion = 0;
            IRepositorioCurso repositorioCurso = new RepositorioCurso();
            foreach(Inscripcion i in db.Inscripciones)
            {    
                _c = repositorioCurso.GetCurso(i.CursoId);
                if(_c is not null)
                {
                    comparacion = DateTime.Compare(_c.FechaDeFin, DateTime.Now);
                }
                if(comparacion < 0)
                {
                    _e = this.GetEstudiante(i.EstudianteId);
                    if(_e != null && _c != null)
                    {
                        data.Add(new Dato(_e.Nombre,_e.Apellido,_c.Titulo));
                    }
                }
            }
            return data;
        }
    }

    public List<Estudiante> GetEstudiantesPorCurso(int cursoId)
    {
        using (var db = new InstitucionEducativaContext())
        {
            List<Estudiante> lista = new List<Estudiante>();
            var inscripciones = db.Inscripciones.Where(i => i.CursoId == cursoId);
            var inscripcionesIterables = inscripciones.ToList();
            foreach(var i in inscripcionesIterables)
            {
                Estudiante? estudiante = this.GetEstudiante(i.EstudianteId);
                if(estudiante is not null)
                {
                    lista.Add(estudiante);
                }
            }
            return lista;
        }
    }
}