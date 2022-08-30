using System;
namespace evaluacion.Model
{
    public class PersonaModel
    {
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
    }

    public class ListaPersonaModel
    {
        public List<PersonaModel> ListaPersona { get; set; }
    }
}

