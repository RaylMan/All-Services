import { Component, OnInit } from '@angular/core';
import { EquipmentType } from 'src/Model/Admin/EquipmentType';
import { Equipment } from 'src/Model/Admin/Equipment';
import { Manufacturer } from 'src/Model/Admin/Manufacturer';
import { EquipmentTypeService } from 'src/app/Data/Admin/equipmentTypes.data.service';
import { ManufacturerDataService } from 'src/app/Data/Admin/manufacturer.data.service';
import { EquipmentService } from 'src/app/Data/Admin/equipment.data.service';

@Component({
  selector: 'equipment',
  templateUrl: './equipment.component.html',
  providers: [EquipmentService, EquipmentTypeService, ManufacturerDataService]
})
export class EquipmentComponent implements OnInit {
  manufacturer: Manufacturer;
  manufacturers: Manufacturer[];
  equipment: Equipment;
  equipments: Equipment[];
  equipmentType: EquipmentType;
  equipmentTypes: EquipmentType[];
  tableMode: boolean = true;


  constructor(private dataService: EquipmentService,
    private typeService: EquipmentTypeService,
    private manufacturerService: ManufacturerDataService) {
  }
  ngOnInit() {
    this.loadEquipmentsTypes();
    this.loadManufacturers();
    this.loadEquipments();
  }

  loadEquipments() {
    this.dataService.getEquipments()
      .subscribe((data: Equipment[]) => this.equipments = data);
  }
  loadEquipmentsTypes() {
    this.typeService.getEquipmentTypes()
      .subscribe((data: EquipmentType[]) => this.equipmentTypes = data);
  }
  loadManufacturers() {
    this.manufacturerService.getManufacturers()
      .subscribe((data: Manufacturer[]) => this.manufacturers = data);
  }

  loadSortedEquipments(manId: number, mfId) {
    this.dataService.getSortedEquipments(manId, mfId)
      .subscribe((data: Equipment[]) => this.equipments = data);
  }

  // сохранение данных
  save() {
    if (this.equipment.id == null) {
      this.dataService.createEquipment(this.equipment)
        .subscribe((data: Equipment) => this.equipments.push(data));
    } else {
      this.dataService.updateEquipment(this.equipment.id, this.equipment)
        .subscribe(data => this.loadEquipments());
    }
    this.loadEquipments();
    this.cancel();
  }
  editEquipment(a: Equipment) {
    this.equipment = a;
  }
  cancel() {
    this.equipment = new Equipment();
    this.tableMode = true;
  }
  delete(a: EquipmentType) {
    if (confirm('Вы действительно хотите удалить запись?')) {
      this.dataService.deleteEquipment(a.id)
        .subscribe(data => this.loadEquipments());
    }
  }
  add() {
    this.cancel();
    this.tableMode = false;
  }

  onTypeSelected(typeValue: number, mfValue: number) {
    console.log(typeValue + ' ' + mfValue);
    if (typeValue != -1 || mfValue != -1) {
      this.loadSortedEquipments(typeValue, mfValue);
    }
    else {
      this.loadEquipments();
    }
  }
}
