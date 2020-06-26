import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Equipment } from 'src/Model/Admin/Equipment';

@Injectable()
export class EquipmentService {

  private url = "/api/equipments";

  constructor(private http: HttpClient) {
  }

  getEquipments() {
    return this.http.get(this.url);
  }
  getEquipment(id: number) {
    return this.http.get(this.url + '/' + id);
  }
  getSortedEquipments(manId: number, mfId: number) {
    return this.http.get(this.url + '/sort=' + manId + '+' + mfId);
  }
  createEquipment(cat: Equipment) {
    return this.http.post(this.url, cat);
  }
  updateEquipment(id: number, cat: Equipment) {
    return this.http.put(this.url + '/' + id, cat);
  }
  deleteEquipment(id: number) {
    return this.http.delete(this.url + '/' + id);
  }
}
