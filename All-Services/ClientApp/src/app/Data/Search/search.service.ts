import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable()
export class SearchDataService {

  private url = "/api/search";

  constructor(private http: HttpClient) {
  }

  getCompanyByServiceType(id: number, index: number, count: number) {
    return this.http.get(this.url + '/' + id + '?index=' + index+'&count=' + count);
  }
  getCompanyByServiceTypeCount(id: number) {
    return this.http.get(this.url + '/count?id=' + id);
  }
  searchCompanies(text: string, index: number, count: number) {
    return this.http.get(this.url + '/search?text=' + text + '&index=' + index + '&count=' + count);
  }
  searchCompaniesCount(text: string) {
    return this.http.get(this.url + '/searchCount?text=' + text);

  }
}
