namespace Agence.Controllers
{
    using Agence.Domain.DTO.Inputs;
    using Agence.Domain.Services;
    using Microsoft.AspNetCore.Cors;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Net;


    [Route("api/Consultor")]
    public class ConsultorController : Controller
    {
        #region Fields

        private readonly IConsultorService consultorService;

        #endregion Fields

        #region Constructors

        public ConsultorController(IConsultorService consultorService)
            : base()
        {
            this.consultorService = consultorService;
        }

        #endregion Constructors

        #region Methods

        [EnableCors("MyPolicy")]
        [HttpGet]
        [Route("GetConsultors")]

        public IActionResult GetContultors()
        {
            try
            {
                var result = this.consultorService.GetConsultor();
                if (result.StatusCode.Equals(HttpStatusCode.OK))
                    return Ok(result);
                else
                    return BadRequest(result);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
                return BadRequest(ModelState);
            }
        }

        [EnableCors("MyPolicy")]
        [HttpPost]
        [Route("GetRelatorio")]
        public IActionResult GetRelatorio([FromBody] RelatorioInput relatorioInput)
        {
            try
            {
                var result = this.consultorService.GetRelatorio(relatorioInput);
                if (result.StatusCode.Equals(HttpStatusCode.OK))
                    return Ok(result);
                else
                    return BadRequest(result);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
                return BadRequest(ModelState);
            }
        }

        [EnableCors("MyPolicy")]
        [HttpPost]
        [Route("GetGraphics")]
        public IActionResult GetGraphics([FromBody] RelatorioInput relatorioInput)
        {
            try
            {
                var result = this.consultorService.GetGraphics(relatorioInput);
                if (result.StatusCode.Equals(HttpStatusCode.OK))
                    return Ok(result);
                else
                    return BadRequest(result);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
                return BadRequest(ModelState);
            }
        }

        #endregion Methods
    }
}
