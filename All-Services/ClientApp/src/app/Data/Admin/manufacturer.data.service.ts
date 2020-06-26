import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Manufacturer } from 'src/Model/Admin/Manufacturer';

@Injectable()
export class ManufacturerDataService {

  private url = "/api/Manufacturers";

  constructor(private http: HttpClient) {
  }

  getManufacturers() {
    return this.http.get(this.url);
  }

  getManufacturer(id: number) {
    return this.http.get(this.url + '/' + id);
  }

  createManufacturer(man: Manufacturer) {
    return this.http.post(this.url, man);
  }
  updateManufacturer(id: number, man: Manufacturer) {

    return this.http.put(this.url + '/' + id, man);
  }
  deleteManufacturer(id: number) {
    return this.http.delete(this.url + '/' + id);
  }
}
