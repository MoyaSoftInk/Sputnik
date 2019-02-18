import { Component, OnInit, Input } from '@angular/core';
import { RelatorioInput } from 'src/app/models/inputs/relatorioInput';
import { ConsultorService } from 'src/app/services/consultor.service';
import {MatDialog, MatDialogConfig} from '@angular/material';
import { RelatorioComponent } from './relatorio/relatorio.component';
import { RelatorioDTO } from 'src/app/models/dto/relatorioDTO';


@Component({
  selector: 'app-action',
  templateUrl: './action.component.html',
  styleUrls: ['./action.component.scss']
})
export class ActionComponent implements OnInit {


  @Input() childMessage: RelatorioInput;
  relatorioDTO: RelatorioDTO[];

  constructor(
    private consultorService: ConsultorService,
    private dialog: MatDialog) {
   }

  ngOnInit() {
    this.childMessage = new RelatorioInput();
  }
  // openDialog(): void {
  //   const dialogRef = this.dialog.open(DialogOverviewExampleDialog, {
  //     width: '250px',
  //     data: {name: this.name, animal: this.animal}
  //   });
  relatorio() {
    this.consultorService.getRelatorio(this.childMessage).subscribe(relatorioResponse => {

      this.dialog.open(RelatorioComponent, {width: '700px', data:{relatorioDTO: relatorioResponse.relatorios}});
    });
  }
}
