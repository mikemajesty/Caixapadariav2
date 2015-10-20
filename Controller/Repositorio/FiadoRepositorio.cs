using Mike.Utilities.Desktop;
using Model.Data;
using Model.Entidades;
using System;
using System.Data.Entity;
using System.Windows.Forms;
using System.Linq;
namespace Controller.Repositorio
{
    public class FiadoRepositorio
    {
        private _DbContext _banco;
        private FiadoRepositorio _fiadoRepositorio;
        private Fiado _fiado;
        private void InstanciarBanco()
        {
            _banco = new _DbContext();
        }
        private void InstanciarFiadoRepositorio()
        {
            _fiadoRepositorio = new FiadoRepositorio();
        }
        private void InstanciarFiado()
        {
            _fiado = new Fiado();
        }
        public int Cadastrar(Fiado fiado)
        {
            try
            {
                int retorno = 0;
                InstanciarBanco();               
                _fiado = _banco.Fiado.FirstOrDefault(c => c.IDCliente == fiado.IDCliente);
                if (_fiado != null)
                {
                   
                        fiado.ID = _fiado.ID;
                        InstanciarBanco(); 
                        fiado.Valor += _fiado.Valor;
                        if (fiado.Valor <= 0)
                        {
                            _banco.Entry(fiado).State = EntityState.Deleted;
                            retorno = _banco.SaveChanges();
                        }
                        else
                        {
                            _banco.Entry(fiado).State = EntityState.Modified;
                            retorno = _banco.SaveChanges();
                        }
                   
                }               
                else
                {
                    _banco.Entry(fiado).State = EntityState.Added;
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
        public void ListarCreditos(DataGridView dgv)
        {
            try
            {




                InstanciarBanco();
                dgv.DataSource = (from fia in _banco.Fiado
                                  join cli in _banco.Cliente on new { IDCLIENTE = fia.IDCliente } equals new { IDCLIENTE = cli.ID }
                                  where
                                    fia.Valor > 0
                                  group new { cli, fia } by new
                                  {
                                      cli.Nome,
                                      cli.Celular,
                                      cli.CPF,
                                      cli.ID
                                  } into g
                                  select new
                                  {
                                      g.Key.ID,
                                      g.Key.Nome,
                                      g.Key.Celular,
                                      g.Key.CPF,
                                      Total = g.Sum(p => p.fia.Valor)
                                  }).Distinct().ToList();


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

        public void PesquisarCreditosPorNome(DataGridView dgv, string nome)
        {
            try
            {
                InstanciarBanco();
                dgv.DataSource = (from cli in _banco.Cliente
                                  join fia in _banco.Fiado on cli.ID equals fia.IDCliente
                                  where fia.Valor > 0 && cli.Nome.Contains(nome)
                                  select new { Nome = cli.Nome, CPF = cli.CPF, Valor = fia.Valor });


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

        public Fiado PesquisarFiadoPeloID(int id)
        {
            try
            {
                InstanciarBanco();
                return _banco.Fiado.FirstOrDefault(c => c.IDCliente == id);


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

        public int Alterar(Fiado fiado)
        {
            try
            {
                int retorno = 0;
                InstanciarBanco();
                decimal valor = _banco.Fiado.Find(fiado.ID).Valor;
                valor -= fiado.Valor;
                if (valor <= 0)
                {
                    InstanciarBanco();
                    _banco.Entry(fiado).State = EntityState.Deleted;
                    retorno = _banco.SaveChanges();
                }
                else
                {
                    fiado.Valor = valor;
                    InstanciarBanco();
                    _banco.Entry(fiado).State = EntityState.Modified;
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

        public int GetQuantidade()
        {
            try
            {
                InstanciarBanco();
                return _banco.Fiado.Count();

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




        public decimal GetValorPeloIDDoCliente(int idCliente)
        {
            try
            {
                InstanciarBanco();
                Fiado fiado = _banco.Fiado.FirstOrDefault(c=>c.IDCliente == idCliente);
                return fiado == null ? 0 : fiado.Valor;
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

        public void ListarClientePorNomePagar(DataGridView dgvCliente, string nome)
        {
       
            try
            {




                InstanciarBanco();
                dgvCliente.DataSource = (from fia in _banco.Fiado
                                  join cli in _banco.Cliente on new { IDCLIENTE = fia.IDCliente } equals new { IDCLIENTE = cli.ID }
                                  where
                                    fia.Valor > 0 && cli.Nome.Contains(nome)
                                  group new { cli, fia } by new
                                  {
                                      cli.Nome,
                                      cli.Celular,
                                      cli.CPF,
                                      cli.ID
                                  } into g
                                  select new
                                  {
                                      g.Key.ID,
                                      g.Key.Nome,
                                      g.Key.Celular,
                                      g.Key.CPF,
                                      Total = g.Sum(p => p.fia.Valor)
                                  }).Distinct().ToList();


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
