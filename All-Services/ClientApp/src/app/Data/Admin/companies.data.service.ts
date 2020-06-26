import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { User } from 'src/Model/User';
import { Observable, throwError } from 'rxjs';
import { catchError, map } from 'rxjs/operators';

@Injectable()
export class CompanyDataService {

  private url = "/api/companies";

  constructor(private http: HttpClient) {
  }

  getCompanies() {
    return this.http.get(this.url);
  }

  getCompany(id: number) {
    return this.http.get(this.url + '/' + id);
  }

  createCompany(user: User): Observable<any> {
    return this.http.post(this.url, user);
  }
  updateCompany(user: User) {

    return this.http.put(this.url, user);
  }
  deleteCompany(id: number) {
    return this.http.delete(this.url + '/' + id);
  }
}
