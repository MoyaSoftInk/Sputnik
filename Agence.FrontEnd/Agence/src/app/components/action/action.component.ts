import { Component, OnInit, Input } from '@angular/core';
import { Consultor } from 'src/app/models/consultor';
import { RelatorioInput } from 'src/app/models/inputs/relatorioInput';
import { ConsultorService } from 'src/app/services/consultor.service';

@Component({
  selector: 'app-action',
  templateUrl: './action.component.html',
  styleUrls: ['./action.component.scss']
})
export class ActionComponent implements OnInit {


  @Input() childMessage: RelatorioInput;

  constructor(private consultorService: ConsultorService) {
   }

  ngOnInit() {
    this.childMessage = new RelatorioInput();
  }

  relatorio() {
    console.log(this.childMessage);
    this.consultorService.getRelatorio(this.childMessage).subscribe(relatorioResponse => {
      console.log(relatorioResponse);
    });
  }
}
