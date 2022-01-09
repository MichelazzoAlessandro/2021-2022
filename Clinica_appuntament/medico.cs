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
        public class medico : Persona
        {
          
            public string Specializzazione { get; set; }
            public int Id { get; set; }

            public medico(string nome, string cognome, string specializzazione, int id): base(nome,cognome)
            {
                Nome = nome;
                Cognome = cognome;
                Specializzazione = specializzazione;
                Id = id;
            }
            public string GetName()
            {
                return $"{Nome} {Cognome}";
            }

        }
    }

}
