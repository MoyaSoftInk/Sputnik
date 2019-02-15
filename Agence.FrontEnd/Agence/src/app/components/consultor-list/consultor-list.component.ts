import { Component, OnInit, ViewChild } from '@angular/core';
import { ConsultorService } from 'src/app/services/consultor.service';
import { MatTableDataSource, MatSort, MatPaginator } from '@angular/material';
import {SelectionModel} from '@angular/cdk/collections';

export interface PeriodicElement {
  coUser: string;
  noUser: string;
}

@Component({
  selector: 'app-consultor-list',
  templateUrl: './consultor-list.component.html',
  styleUrls: ['./consultor-list.component.scss']
})
export class ConsultorListComponent implements OnInit {

  listData: MatTableDataSource<any>;
  displayedColumns: string[] = ['coUser', 'select', 'noUser'];
  @ViewChild(MatSort) sort: MatSort;
  @ViewChild(MatPaginator) paginator: MatPaginator;
  searchKey: string;
  selection = new SelectionModel<PeriodicElement>(true, []);
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
    this.searchKey = '';
    this.applyFilter();
  }

  applyFilter() {
    this.listData.filter = this.searchKey.trim().toLowerCase();
  }
  /** Whether the number of selected elements matches the total number of rows. */
  isAllSelected() {
    const numSelected = this.selection.selected.length;
    const numRows = this.listData.data.length;
    return numSelected === numRows;
  }

  /** Selects all rows if they are not all selected; otherwise clear selection. */
  masterToggle() {
    this.isAllSelected() ?
        this.selection.clear() :
        this.listData.data.forEach(row => this.selection.select(row));
  }

}
