namespace Agence.Domain.Mapper
{
    using Agence.Domain.DTO;
    using Agence.Domain.Entities;
    using Agence.Domain.Models;
    using AutoMapper;


    public class ConfigureAutoMapper
    {
        #region Methods

        public static void Now()
        {
            Mapper.Initialize(cfg =>
            {
                #region Entity to Model

                cfg.CreateMap<CaoUsuario, CaoUsuarioModel>();
                cfg.CreateMap<PermissaoSistema, PermissaoSistemaModel>();

                #endregion

                #region Model to Entity

                cfg.CreateMap<CaoUsuarioModel, CaoUsuario>();
                cfg.CreateMap<PermissaoSistemaModel, PermissaoSistema>();

                #endregion

                #region Model to DTO

                cfg.CreateMap<CaoUsuarioModel, Consultor>()
                    .ForMember(x => x.CoUser, x => x.MapFrom(y => y.CoUsuario))
                    .ForMember(x => x.NoUser, x => x.MapFrom(y => y.NoUsuario));

                #endregion
            });
            
        }

        #endregion Methods
    }
   
}
