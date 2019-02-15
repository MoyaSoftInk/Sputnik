import { Component, OnInit, ViewChild, EventEmitter, Output } from '@angular/core';
import { ConsultorService } from 'src/app/services/consultor.service';
import { MatTableDataSource, MatSort, MatPaginator } from '@angular/material';
import { Consultor } from 'src/app/models/consultor';

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
  highlightedRows = [];
  consultors: Consultor[];
  @Output() messageEvent = new EventEmitter<Consultor[]>();
  constructor(private consultorService: ConsultorService) { }

  ngOnInit() {
    this.consultors = new Array();
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

  selectedRow(row: Consultor) {

    if (!this.isSelectedRow(row)) {
      this.consultors.push(row);
    } else {
      this.unSelectRow(row);
    }
  }

  unSelectRow(row: Consultor) {
    const index = this.consultors.indexOf(row, 0);
    if (index > -1) {
      this.consultors = this.consultors.splice(index, 1);
    }
  }
  isSelectedRow(row: Consultor): boolean {
    return this.consultors.some(c => c.coUser === row.coUser);
  }

  sendMessage() {
    this.messageEvent.emit(this.consultors)
  }
}
