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
  selector: 'app-graphics',
  templateUrl: './graphics.component.html',
  styleUrls: ['./graphics.component.scss']
})
export class GraphicsComponent implements OnInit {

  data = [];
  custoFixo = [];
  categories = [];
  lastDate = 0;
  title = 'sonar-trading';
  graphics: GraphicsDTO[];
  isPizza: boolean;

  @ViewChild('chart')
  chart: ElementRef;
  constructor(public dialogRef: MatDialogRef<GraphicsComponent>, @Inject(MAT_DIALOG_DATA) public graphicsInterface: GraphicsInterface) {


    this.graphics = this.graphicsInterface.graphicsDTO;
    this.isPizza = this.graphicsInterface.isPizza;
    this.prepairData();
  }

  ngOnInit() {

    if (this.isPizza) {
      this.buildGraphicPizza();
    }
    else {
      this.buildGraphicColums();
    }


  }

  getDayWiseTimeSeries(baseval, count, yrange) {
    let i = 0;
    while (i < count) {
      const x = baseval;
      const y =
        Math.floor(Math.random() * (yrange.max - yrange.min + 1)) + yrange.min;
      this.data.push({
        x,
        y,
      });
      this.lastDate = baseval;
      baseval += 86400000;
      i++;
    }
  }

  prepairData() {
    this.graphics.forEach(c => {
      this.data.push(c.receita);
      this.categories.push(c.noUsuario);
      this.custoFixo.push(c.promCustoFixo);
    });
  }

  private buildGraphicColums() {
    var options = {
      annotations: {
        points: [{
          x: '',
          seriesIndex: 0,
          label: {
            borderColor: '#775DD0',
            offsetY: 0,
            style: {
              color: '#fff',
              background: '#775DD0',
            },
            text: '',
          }
        }]
      },
      chart: {
        height: 350,
        type: 'bar',
      },
      plotOptions: {
        bar: {
          columnWidth: '50%',
          endingShape: 'rounded'
        }
      },
      dataLabels: {
        enabled: false
      },
      stroke: {
        width: 2
      },
      series: [{
        name: 'Receita Liquida',
        type: 'column',
        data: this.data
      },
      {
        name: 'Custo Fixo',
        type: 'line',
        data: this.custoFixo
      }],
      grid: {
        row: {
          colors: ['#fff', '#f2f2f2']
        }
      },
      xaxis: {
        labels: {
          rotate: -10
        },
        categories: this.categories,
      },
      yaxis: {
        title: {
          text: 'Receita Liquida.',
        },

      },
      fill: {
        type: 'gradient',
        gradient: {
          shade: 'light',
          type: "horizontal",
          shadeIntensity: 0.25,
          gradientToColors: undefined,
          inverseColors: true,
          opacityFrom: 0.85,
          opacityTo: 0.85,
          stops: [50, 0, 100]
        },
      },

    }
    const chart = new ApexCharts(this.chart.nativeElement, options);
    chart.render();
    const dataPointsLength = 10;
  }

  private buildGraphicPizza() {
    var options = {
      chart: {
        width: 400,
        type: 'pie',
      },
      labels: this.categories,
      series: this.data,
      legend:{
        position: 'bottom'
      },
      responsive: [{
        breakpoint: 200,
        options: {
          chart: {
            width: 200
          },
          legend: {
            position: 'bottom'
          }
        }
      }]
    }
    const chart = new ApexCharts(this.chart.nativeElement, options);
    chart.render();
    const dataPointsLength = 10;
  }
}

