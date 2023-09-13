import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { IPersona } from './IPersona';
@Injectable({
    providedIn: 'root'
})
export class personaService {
    anadirPersonaPOST: string;
    private http: HttpClient;
  
    constructor(httpClient: HttpClient) {
      this.anadirPersonaPOST = 'https://localhost:7191/api/personas';
      this.http = httpClient;
    }
  
    //Realiza el POST de registro
    anadirPersona(registro: IPersona): Observable<any> {
      return this.http.post(this.anadirPersonaPOST, registro);
    }
  } 