namespace Clinica
{
    public partial class Form1
    {
        public class Persona
        {
            public string Nome { get; set; }
            public string Cognome { get; set; }
            public Persona(string nome, string cognome)
            {
                Nome = nome;
                Cognome = cognome;
            }
        }
    }

}
