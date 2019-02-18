export class TotalRelatorioInterface{
  totalReceitaLiquida: number;
  totalCustoFixo: number;
  totalComissao: number;
  totalLucro: number;
  parent: string;

  constructor(totalReceitaLiquida: number, totalComissao: number, totalCustoFixo: number, totalLucro: number, parent: string){
    this.parent = parent;
    this.totalComissao = totalComissao;
    this.totalLucro = totalLucro;
    this.parent = parent;
  }
}
