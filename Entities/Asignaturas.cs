using System;
using System.Collections.Generic;

namespace curso.Objetos
{
    public class Asignatura
    {
        public string nameAsignatura { get; set; }
        public string idAsignatura { get; private set; }
        public List<Evaluaciones> evaluaciones { get; set; }

        public Asignatura() => idAsignatura = Guid.NewGuid().ToString();
    }
}