namespace Agence.Controllers
{
    using Agence.Domain.Services;
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
        
        #endregion Methods
    }
}
