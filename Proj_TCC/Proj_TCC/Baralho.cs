using System;
using System.Collections.Generic;
using System.Text;

namespace Proj_TCC
{
    public class Baralho
    {
        public string Nome { get; set; }
        public DateTime UltimaAlteracao { get; set; }
        public string Criador { get; set; }
        public bool Favorito { get; set; }
        public bool DelecaoBloqueada { get; set; }

        public Baralho(string nome, DateTime ultimaAlteracao, string criador, bool favorito, bool delecaoBloqueada)
        {
            Nome = nome;
            UltimaAlteracao = ultimaAlteracao;
            Criador = criador;
            Favorito = favorito;
            DelecaoBloqueada = delecaoBloqueada;
        }
    }
}
