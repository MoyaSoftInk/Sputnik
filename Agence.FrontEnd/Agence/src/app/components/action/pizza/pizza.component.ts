import {
  Component,
  Inject,
  ViewChild,
  ElementRef,
  OnInit
} from '@angular/core';

import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material';

import { GraphicsDTO } from 'src/app/models/dto/GraphicsDTO';
import 'apexcharts';
import { GraphicsInterface } from 'src/app/interface/graphicsInterface';

@Component({
  selector: 'app-pizza',
  templateUrl: './pizza.component.html',
  styleUrls: ['./pizza.component.scss']
})
export class PizzaComponent implements OnInit {

  constructor() { }

  ngOnInit() {
  }

}
