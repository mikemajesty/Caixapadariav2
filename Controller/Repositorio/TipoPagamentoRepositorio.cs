using Controller.Enum;
using Mike.Utilities.Desktop;
using Model.Data;
using Model.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace Controller.Repositorio
{
    public class TipoPagamentoRepositorio
    {
        private readonly _DbContext _banco;

        public TipoPagamentoRepositorio()
        {
            _banco = new _DbContext();
        }

        public int Cadastrar()
        {
            try
            {

                int contador = 0;
                if (VerificarQuantidade() < 3)
                {
                    foreach (TipoPagamento tipo in TipoPagamentoList())
                    {
                        _banco.Entry(tipo).State = EntityState.Added;
                        contador += _banco.SaveChanges();
                    }
                }
                return contador == 3 ? contador : 1;
            }
            catch (CustomException erro)
            {
                throw new CustomException(erro.Message);
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }

        }

        private List<TipoPagamento> TipoPagamentoList()
        {
            try
            {
                return new List<TipoPagamento>()
                {
                    new TipoPagamento(){ Tipo=EnumTipoPagamento.Dinheiro.ToString()},
                     new TipoPagamento(){ Tipo=EnumTipoPagamento.Cartão.ToString()},
                     new TipoPagamento(){Tipo=EnumTipoPagamento.Creditar.ToString()}
                };
            }
            catch (CustomException erro)
            {
                throw new CustomException(erro.Message);
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }

        public int VerificarQuantidade()
        {
            try
            {
                return _banco.TipoPagamento.Count();
            }
            catch (CustomException erro)
            {
                throw new CustomException(erro.Message);
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }

        }


        public void Listar(ComboBox cbb)
        {
            try
            {
                cbb.DisplayMember = "Tipo";
                cbb.DataSource = _banco.TipoPagamento.ToList();
              
            }
            catch (CustomException erro)
            {
                throw new CustomException(erro.Message);
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }

        }
        public void ListarComUmaLinhaEmBranco(ComboBox cbb)
        {
            try
            {

                foreach (var item in _banco.TipoPagamento)
                {
                    cbb.Items.Add(item.Tipo);
                }
                cbb.SelectedIndex = 0;
                
            }
            catch (CustomException erro)
            {
                throw new CustomException(erro.Message);
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }

        }



        public int GetIDPeloNome(string tipo)
        {
            try
            {

               return _banco.TipoPagamento.FirstOrDefault(c=>c.Tipo == tipo).ID;

            }
            catch (CustomException erro)
            {
                throw new CustomException(erro.Message);
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }
    }

}
