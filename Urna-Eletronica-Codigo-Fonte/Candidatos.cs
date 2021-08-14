using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Urna_Eletronica_Codigo_Fonte
{
    class Candidatos
    {
        private static String Nome { get; set; }
        [MaxLength(2)]
        private int Partido { get; set; }
        private int Votos { get; set; }

       public Candidatos(string nome, int partido, int votos)
        {
            nome = Nome;
            partido = Partido;
            votos = Votos;
        }
    }
}
