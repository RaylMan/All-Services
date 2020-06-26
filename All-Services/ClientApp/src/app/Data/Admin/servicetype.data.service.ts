import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ServiceType } from 'src/Model/Admin/ServiceType';

@Injectable()
export class ServiceTypeDataService {

  private url = "/api/servicetypes";

  constructor(private http: HttpClient) {
  }

  getTypes() {
    return this.http.get(this.url);
  }

  getType(id: number) {
    console.log(this.url + id)
    return this.http.get(this.url + '/' + id);
  }

  createType(type: ServiceType) {
    console.log(type);
    return this.http.post(this.url, type);
  }
  updateType(id: number, type: ServiceType) {

    return this.http.put(this.url + '/' + id, type);
  }
  deleteType(id: number) {
    return this.http.delete(this.url + '/' + id);
  }
}
