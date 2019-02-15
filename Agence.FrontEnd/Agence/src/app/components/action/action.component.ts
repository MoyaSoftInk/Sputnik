import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-action',
  templateUrl: './action.component.html',
  styleUrls: ['./action.component.scss']
})
export class ActionComponent implements OnInit {

  @Input() consultors: any[];

  constructor() { }

  ngOnInit() {
  }

}
