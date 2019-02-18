namespace Agence.Domain.Responses
{
    using Agence.Core.Model.Response;
    using Agence.Domain.DTO;

    public class ConsultorResponse : BaseResponse
    {
        public ConsultorResponse()
        {
            this.ConsultorDto = new ConsultorDTO();
        }

        public ConsultorDTO ConsultorDto { get; set; }
    }
}
