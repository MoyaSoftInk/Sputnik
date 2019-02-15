import { Component, OnInit } from '@angular/core';
import { BreakpointObserver, Breakpoints } from '@angular/cdk/layout';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { Consultor } from 'src/app/models/consultor';
import { RelatorioInput } from 'src/app/models/inputs/relatorioInput';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  relatorioInput: RelatorioInput;

  isHandset$: Observable<boolean> = this.breakpointObserver.observe(Breakpoints.Handset)
    .pipe(
      map(result => result.matches)
    );

  constructor(
    private breakpointObserver: BreakpointObserver) {
    this.relatorioInput = new RelatorioInput();
    this.relatorioInput.consultor = new Array();

  }

  ngOnInit(): void {
    this.relatorioInput = new RelatorioInput();
    this.relatorioInput.consultor = new Array();
  }

  receiveMessage($event) {
    this.relatorioInput = $event
  }
}
