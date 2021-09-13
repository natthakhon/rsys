import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { country } from '../vm/country';
import { Observable, } from 'rxjs';
import { environment } from '../../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class CountryService {

  private url: string = environment.apiurl;

  constructor(private http: HttpClient) { }

  getcountries(): Observable<country[]> {
    return this.http.get<country[]>(this.url + environment.country);
  }
}
