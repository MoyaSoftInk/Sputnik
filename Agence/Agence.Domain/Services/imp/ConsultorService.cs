namespace Agence.Domain.Services.imp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using Agence.Domain.DTO;
    using Agence.Domain.Models;
    using Agence.Domain.Responses;
    using AutoMapper;

    public class ConsultorService : IConsultorService
    {
        private readonly ICaoUsuarioService caoUsuarioService;
        private readonly IPermissaoSistemaService permissaoSistemaService;

        public ConsultorService( ICaoUsuarioService caoUsuarioService, IPermissaoSistemaService permissaoSistemaService)
        {
            this.caoUsuarioService = caoUsuarioService;
            this.permissaoSistemaService = permissaoSistemaService;
        }

        public ConsultorResponse GetConsultor()
        {
            try
            {
                ConsultorResponse consultorResponse = new ConsultorResponse();
                var permissaoSistema = this.permissaoSistemaService.Get().Where(c => (c.CoTipoUsuario.Equals(0) || c.CoTipoUsuario.Equals(1) || c.CoTipoUsuario.Equals(2)) && c.InAtivo.ToLower().Equals("s") && c.CoSistema.Equals(1));
                IList<CaoUsuarioModel> caoUsuarios = new List<CaoUsuarioModel>();

                CaoUsuarioModel caoUsuario = null;
                foreach (var item in permissaoSistema)
                {
                    caoUsuario = this.caoUsuarioService.Get(item.CoUsuario);
                    if (caoUsuario != null)
                    {
                        caoUsuarios.Add(caoUsuario);
                        caoUsuario = null;
                    }
                }

                if (caoUsuarios.Any())
                {
                    consultorResponse.ConsultorDto.Consultors = Mapper.Map<List<Consultor>>(caoUsuarios);
                    consultorResponse.IsSucceded = true;
                    consultorResponse.Message = "Ok";
                    consultorResponse.StatusCode = HttpStatusCode.OK;
                }
                else
                {
                    consultorResponse.IsSucceded = true;
                    consultorResponse.Message = "No Content";
                    consultorResponse.StatusCode = HttpStatusCode.NoContent;
                }
                return consultorResponse;
            }
            catch(Exception ex)
            {
                ConsultorResponse consultorResponse = new ConsultorResponse();

                consultorResponse.IsSucceded = false;
                consultorResponse.Message = ex.Message;
                consultorResponse.StatusCode = HttpStatusCode.BadRequest;

                return consultorResponse;
            }
        }
    }
}
