import { Component, OnInit } from '@angular/core';
import { BreakpointObserver, Breakpoints } from '@angular/cdk/layout';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { ConsultorService } from 'src/app/services/consultor.service';
import { MatTableDataSource, MatSort, MatPaginator } from '@angular/material';

@Component({
  selector: 'app-consultor-list',
  templateUrl: './consultor-list.component.html',
  styleUrls: ['./consultor-list.component.scss']
})
export class ConsultorListComponent implements OnInit {

  listData: MatTableDataSource<any>;
  displayedColumns: string[] = ['coUser', 'noUser'];

  constructor(private consultorService: ConsultorService) { }

  ngOnInit() {
     this.consultorService.getConsultors().subscribe( ConsultorResponse => {
      this.listData = new MatTableDataSource(ConsultorResponse.consultorDto.consultors);
    });
  }

}
