using System;
namespace Model.Entidades
{
    public class RelatorioFiadoViewModel
    {
        public DateTime Data { get; } = DateTime.Now;
        public string Produto { get; set; }
        public decimal Valor { get; set; }
        public string Quantidade { get; set; }
    }
}
