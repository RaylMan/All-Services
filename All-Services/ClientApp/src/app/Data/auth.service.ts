import { Injectable } from '@angular/core';
import { HttpClientModule, HttpClient, HttpHeaders, HttpErrorResponse} from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { catchError, map } from 'rxjs/operators';
import { Router } from '@angular/router';
import { JwtHelperService } from '@auth0/angular-jwt';
import { User } from 'src/Model/User';
import { RegisterCompanyViewModel } from 'src/ViewModels/Company/registerCompanyViewModel';
import * as jwt_decode from "jwt-decode";

@Injectable({
  providedIn: 'root'
})

export class AuthService {

  private url = "/api/account";
  headers = new HttpHeaders().set('Content-Type', 'application/json');
  token;
  invalidLogin: boolean;

  constructor(private http: HttpClient, private router: Router, private jwtHelper: JwtHelperService) { }

  public get logIn(): boolean {
    let token = localStorage.getItem('auth_token');
    return (token !== null);
  }
  public get Role() {
    let token = localStorage.getItem('auth_token');
    let decoded = this.jwtHelper.decodeToken(token);
    return decoded.access;
  }
  logout() {
    let removeToken = localStorage.removeItem('auth_token');
    if (removeToken == null) {
      this.router.navigate(['login']);
    }
  }
  login(telephone: string, password: string) : Observable<any> {
    return this.http.post(this.url + '/login', { telephone: telephone, password: password })
    //  .pipe(
    //    catchError(this.handleError)
    //)
    
      //.subscribe((resp: any) => {

      //  localStorage.setItem('auth_token', resp.token);
      //  this.invalidLogin = false;
      //  this.router.navigate(["/"]);
      //}, err => {
          
      //  this.invalidLogin = true;
      //});
  }
  isAdmin(): boolean {
    return this.logIn && this.Role === "Admin";
  }
  isCompany(): boolean {
    return this.logIn && this.Role === "Company";
  }

  register(user: User): Observable<any> {
    return this.http.post(this.url + '/register', user)
  }
  registerCompany(company: RegisterCompanyViewModel): Observable<any> {
    return this.http.post(this.url + '/registerCompany', company)
    //.pipe(
    //  catchError(this.handleError)
    //)
  }
  getUserProfile(): Observable<any> {
    let uri = "api/users/" + this.getTokenId();
    return this.http.get(uri, { headers: this.headers }).pipe(
      map((res: Response) => {

        return res || {}
      }),
      catchError(this.handleError)
    )
  }
  getToken() {
    return localStorage.getItem('auth_token');
  }
  getDecodedToken() {
    let token = localStorage.getItem('auth_token');
    let decoded = this.jwtHelper.decodeToken(token);
    return decoded;
  }
  getTokenInfo() {
    let token = localStorage.getItem('auth_token');
    console.log(this.jwtHelper.decodeToken(token));
  }
  getTokenId(): number {
    let token = localStorage.getItem('auth_token');
    let decoded = this.jwtHelper.decodeToken(token);
    return decoded.id;
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

