import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { User } from 'src/Model/User';
import { Observable, throwError } from 'rxjs';
import { catchError, map } from 'rxjs/operators';

@Injectable()
export class SearchDataService {

  private url = "/api/search";

  constructor(private http: HttpClient) {
  }

  getCompanyByServiceType(id: number) {
    return this.http.get(this.url + '/' + id);
  }
}
