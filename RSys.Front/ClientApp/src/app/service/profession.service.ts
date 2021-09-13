import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { profession } from '../vm/profession';
import { Observable, } from 'rxjs';
import { environment } from '../../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class ProfessionService {

  private url: string = environment.apiurl;

  constructor(private http: HttpClient) { }

  getprofessions(): Observable<profession[]> {
    return this.http.get<profession[]>(this.url + environment.profession);
  }
}
