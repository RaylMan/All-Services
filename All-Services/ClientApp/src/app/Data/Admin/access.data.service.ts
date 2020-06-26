import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Access } from 'src/Model/Access';

@Injectable()
export class AccessDataService {

  private url = "/api/access";

  constructor(private http: HttpClient) {
  }

  getAccesses() {
    return this.http.get(this.url);
  }
  
  getAccess(id: number) {
    console.log(this.url + id)
    return this.http.get(this.url + '/' + id);
  }

  createAccess(access: Access) {
    return this.http.post(this.url, access);
  }
  updateAccess(id: number, access: Access) {

    return this.http.put(this.url + '/' + id, access);
  }
  deleteAccess(id: number) {
    return this.http.delete(this.url + '/' + id);
  }
}
