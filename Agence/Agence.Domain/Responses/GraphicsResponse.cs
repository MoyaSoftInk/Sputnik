namespace Agence.Domain.Responses
{
    using Agence.Core.Model.Response;
    using Agence.Domain.DTO;
    using System.Collections.Generic;

    public class GraphicsResponse : BaseResponse
    {
        public GraphicsResponse()
        {
            this.Graphics = new List<GraphicsDTO>();
        }

        public IList<GraphicsDTO> Graphics { get; set; }
    }
}
