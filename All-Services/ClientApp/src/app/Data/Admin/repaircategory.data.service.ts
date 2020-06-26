import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { RepairCategory } from 'src/Model/Admin/RepairCategory';

@Injectable()
export class RepairCategoryService {

  private url = "/api/repairCategory";

  constructor(private http: HttpClient) {
  }

  getCategories() {
    return this.http.get(this.url);
  }
  getSortedCategories(id: number) {
    return this.http.get(this.url + '/sort=' + id);
  }
  getCategory(id: number) {
    return this.http.get(this.url + '/' + id);
  }

  createCategory(cat: RepairCategory) {
    return this.http.post(this.url, cat);
  }
  updateCategory(id: number, cat: RepairCategory) {

    return this.http.put(this.url + '/' + id, cat);
  }
  deleteCategory(id: number) {
    return this.http.delete(this.url + '/' + id);
  }
}
