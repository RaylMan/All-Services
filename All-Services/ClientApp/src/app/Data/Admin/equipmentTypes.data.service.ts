import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { EquipmentType } from 'src/Model/Admin/EquipmentType';

@Injectable()
export class EquipmentTypeService {

  private url = "/api/equipmentTypes";

  constructor(private http: HttpClient) {
  }

  getEquipmentTypes() {
    return this.http.get(this.url);
  }
  getEquipmentType(id: number) {
    return this.http.get(this.url + '/' + id);
  }
  getSortedEquipmentTypes(id: number) {
    return this.http.get(this.url + '/sort=' + id);
  }
  createEquipmentType(cat: EquipmentType) {
    return this.http.post(this.url, cat);
  }
  updateEquipmentType(id: number, cat: EquipmentType) {
    return this.http.put(this.url + '/' + id, cat);
  }
  deleteEquipmentType(id: number) {
    return this.http.delete(this.url + '/' + id);
  }
}
