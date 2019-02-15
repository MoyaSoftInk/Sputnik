import { Injectable } from '@angular/core';
import { Observable, of, from } from 'rxjs';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { catchError, map, tap } from 'rxjs/operators';
import { ConsultorResponse } from '../models/response/consultorResponse';
import { ConsultorDTO } from '../models/dto/consultorDTO';
const httpOptions = {
  headers: new HttpHeaders({ 'Content-Type': 'application/json' })
};

const baseUri = 'https://localhost:44365/api/Consultor/GetConsultors';

@Injectable({
  providedIn: 'root'
})
export class ConsultorService {

  constructor(
    private http: HttpClient,
    ) { }

    /** Get Consultors */
    getConsultors(): Observable<ConsultorResponse> {
      return this.http.get<ConsultorResponse>(baseUri)
        .pipe( catchError(this.handleError<ConsultorResponse>('getConsultors'))
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
