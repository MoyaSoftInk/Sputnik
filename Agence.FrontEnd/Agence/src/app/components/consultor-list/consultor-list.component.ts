import { Component, OnInit, ViewChild } from '@angular/core';
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
  @ViewChild(MatSort) sort: MatSort;
  @ViewChild(MatPaginator) paginator: MatPaginator;
  searchKey: string;

  constructor(private consultorService: ConsultorService) { }

  ngOnInit() {
    this.consultorService.getConsultors().subscribe(ConsultorResponse => {
      this.listData = new MatTableDataSource(ConsultorResponse.consultorDto.consultors);
      this.listData.sort = this.sort;
      this.listData.paginator = this.paginator;
      this.listData.filterPredicate = (data, filter) => {
        return this.displayedColumns.some(ele => {
          return data[ele].toLowerCase().indexOf(filter) !== -1;
        });
      };
    });
  }

  onSearchClear() {
    this.searchKey = "";
    this.applyFilter();
  }

  applyFilter() {
    this.listData.filter = this.searchKey.trim().toLowerCase();
  }

}
