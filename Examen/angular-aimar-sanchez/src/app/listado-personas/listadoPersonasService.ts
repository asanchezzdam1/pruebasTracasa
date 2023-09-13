import { Injectable } from '@angular/core'
import { HttpClient, HttpErrorResponse, HttpHeaders } from '@angular/common/http';
import { Observable, throwError } from "rxjs";
import { catchError, tap } from 'rxjs/operators';
import { IPersona } from './IPersona';

@Injectable({
    providedIn: 'root'
})

export class listadoPersonasService {
    verURL!:string;

  private http: HttpClient;
  
  
  constructor(httpClient: HttpClient) {
    this.verURL = 'https://localhost:7191/api/personas/ultimos10';
    this.http = httpClient;
    
  }
  

  get10UltimosRegistros(): Observable<IPersona[]> {
    return this.http.get<IPersona[]>(this.verURL).pipe(
      catchError(this.handleError)
    );
  }

  private handleError(err: HttpErrorResponse): Observable<never> {
    let errorMessage = '';
    if (err.error instanceof ErrorEvent) {
      errorMessage = `An error occurred: ${err.error.message}`;
    } else {
      errorMessage = `Server returned code: ${err.status}, error message is: ${err.message}`;
    }
    console.error(errorMessage);
    return throwError(errorMessage);
  }

}
