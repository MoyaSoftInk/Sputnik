export class RelatorioDetailInterface{
  date: string;
  receitaLiquida: number;
  custoFixo: number;
  comissao: number;
  lucro: number;
  parent: string;

  constructor(date: string, receitaLiquida: number, custoFixo: number, comissao: number, lucro: number, parent: string){
    this.date = date;
    this.receitaLiquida = receitaLiquida;
    this.custoFixo = custoFixo;
    this.comissao = comissao;
    this.lucro = lucro;
    this.parent = parent;
  }
}
