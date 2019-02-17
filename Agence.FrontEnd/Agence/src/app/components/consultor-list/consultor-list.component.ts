import { Component, OnInit, ViewChild, EventEmitter, Output } from '@angular/core';
import { ConsultorService } from 'src/app/services/consultor.service';
import { MatTableDataSource, MatSort, MatPaginator } from '@angular/material';
import { Consultor } from 'src/app/models/consultor';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { RelatorioInput } from 'src/app/models/inputs/relatorioInput';
import { DatePipe } from '@angular/common';

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
  relatorioInput: RelatorioInput;
  dateInit: string;
  dateEnd: string;

  @Output() messageEvent = new EventEmitter<RelatorioInput>();

  formGroup = new FormGroup({
    initDate: new FormControl(''),
    endDate: new FormControl('')
  });

  constructor(
    private consultorService: ConsultorService,
    public datepipe: DatePipe) {
    this.relatorioInput = new RelatorioInput();
    this.relatorioInput.Consultors = new Array();
  }

  initializeFormGroup() {
    this.formGroup.setValue({
      initDate: '',
      endDate: ''
    });
  }

  ngOnInit() {
    this.relatorioInput = new RelatorioInput();
    this.relatorioInput.Consultors = new Array();

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
      this.relatorioInput.Consultors.push(row);
    } else {
      this.unSelectRow(row);
    }
  }

  unSelectRow(row: Consultor) {
    const index = this.relatorioInput.Consultors.indexOf(row, 0);
    if (index > -1) {
      this.relatorioInput.Consultors = this.relatorioInput.Consultors.splice(index, 1);
    }
  }
  isSelectedRow(row: Consultor): boolean {
    return this.relatorioInput.Consultors.some(c => c.coUser === row.coUser);
  }

  sendMessage() {
    console.log(this.dateInit);
    this.relatorioInput.DateInit = this.changeFormatDate(this.dateInit);
    console.log(this.dateEnd);
    this.relatorioInput.DateEnd = this.changeFormatDate(this.dateEnd);
    this.messageEvent.emit(this.relatorioInput);
  }

  private changeFormatDate(date: string): string {
    return this.datepipe.transform(date, 'yyyy-MM-dd');
  }
}
