using Mike.Utilities.Desktop;
using Model.Data;
using Model.Entidades;
using System;
using System.Collections.Generic;

namespace Controller.Repositorio
{
    public class RelatorioFiadoRepositorio
    {
        private _DbContext Banco { get; set; }
        public List<RelatorioFiadoViewModel> GerarRelatorioDeFiado(List<RelatorioFiadoViewModel> fiado)
        {

            try
            {
                return fiado;
            }
            catch (CustomException error)
            {
                throw new CustomException(error.Message);
            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }

        }
    }
}
