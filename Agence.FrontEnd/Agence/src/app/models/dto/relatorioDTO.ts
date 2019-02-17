import { RelatorioDetail } from '../relatorioDetail';

export class RelatorioDTO {

  coUsuario: string;
  noUsuario: string;
  totalReceitaLiquida: number;
  totalCustoFixo: number;
  totalComissao: number;
  totalLucro: number;
  relatorioDetails: RelatorioDetail[];
}
