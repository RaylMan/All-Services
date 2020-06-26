import { Component, OnInit } from '@angular/core';
import { User } from 'src/Model/User';
import { UserDataService } from 'src/app/Data/Admin/users.data.service';
import { HttpClientModule, HttpClient, HttpHeaders, HttpErrorResponse } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { catchError, map } from 'rxjs/operators';

@Component({
  selector: 'admin-users',
  templateUrl: './users.component.html',
  providers: [UserDataService]
})
export class UsersComponent implements OnInit {
  user: User;
  usersList: User[];
  constructor(private dataService: UserDataService) { }
  ngOnInit() {
    this.loadUsers();
  }
  loadUsers() {
    this.dataService.getUsers()
      .subscribe((data: User[]) => this.usersList = data);
  }
  delete(u: User) {
    if (confirm('Вы действительно хотите удалить запись?')) {
      this.dataService.deleteUser(u.id)
        .subscribe(data => this.loadUsers(),
          error => {
            alert(error.error.error);
          }
        );
    }
  }

  handleError(error: HttpErrorResponse) {
    let msg = '';
    if (error.error instanceof ErrorEvent) {
      // client-side error
      msg = error.error.message;
    } else {
      // server-side error
      msg = `Error Code: ${error.status}\nMessage: ${error.message}`;
    }
    return throwError(msg);
  }
}
