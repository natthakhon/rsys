import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { title } from '../vm/title';
import { Observable, } from 'rxjs';
import { environment } from '../../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class TitleService {

  private url: string = environment.apiurl;

  constructor(private http: HttpClient) { }

  gettitles(): Observable<title[]> {
    return this.http.get<title[]>(this.url + environment.title);
  }
}
