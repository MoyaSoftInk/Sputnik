import { Component, OnInit, Inject } from '@angular/core';
import { RelatorioDTO } from 'src/app/models/dto/relatorioDTO';
import { MatDialogRef, MAT_DIALOG_DATA, MatDialogTitle } from '@angular/material';
import { RelatorioGroupInterface } from 'src/app/interface/relatorioGroupInterface';
import { TotalRelatorioInterface } from 'src/app/interface/totalRelatorioInterface';
import { RelatorioDetailInterface } from 'src/app/interface/relatorioDetailInterface';
import { RelatorioInterface } from 'src/app/interface/relatorioInterface';

@Component({
  selector: 'app-relatorio',
  templateUrl: './relatorio.component.html',
  styleUrls: ['./relatorio.component.scss']
})
export class RelatorioComponent implements OnInit {

  relatorioDTOs: RelatorioDTO[];
  displayedColumns = ['periodo', 'receitaLiquida', 'custoFixo', 'comissão', 'lucro'];
  dataSource: any;

  elementData: (TotalRelatorioInterface | RelatorioDetailInterface | RelatorioGroupInterface)[];

  constructor(public dialogRef: MatDialogRef<RelatorioComponent>, @Inject(MAT_DIALOG_DATA) public relatorio: RelatorioInterface) {

    this.elementData = [];
    this.relatorioDTOs = this.relatorio.relatorioDTO;
    this.prepairData();
    this.dataSource = this.elementData;
  }

  ngOnInit() {
    this.elementData = [];
  }

  isGroup(index, item): boolean {
    return item.isGroupBy;
  }
  private prepairData() {

    this.relatorioDTOs.forEach(c => {
      let groupBy: RelatorioGroupInterface = { initial: c.noUsuario, isGroupBy: true };

      groupBy.initial = c.noUsuario;
      groupBy.isGroupBy = true;

      this.elementData.push(new RelatorioGroupInterface(c.noUsuario, true));
      c.relatorioDetails.forEach(p => {
        this.elementData.push(new RelatorioDetailInterface(p.date, p.receitaLiquida, p.custoFixo,
          p.comissao, p.lucro, c.noUsuario));
      });

      this.elementData.push(new RelatorioDetailInterface('Total:', c.totalComissao, c.totalCustoFixo, c.totalLucro,
        c.totalReceitaLiquida, c.noUsuario));
    })
  }

}
