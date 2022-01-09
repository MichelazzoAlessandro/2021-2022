using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Clinica
{
    public partial class Form1
    {
        public class paziente: Persona
        {
            
            public string Patologia { get; set; }
            public int Id { get; set; }

            public paziente(string nome, string cognome, string patologia, int id): base(nome, cognome)
            {
                Nome = nome;
                Cognome = cognome;
                Patologia = patologia;
                Id = id;
            }
            public string GetName()
            {
                return $"{Nome} {Cognome}";
            }
        }
    }
}
