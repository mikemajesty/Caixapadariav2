using System;

namespace Model.Entidades
{
    public class SangriaViewModel
    {
        public int ID { get; set; }
        public string Usuário { get; set; }
        public DateTime Data { get; set; }
        public decimal Valor { get; set; }
        public string Descricao { get; set; }
    }
}
