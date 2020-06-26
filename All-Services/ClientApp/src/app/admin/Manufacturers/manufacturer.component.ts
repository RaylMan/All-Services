import { Component, OnInit } from '@angular/core';
import { Manufacturer } from 'src/Model/Admin/Manufacturer';
import { ManufacturerDataService } from 'src/app/Data/Admin/manufacturer.data.service';

@Component({
  selector: 'manufacturer',
  templateUrl: './manufacturer.component.html',
  providers: [ManufacturerDataService]
})
export class ManufacturerComponent implements OnInit {
  manufacturer: Manufacturer = new Manufacturer();
  manufacturers: Manufacturer[];
  tableMode: boolean = true;


  constructor(private dataService: ManufacturerDataService) {
  }
  ngOnInit() {
    this.loadManufacturers();
  }
  loadManufacturers() {
    this.dataService.getManufacturers()
      .subscribe((data: Manufacturer[]) => this.manufacturers = data);
  }
  // сохранение данных
  save() {
    if (this.manufacturer.id == null) {
      this.dataService.createManufacturer(this.manufacturer)
        .subscribe((data: Manufacturer) => this.manufacturers.push(data));
    } else {
      this.dataService.updateManufacturer(this.manufacturer.id, this.manufacturer)
        .subscribe(data => this.loadManufacturers());
    }
    this.cancel();
  }
  editManufacturer(a: Manufacturer) {
    this.manufacturer = a;
  }
  cancel() {
    this.manufacturer = new Manufacturer();
    this.tableMode = true;
  }
  delete(a: Manufacturer) {
    if (confirm('Вы действительно хотите удалить запись?')) {
      this.dataService.deleteManufacturer(a.id)
        .subscribe(data => this.loadManufacturers());
    }
    
  }
  add() {
    this.cancel();
    this.tableMode = false;
  }
}
