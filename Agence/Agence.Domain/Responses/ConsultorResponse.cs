﻿using Agence.Core.Model.Response;
using Agence.Domain.DTO;

namespace Agence.Domain.Responses
{
    public class ConsultorResponse : BaseResponse
    {
        public ConsultorResponse()
        {
            this.ConsultorDto = new ConsultorDTO();
        }

        public ConsultorDTO ConsultorDto { get; set; }
    }
}
