import { Component, OnInit, Input } from '@angular/core';
import { RelatorioInput } from 'src/app/models/inputs/relatorioInput';
import { ConsultorService } from 'src/app/services/consultor.service';
import {MatDialog, MatDialogConfig} from '@angular/material';
import { RelatorioComponent } from './relatorio/relatorio.component';
import { RelatorioDTO } from 'src/app/models/dto/relatorioDTO';
import { GraphicsComponent } from './graphics/graphics.component';


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
    private RelatorioDialog: MatDialog,
    private GraphicsDialog: MatDialog,
    private PizzaDialog: MatDialog) {
   }

  ngOnInit() {
    this.childMessage = new RelatorioInput();
  }
  relatorio() {
    this.consultorService.getRelatorio(this.childMessage).subscribe(relatorioResponse => {

      this.RelatorioDialog.open(RelatorioComponent, {width: '70%', data:{relatorioDTO: relatorioResponse.relatorios}});
    });
  }

  graphics() {
    this.consultorService.getGraphics(this.childMessage).subscribe(graphicsResponse =>{
      this.GraphicsDialog.open(GraphicsComponent, {width: '50%', data:{graphicsDTO: graphicsResponse.graphics}});
    })
  }
}
