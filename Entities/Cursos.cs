using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace curso.Objetos
{
    public enum TipoJornada
    {
        Mañana,Tarde,Noche
    }
   public class Cursos
    {
        public string idCurso { get; private set; }
        public string nameCurso { get; set; }
        public TipoJornada jornada { get; set; }
        public  List<Alumno> alumnos { get; set; }
        public List<Asignatura> asignaturas { get; set; }
        public Cursos() => idCurso = Guid.NewGuid().ToString();
      
    }
}
