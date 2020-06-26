import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { User } from 'src/Model/User';
import { Observable, throwError } from 'rxjs';
import { catchError, map } from 'rxjs/operators';

@Injectable()
export class UserDataService {

  private url = "/api/users";

  constructor(private http: HttpClient) {
  }

  getUsers() {
    return this.http.get(this.url);
  }

  getUser(id: number) {
    return this.http.get(this.url + '/' + id);
  }

  createUser(user: User): Observable<any> {
    console.log(user.firstName);
    return this.http.post(this.url, user);
  }
  updateUser(user: User) {

    return this.http.put(this.url, user);
  }
  deleteUser(id: number) {
    return this.http.delete(this.url + '/' + id);
  }
}
