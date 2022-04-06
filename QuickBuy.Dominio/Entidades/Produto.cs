using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Produto : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Nome))
            {
                AdicionarCritica("Nome obrigatório.");
            }

            if (string.IsNullOrEmpty(Descricao))
            {
                AdicionarCritica("Descrição obrigatória.");
            }

            if (Preco == 0)
            {
                AdicionarCritica("Preço obrigatório.");
            }
        }
    }
}
