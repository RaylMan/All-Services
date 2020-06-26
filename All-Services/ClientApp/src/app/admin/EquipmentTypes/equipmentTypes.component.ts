import { Component, OnInit } from '@angular/core';
import { EquipmentType } from 'src/Model/Admin/EquipmentType';
import { ServiceType } from 'src/Model/Admin/ServiceType';
import { EquipmentTypeService } from 'src/app/Data/Admin/equipmentTypes.data.service';
import { ServiceTypeDataService } from 'src/app/Data/Admin/servicetype.data.service';

@Component({
  selector: 'equipmentTypes',
  templateUrl: './equipmentTypes.component.html',
  providers: [ServiceTypeDataService, EquipmentTypeService]
})
export class EquipmentTypesComponent implements OnInit {
  type: ServiceType;
  typesList: ServiceType[];
  equipmentType: EquipmentType;
  equipmentTypes: EquipmentType[];
  tableMode: boolean = true;


  constructor(private dataService: EquipmentTypeService, private typeService: ServiceTypeDataService) {
  }
  ngOnInit() {
    this.loadEquipmentTypes();
    this.loadTypes();
  }
  loadEquipmentTypes() {
    this.dataService.getEquipmentTypes()
      .subscribe((data: EquipmentType[]) => this.equipmentTypes = data);
  }
  loadSortedEquipmentTypes(id: number) {
    this.dataService.getSortedEquipmentTypes(id)
      .subscribe((data: EquipmentType[]) => this.equipmentTypes = data);
  }
  loadTypes() {
    this.typeService.getTypes()
      .subscribe((data: EquipmentType[]) => this.typesList = data);
  }
  // сохранение данных
  save() {
    if (this.equipmentType.id == null) {
      this.dataService.createEquipmentType(this.equipmentType)
        .subscribe((data: EquipmentType) => this.equipmentTypes.push(data));
    } else {
      this.dataService.updateEquipmentType(this.equipmentType.id, this.equipmentType)
        .subscribe(data => this.loadEquipmentTypes());
    }
    this.loadEquipmentTypes();
    this.cancel();
  }
  editEquipmentType(a: EquipmentType) {
    this.equipmentType = a;
  }
  cancel() {
    this.equipmentType = new EquipmentType();
    this.tableMode = true;
  }
  delete(a: EquipmentType) {
    if (confirm('Вы действительно хотите удалить запись?')) {
      this.dataService.deleteEquipmentType(a.id)
        .subscribe(data => this.loadEquipmentTypes());
    }
  }
  add() {
    this.cancel();
    this.tableMode = false;
  }

  onTypeSelected(value: number) {
    if (value != -1) {
      this.loadSortedEquipmentTypes(value);
    }
    else {
      this.loadEquipmentTypes();
    }
  }
}
