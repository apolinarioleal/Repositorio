using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Notifica
    {
        public Notifica()
        {
            Notificacoes = new List<Notifica>();

        }
        [NotMapped]
        public string? NomedaPropriedade { get; set; }

        [NotMapped]
        public string? Informacao { get; set; }

        public List<Notifica> Notificacoes;

        public bool ValidarPropriedadeString( string valor , string nomedapropriedade)
        {
            if(string.IsNullOrWhiteSpace(valor) || string.IsNullOrWhiteSpace(valor))
            {
                Notificacoes.Add(new Notifica { Informacao = " Digite um valor",
                NomedaPropriedade = nomedapropriedade
                });

                return false;
            }

            return true;

         }

    }
}

