import { Component, OnInit } from '@angular/core';
import { RepairCategory } from 'src/Model/Admin/RepairCategory';
import { ServiceType } from 'src/Model/Admin/ServiceType';
import { ServiceTypeDataService } from 'src/app/Data/Admin/servicetype.data.service';

import { RepairCategoryService } from 'src/app/Data/Admin/repaircategory.data.service';

@Component({
  selector: 'repairsCategories',
  templateUrl: './repairCategories.component.html',
  providers: [RepairCategoryService, ServiceTypeDataService]
})
export class RepairsCategoriesComponent implements OnInit {
  type: ServiceType;
  typesList: ServiceType[];
  category: RepairCategory = new RepairCategory();
  categories: RepairCategory[];
  tableMode: boolean = true;


  constructor(private dataService: RepairCategoryService, private typeService: ServiceTypeDataService) {
  }
  ngOnInit() {
    this.loadCategories();
    this.loadTypes();
  }
  loadCategories() {
    this.dataService.getCategories()
      .subscribe((data: RepairCategory[]) => this.categories = data);
  }
  loadSortedCategories(id: number) {
    console.log(id);
    this.dataService.getSortedCategories(id)
      .subscribe((data: RepairCategory[]) => this.categories = data);
  }
  loadTypes() {
    this.typeService.getTypes()
      .subscribe((data: ServiceType[]) => this.typesList = data);
  }
  // сохранение данных
  save() {
    if (this.category.id == null) {
      this.dataService.createCategory(this.category)
        .subscribe((data: RepairCategory) => this.categories.push(data));
    } else {
      this.dataService.updateCategory(this.category.id, this.category)
        .subscribe(data => this.loadCategories());
    }
    this.loadCategories();
    this.cancel();
  }
  editCategory(a: RepairCategory) {
    this.category = a;
  }
  cancel() {
    this.category = new RepairCategory();
    this.tableMode = true;
  }
  delete(a: RepairCategory) {
    if (confirm('Вы действительно хотите удалить запись?')) {
      this.dataService.deleteCategory(a.id)
        .subscribe(data => this.loadCategories());
    }

  }
  add() {
    this.cancel();
    this.tableMode = false;
  }
  onTypeSelected(value: number) {
    if (value != -1) {
      console.log(value);
      this.loadSortedCategories(value);
    }
    else {
      this.loadCategories();
    }
  }
}
