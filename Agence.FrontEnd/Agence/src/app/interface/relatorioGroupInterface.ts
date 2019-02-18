export class RelatorioGroupInterface{
  initial: string;
  isGroupBy: boolean;

  constructor(initial: string, isGroupBy: boolean){
    this.initial = initial;
    this.isGroupBy = isGroupBy
  }
}
