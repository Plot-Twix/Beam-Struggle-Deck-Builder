using System;
using System.Collections.Generic;
using System.Text;

namespace Proj_TCC
{
    internal class Carta
    {
        public string Nome { get; set; }
        public string ? Imagem { get; set; }
        public int ? Quantidade
        {
            get;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Quantidade", "A quantidade não pode ser negativa.");
                }
                if (value > 3)
                {
                    throw new ArgumentOutOfRangeException("Quantidade", "A quantidade não pode ser maior que 3.");
                }
            }
        }
        public Carta(string Nome, string? Imagem, int? Quantidade)
        {
            this.Nome = Nome;
            this.Imagem = Imagem;
            this.Quantidade = Quantidade;
        }

    }
}
