import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { businesstype } from '../vm/businesstype';
import { Observable, } from 'rxjs';
import { environment } from '../../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class BusinesstypeService {

  private url: string = environment.apiurl;

  constructor(private http: HttpClient) { }

  getbusinesstypes(): Observable<businesstype[]> {
    return this.http.get<businesstype[]>(this.url + environment.businesstype);
  }
}
