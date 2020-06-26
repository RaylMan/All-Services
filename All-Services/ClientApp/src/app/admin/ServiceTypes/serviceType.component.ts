import { Component, OnInit } from '@angular/core';
import { ServiceType } from 'src/Model/Admin/ServiceType';
import { ServiceTypeDataService } from 'src/app/Data/Admin/servicetype.data.service';

@Component({
  selector: 'aservice-type',
  templateUrl: './serviceType.component.html',
  providers: [ServiceTypeDataService]
})
export class ServiceTypeComponent implements OnInit {
  type: ServiceType = new ServiceType();
  typesList: ServiceType[];
  tableMode: boolean = true;


  constructor(private dataService: ServiceTypeDataService) {
  }
  ngOnInit() {
    this.loadTypes();
  }
  loadTypes() {
    this.dataService.getTypes()
      .subscribe((data: ServiceType[]) => this.typesList = data);
  }
  // сохранение данных
  save() {
    if (this.type.id == null) {
      this.dataService.createType(this.type)
        .subscribe((data: ServiceType) => this.typesList.push(data));
    } else {
      this.dataService.updateType(this.type.id, this.type)
        .subscribe(data => this.loadTypes());
    }
    this.cancel();
  }
  editType(a: ServiceType) {
    this.type = a;
  }
  cancel() {
    this.type = new ServiceType();
    this.tableMode = true;
  }
  delete(a: ServiceType) {
    if (confirm('Вы действительно хотите удалить запись?')) {
      this.dataService.deleteType(a.id)
        .subscribe(
          data => this.loadTypes(),
          error => {
            alert(error.error.error);
          });
    }
  }
  add() {
    this.cancel();
    this.tableMode = false;
  }
}
