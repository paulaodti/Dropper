using System.Collections.Generic;
using System.Web.Http;
using TCC.Dropper.Dom.Modelos;
using Dropper.Negocio.Interfaces;
using System;
using System.Net;
using Dropper.API.Models;
using TCC.Dropper.Negocio.Interfaces;

namespace DropperAPI.Controllers
{
    public class MedidorVazaoController : ApiController
    {
        private IMedidorValorNegocio medidorValorNegocio;

        public MedidorVazaoController(IMedidorValorNegocio medidorValorNegocio)
        {
            this.medidorValorNegocio = medidorValorNegocio;
        }
        // GET: api/MedicaoVazao
        public IHttpActionResult Get()
        {
            IEnumerable<MedidorVazaoModelo> medidoresVazaoModelo;
            try
            {
                medidoresVazaoModelo = this.medidorValorNegocio.ListarTodosOsSensores();
            }
            catch (Exception exception)
            {
                return Content(HttpStatusCode.BadRequest,
                   ResponseGenerator.GenerateErrorResponse((int)HttpStatusCode.BadRequest,
                    "Erro ao listar sensores.", exception));
            }
            return Ok(ResponseGenerator.GenerateSuccessResponse((int)HttpStatusCode.OK,
                "Recuperação de todos os sensores ocorrida com sucesso", medidoresVazaoModelo));
        }
    }
}
