using Mike.Utilities.Desktop;
using Model.Data;
using Model.Entidades;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace Controller.Repositorio
{
    public class CaixaRepositorio
    {
        private _DbContext _banco;
        private const int Sucesso = 1, Insucesso = 0;
        private void InstanciarBanco()
        {
            _banco = new _DbContext();
        }

        public int Cadastrar(Caixa caixa)
        {
            try
            {
                if (this.GetQuantidade() > 0)
                {
                    caixa.ID = GetQuantidade();
                    caixa.Valor += GetValor().Valor;
                    InstanciarBanco();
                    _banco.Entry(caixa).State = EntityState.Modified;
                    return _banco.SaveChanges() == Sucesso ? Sucesso : Insucesso;
                }
                else
                {

                    InstanciarBanco();
                    _banco.Entry(caixa).State = EntityState.Added;
                    return _banco.SaveChanges() == Sucesso ? Sucesso : Insucesso;
                }

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
        public int GetQuantidade()
        {
            try
            {

                InstanciarBanco();
                Caixa caixa = _banco.Caixa.FirstOrDefault();
                return caixa == null ? 0 : caixa.ID;
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
        public void Listar(DataGridView dgv)
        {
            try
            {

                InstanciarBanco();
                dgv.DataSource = _banco.Caixa.ToList();
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
        public Caixa GetValor()
        {
            try
            {

                InstanciarBanco();
                Caixa caixa = _banco.Caixa.FirstOrDefault();
                return caixa;
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

        public int Alterar(Caixa caixa)
        {
            try
            {

                InstanciarBanco();
                caixa.Valor = 0;
                _banco.Entry(caixa).State = EntityState.Modified;
                return _banco.SaveChanges();
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
