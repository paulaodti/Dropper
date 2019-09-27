using System.Collections.Generic;
using System.Web.Http;
using TCC.Dropper.Dom.Modelos;
using Dropper.Negocio.Interfaces;
using System;
using System.Net;
using Dropper.API.Models;
using System.Web.Http.Cors;

namespace DropperAPI.Controllers
{
    public class MedicaoVazaoController : ApiController
    {
        private IMedicaoValorNegocio m_IMedicaoValorNegocio;

        public MedicaoVazaoController(IMedicaoValorNegocio p_IMedicaoValorNegocio)
        {
            m_IMedicaoValorNegocio = p_IMedicaoValorNegocio;
        }
        // GET: api/MedicaoVazao
        public IHttpActionResult Get()
        {
            IEnumerable<MedicaoValorModelo> v_medicaoValorModelos;
            try
            {
                v_medicaoValorModelos = m_IMedicaoValorNegocio.listAllFlowMeasurement();
            }
            catch (Exception exception)
            {
                return Content(HttpStatusCode.BadRequest,
                   ResponseGenerator.GenerateErrorResponse((int)HttpStatusCode.BadRequest,
                    "Erro ao medições.", exception));
            }
            return Ok(ResponseGenerator.GenerateSuccessResponse((int)HttpStatusCode.OK,
                "Recuperação de todos as medições ocorrida com sucesso", v_medicaoValorModelos));
        }

        // GET: api/MedicaoVazao/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/MedicaoVazao
        public IHttpActionResult Post([FromBody] MedicaoValorModelo p_MedicaoValorModelo)
        {
            try
            {
                var veiculoModelo = m_IMedicaoValorNegocio.cadastrarValorMedicao(p_MedicaoValorModelo);
                return Ok(ResponseGenerator.GenerateSuccessResponse((int)HttpStatusCode.OK,
                $"Inserção do valor {p_MedicaoValorModelo.CodMedicaoVazaoValor} ocorrida com sucesso", veiculoModelo));
            }
            catch (Exception exception)
            {
                return Content(HttpStatusCode.BadRequest, ResponseGenerator.GenerateErrorResponse((int)HttpStatusCode.BadRequest,
                        "Erro ao inserir valor.", exception));
            }

        }
    }
}
