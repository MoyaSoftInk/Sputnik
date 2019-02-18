import { BrowserModule } from '@angular/platform-browser';
import { NgModule, Output } from '@angular/core';

import { ReactiveFormsModule, FormsModule } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HomeComponent } from './components/home/home.component';
import { LayoutModule } from '@angular/cdk/layout';
import { HttpClientModule } from '@angular/common/http';
import { DatePipe } from '@angular/common';
import { MatTableModule,
   MatToolbarModule,
   MatButtonModule,
   MatSidenavModule,
   MatIconModule,
   MatListModule,
   MatCardModule,
   MatGridListModule,
   MatPaginatorModule,
   MatSortModule,
   MatInputModule,
   MatFormFieldModule,
   MatCheckboxModule,
   MatSelectModule,
   MatDatepickerModule,
   MatNativeDateModule,
   MatDialogModule} from '@angular/material';
import {NgbModule} from '@ng-bootstrap/ng-bootstrap';
import { ConsultorListComponent } from './components/consultor-list/consultor-list.component';
import { ActionComponent } from './components/action/action.component';
import { RelatorioComponent } from './components/action/relatorio/relatorio.component';
import { GraphicsComponent } from './components/action/graphics/graphics.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    ConsultorListComponent,
    ActionComponent,
    RelatorioComponent,
    GraphicsComponent
  ],
  imports: [
    HttpClientModule,
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    LayoutModule,
    MatToolbarModule,
    MatButtonModule,
    MatSidenavModule,
    MatIconModule,
    MatListModule,
    MatCardModule,
    NgbModule,
    MatGridListModule,
    MatTableModule,
    MatPaginatorModule,
    MatSortModule,
    MatFormFieldModule,
    ReactiveFormsModule,
    FormsModule,
    MatInputModule,
    MatCheckboxModule,
    MatSelectModule,
    MatDatepickerModule,
    MatNativeDateModule,
    MatDialogModule
  ],
  providers: [DatePipe],
  bootstrap: [AppComponent],
  entryComponents:[RelatorioComponent]
})
export class AppModule { }
