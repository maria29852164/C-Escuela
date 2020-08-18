using System;

namespace curso.Objetos
{
    public class Evaluaciones
    {
        public string nameEvaluaciones { get; set; }
        public string idEvaluaciones { get; private set; }
        public float nota { get; set; }
        public Evaluaciones() => idEvaluaciones = Guid.NewGuid().ToString();
    }
}