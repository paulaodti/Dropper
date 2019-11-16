using System.Collections.Generic;
using System.Web.Http;
using TCC.Dropper.Dom.Modelos;
using Dropper.Negocio.Interfaces;
using System;
using System.Net;
using Dropper.API.Models;

namespace DropperAPI.Controllers
{
    public class VazaoController : ApiController
    {
        private IVazaoNegocio m_IVazaoNegocio;

        public VazaoController(IVazaoNegocio p_IVazaoNegocio)
        {
            m_IVazaoNegocio = p_IVazaoNegocio;
        }
        // GET: api/MedicaoVazao
        public IHttpActionResult Get()
        {
            IEnumerable<VazaoModelo> v_VazaoModelos;
            try
            {
                v_VazaoModelos = m_IVazaoNegocio.listAllFlowMeasurement();
            }
            catch (Exception exception)
            {
                return Content(HttpStatusCode.BadRequest,
                   ResponseGenerator.GenerateErrorResponse((int)HttpStatusCode.BadRequest,
                    "Erro ao medições.", exception));
            }
            return Ok(ResponseGenerator.GenerateSuccessResponse((int)HttpStatusCode.OK,
                "Recuperação de todos as medições ocorrida com sucesso", v_VazaoModelos));
        }

        [Route("api/Vazao/Filtrar")]
        [HttpPost]
        public IHttpActionResult FiltrarVazao(FiltroVazaoModelo filtroVazaoModelo)
        {
            IEnumerable<VazaoModelo> v_VazaoModelos;
            try
            {
                v_VazaoModelos = m_IVazaoNegocio.listFlowMeasurementByFilter(filtroVazaoModelo);
            }
            catch (Exception exception)
            {
                return Content(HttpStatusCode.BadRequest,
                   ResponseGenerator.GenerateErrorResponse((int)HttpStatusCode.BadRequest,
                    "Erro ao medições.", exception));
            }
            return Ok(ResponseGenerator.GenerateSuccessResponse((int)HttpStatusCode.OK,
                "Recuperação de todos as medições ocorrida com sucesso", v_VazaoModelos));
        }

        [HttpPost]
         public IHttpActionResult Post(VazaoModelo p_VazaoModelo)
         {
            try
            {
                VazaoModelo vazaoModelo = m_IVazaoNegocio.cadastrarValorMedicao(p_VazaoModelo);
                return Ok(ResponseGenerator.GenerateSuccessResponse((int)HttpStatusCode.OK,
                $"Inserção do valor {p_VazaoModelo.VALOR} ocorrida com sucesso", vazaoModelo));
            }
            catch (Exception exception)
            {
                return Content(HttpStatusCode.BadRequest, ResponseGenerator.GenerateErrorResponse((int)HttpStatusCode.BadRequest,
                        "Erro ao inserir valor.", exception));
            }
        }

        }
    }
