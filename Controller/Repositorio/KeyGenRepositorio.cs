using Mike.Utilities.Desktop;
using Model.BO;
using Model.Data;
using Model.Entidades;
using System;
using System.Data.Entity;
using System.Linq;

namespace Controller.Repositorio
{
    public class KeyGenRepositorio
    {
        private _DbContext _banco;
        private KeyGenBO _keyGenBo;
        private void InstanciarBanco()
        {
            _banco = new _DbContext();
        }
        private void InstanciarKeyGenBO()
        {
            _keyGenBo = new KeyGenBO();
        }
        public int DeletarDatas()
        {
            try
            {

                InstanciarBanco();
                var datas = _banco.Datas;
                int retorno = 0;
                foreach (var item in datas)
                {
                    _banco.Datas.Remove(item);
                    retorno += _banco.SaveChanges();
                }
                return retorno;
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
                return _banco.Datas.Count();

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

        public int InsertDatas(Datas datas)
        {
            try
            {
                InstanciarKeyGenBO();
                int retorno = 0;
                if (_keyGenBo.VerificaSeExisteDatas(datas) == null)
                {
                    InstanciarBanco();
                    _banco.Entry(datas).State = EntityState.Added;
                    retorno = _banco.SaveChanges();
                }
                return retorno;

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


        public int GetDiasTrail()
        {
            try
            {
                InstanciarBanco();
                int dias = 30 -_banco.Datas.Count();
                return dias;

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

