﻿

using System;

namespace Model.Entidades
{
    public class RelatorioComprasViewModel
    {
        public string Código { get; set; }
        public string Nome { get; set; }
        public string Descrição { get; set; }
        public Nullable<int> Quantidade { get; set; }
        public Nullable<int> Comprar { get; set; }
      
    }
}
