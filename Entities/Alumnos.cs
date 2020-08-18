using System;
using System.Collections.Generic;

namespace curso.Objetos
{
    public class Alumno
    {
        public string name { get; set; }
        public string lastname { get; set; }
        public string idAlumno { get; private set; }
        public List<Evaluaciones> evaluaciones { get; set; }
    
   
        public Alumno() => idAlumno = Guid.NewGuid().ToString();

    }
}