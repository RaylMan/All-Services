import { Component, OnInit } from '@angular/core';
import { Access } from 'src/Model/Access';
import { AccessDataService } from 'src/app/Data/Admin/access.data.service';

@Component({
  selector: 'admin-access',
  templateUrl: './access.component.html',
  providers: [AccessDataService]
})
export class AccessComponent implements OnInit {
  access: Access = new Access();
  accessList: Access[];
  tableMode: boolean = true;


  constructor(private dataService: AccessDataService) {
  }
  ngOnInit() {
    this.loadAccesses();
  }
  loadAccesses() {
    this.dataService.getAccesses()
      .subscribe((data: Access[]) => this.accessList = data);
  }
  // сохранение данных
  save() {
    if (this.access.id == null) {
      this.dataService.createAccess(this.access)
        .subscribe((data: Access) => this.accessList.push(data));
    } else {
      this.dataService.updateAccess(this.access.id, this.access)
        .subscribe(data => this.loadAccesses());
    }
    this.cancel();
  }
  editAccess(a: Access) {
    this.access = a;
  }
  cancel() {
    this.access = new Access();
    this.tableMode = true;
  }
  delete(a: Access) {
    if (confirm('Вы действительно хотите удалить запись?')) {
      this.dataService.deleteAccess(a.id)
        .subscribe(data => this.loadAccesses());
    }
  }
  add() {
    this.cancel();
    this.tableMode = false;
  }
}
