using MultApps.Models.Entities.Abstract;
using System;

namespace MultApps.Models.Entities

{
    public class Produto : EntidadeBase
    {
        public int CategoriaId { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public string Descricao { get; set; }
        public string Estoque { get; set; }
        public DateTime dataCriacao { get; set; }
        public DateTime dataAlteracao { get; set; }

    }
}
