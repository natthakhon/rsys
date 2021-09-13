import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { questionnaire } from '../vm/questionnaire';
import { Observable, } from 'rxjs';
import { environment } from '../../environments/environment';

@Injectable({
  providedIn: 'root'
})

export class QnaireService {

  private url: string = environment.apiurl;

  constructor(private http: HttpClient) { }

  getqnaires(): Observable<questionnaire[]> {
    return this.http.get<questionnaire[]>(this.url + environment.qnaire);
  }

  postqnaire(qnaire: questionnaire): Observable<questionnaire> {
    return this.http.post<questionnaire>(this.url + environment.qnaire, qnaire);
  }
}
