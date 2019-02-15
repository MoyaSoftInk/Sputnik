import { Component, OnInit } from '@angular/core';
import { BreakpointObserver, Breakpoints } from '@angular/cdk/layout';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  isHandset$: Observable<boolean> = this.breakpointObserver.observe(Breakpoints.Handset)
    .pipe(
      map(result => result.matches)
    );

  constructor(
    private breakpointObserver: BreakpointObserver) {
  }

  ngOnInit(): void {
    // this.consultorService.getConsultors().subscribe( ConsultorResponse => {
    //   ConsultorResponse.consultorDto.consultors.forEach(element => {
    //     this.consoleConsultors(element.noUser);
    //   });
    // });
  }
  // consoleConsultors(data: string): void {
  //   console.log(data);
  // }
}
