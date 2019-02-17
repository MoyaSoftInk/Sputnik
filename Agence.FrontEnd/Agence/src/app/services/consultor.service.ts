import { Injectable } from '@angular/core';
import { Observable, of, from } from 'rxjs';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { catchError, map, tap } from 'rxjs/operators';
import { ConsultorResponse } from '../models/response/consultorResponse';
import { RelatorioResponse } from '../models/response/relatorioResponse';
import { Consultor } from '../models/consultor';
import { RelatorioInput } from '../models/inputs/relatorioInput';
const httpOptions = {
  headers: new HttpHeaders({ 'Content-Type': 'application/json' })
};

const baseUri = 'https://localhost:44365/api/Consultor/';

@Injectable({
  providedIn: 'root'
})
export class ConsultorService {

  consultors: Consultor[];
  relatorioInput: RelatorioInput;

  constructor(
    private http: HttpClient,
    ) {
      this.relatorioInput = new RelatorioInput();
    }

    /** Get Consultors */
    getConsultors(): Observable<ConsultorResponse> {
      return this.http.get<ConsultorResponse>(baseUri + 'GetConsultors')
        .pipe( catchError(this.handleError<ConsultorResponse>('getConsultors'))
        );
    }

    /** Get Relatorio */
    getRelatorio(relatorioInput: RelatorioInput): Observable<RelatorioResponse> {
      const body = JSON.stringify(relatorioInput);
      return (
        this.http.post<RelatorioResponse>(baseUri + 'GetRelatorio', body, httpOptions)
        .pipe( catchError( this.handleError<RelatorioResponse>('GetRelatorio') ) )
      );
    }

  /**
   * Handle Http operation that failed.
   * Let the app continue.
   * @param operation - name of the operation that failed
   * @param result - optional value to return as the observable result
   */
  private handleError<T>(operation = 'operation', result?: T) {
    return (error: any): Observable<T> => {

      // TODO: send the error to remote logging infrastructure
      console.error(error); // log to console instead

      // Let the app keep running by returning an empty result.
      return of(result as T);
    };
  }
}
