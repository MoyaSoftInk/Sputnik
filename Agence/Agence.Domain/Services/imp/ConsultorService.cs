namespace Agence.Domain.Services.imp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using Agence.Domain.DTO;
    using Agence.Domain.DTO.Inputs;
    using Agence.Domain.Models;
    using Agence.Domain.Responses;
    using AutoMapper;

    public class ConsultorService : IConsultorService
    {
        private readonly ICaoUsuarioService caoUsuarioService;
        private readonly IPermissaoSistemaService permissaoSistemaService;
        private readonly ICaoOsService caoOsService;
        private readonly ICaoSalarioService caoSalarioService;
        private readonly ICaoFaturaService caoFaturaService;

        private IDictionary<int, string> dateMonthDictionary = new Dictionary<int, string>();

        public ConsultorService( ICaoUsuarioService caoUsuarioService, IPermissaoSistemaService permissaoSistemaService, ICaoOsService caoOsService, ICaoSalarioService caoSalarioService, ICaoFaturaService caoFaturaService)
        {
            this.caoUsuarioService = caoUsuarioService;
            this.permissaoSistemaService = permissaoSistemaService;
            this.caoOsService = caoOsService;
            this.caoSalarioService = caoSalarioService;
            this.caoFaturaService = caoFaturaService;

            dateMonthDictionary[1] = "Janeiro de ";
            dateMonthDictionary[2] = "fevereiro de ";
            dateMonthDictionary[3] = "março de ";
            dateMonthDictionary[4] = "abril de ";
            dateMonthDictionary[5] = "maio de ";
            dateMonthDictionary[6] = "junho de ";
            dateMonthDictionary[7] = "julho de ";
            dateMonthDictionary[8] = "agosto de ";
            dateMonthDictionary[9] = "setembro de ";
            dateMonthDictionary[10] = "outubro de ";
            dateMonthDictionary[11] = "novembro de ";
            dateMonthDictionary[12] = "dezembro de ";
        }

        #region Public Methods

        /// <summary>
        /// List consultors
        /// </summary>
        /// <returns></returns>
        public ConsultorResponse GetConsultor()
        {
            ConsultorResponse consultorResponse = new ConsultorResponse();
            try
            {                
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
            }
            catch (Exception ex)
            {
                consultorResponse.IsSucceded = false;
                consultorResponse.Message = ex.Message;
                consultorResponse.StatusCode = HttpStatusCode.BadRequest;
            }


            return consultorResponse;
        }

        /// <summary>
        /// Get relatorio of consultors
        /// </summary>
        /// <param name="relatorioInput"></param>
        /// <returns></returns>
        public RelatorioResponse GetRelatorio(RelatorioInput relatorioInput)
        {
            RelatorioResponse relatorioResponse = new RelatorioResponse();
            DateTime dateInit = DateTime.Parse(relatorioInput.DateInit);
            DateTime dateEndt = DateTime.Parse(relatorioInput.DateEnd);

            try
            {
                foreach(var consultor in relatorioInput.Consultors)
                {
                    GetRelatorio(ref relatorioResponse, consultor.CoUser, dateInit, dateEndt);
                }

                if (relatorioResponse.Relatorios.Any())
                {
                    relatorioResponse.IsSucceded = true;
                    relatorioResponse.Message = "Ok";
                    relatorioResponse.StatusCode = HttpStatusCode.OK;
                }
                else
                {
                    relatorioResponse.IsSucceded = true;
                    relatorioResponse.Message = "No Content";
                    relatorioResponse.StatusCode = HttpStatusCode.NoContent;
                }
            }
            catch(Exception ex)
            {
                relatorioResponse.IsSucceded = false;
                relatorioResponse.Message = ex.Message;
                relatorioResponse.StatusCode = HttpStatusCode.BadRequest;
            }
            return relatorioResponse;
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Obtain the relatorio by coUser
        /// </summary>
        /// <param name="relatorioRespons"></param>
        /// <param name="coUsuarioId"></param>
        /// <param name="dateInit"></param>
        /// <param name="endDate"></param>
        private void GetRelatorio(ref RelatorioResponse relatorioRespons, string coUsuarioId, DateTime dateInit, DateTime endDate)
        {
            IList<CaoFaturaModel> faturas = this.caoFaturaService.Get();
            IList<CaoOsModel> coOs = this.caoOsService.Get().Where(c=>c.CoUsuario.Equals(coUsuarioId)).ToList();
            
            RelatorioDTO relatorioDTO = new RelatorioDTO();

            relatorioDTO.CoUsuario = coUsuarioId;
            relatorioDTO.NoUsuario = this.caoUsuarioService.Get(coUsuarioId).NoUsuario;

            var result =
                (
                    from fatura in faturas 
                    join os in coOs 
                    on fatura.CoOs equals os.CoOs  into ordersService
                    where(fatura.DataEmissao >= dateInit.Date && fatura.DataEmissao <= endDate.Date)
                    from listOrderService in ordersService
                    select new
                    {
                        fatura,
                        listOrderService.CoUsuario
                    }
                ).OrderBy(p=>p.fatura.DataEmissao).GroupBy(c=>c.fatura.DataEmissao.Year);
            
            foreach(var faturasByYear in result)
            {
                var faturasGroupByMonth = faturasByYear.GroupBy(c=>c.fatura.DataEmissao.Month);
                foreach(var faturasByMonth in faturasGroupByMonth)
                {
                    relatorioDTO.RelatorioDetails.Add(this.CalculateRelatorioDetail(faturasByMonth.Select(c=>c.fatura).ToList(), coUsuarioId, faturasByMonth.Key, faturasByYear.Key));
                }
            }

            this.CalculateRelatorio(ref relatorioDTO);

            relatorioRespons.Relatorios.Add(relatorioDTO);
        }

        /// <summary>
        /// Calculate relatorio detail
        /// </summary>
        /// <param name="caoFaturas"></param>
        /// <param name="coUserId"></param>
        /// <param name="month"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        private RelatorioDetail CalculateRelatorioDetail(IList<CaoFaturaModel> caoFaturas, string coUserId, int month, int year)
        {
            RelatorioDetail relatorioDetail = new RelatorioDetail();          
            
            relatorioDetail.Date = dateMonthDictionary[month] + year.ToString();

            var salario = this.caoSalarioService.Get().Where(c => c.CoUsuario.Equals(coUserId) && c.DtAlteracao.Month.Equals(month) && c.DtAlteracao.Year.Equals(year)).FirstOrDefault();

            //Calculate Cust Fixo
            if (salario != null)
            {
                relatorioDetail.CustoFixo = (decimal)salario.BrutSalario;
            }

            //Calculate Receita Liquida, Comissao and Lucro
            foreach (var faturas in caoFaturas)
            {
                relatorioDetail.ReceitaLiquida += (decimal)(faturas.Valor - ((faturas.TotalImpInc / 100) * faturas.Valor));
                relatorioDetail.Comissao += (decimal)((faturas.Valor - ( ( faturas.TotalImpInc / 100 ) * faturas.Valor ) ) * ( faturas.ComissaoCn/100 ) );
            }
            relatorioDetail.Lucro = relatorioDetail.ReceitaLiquida - (relatorioDetail.CustoFixo + relatorioDetail.Comissao); 

            return relatorioDetail;
        }

        /// <summary>
        /// Calculate Total relatorio.
        /// </summary>
        /// <param name="relatorioDTO"></param>
        private void CalculateRelatorio(ref RelatorioDTO relatorioDTO)
        {
            relatorioDTO.TotalReceitaLiquida = relatorioDTO.RelatorioDetails.Sum(c => c.ReceitaLiquida);
            relatorioDTO.TotalLucro = relatorioDTO.RelatorioDetails.Sum(c => c.Lucro);
            relatorioDTO.TotalComissao = relatorioDTO.RelatorioDetails.Sum(c => c.Comissao);
            relatorioDTO.TotalCustoFixo = relatorioDTO.RelatorioDetails.Sum(c => c.CustoFixo);
        }
        #endregion
    }
}
