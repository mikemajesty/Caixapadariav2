

using System;

namespace Model.Entidades
{
    public class RelatorioComprasViewModel
    {
        public string Código { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public Nullable<int> Quantidade { get; set; }
        public Nullable<int> Comprar { get; set; }
      
    }
}
