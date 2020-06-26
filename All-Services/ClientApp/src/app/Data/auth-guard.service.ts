import { Injectable } from '@angular/core';
import {
  ActivatedRouteSnapshot, RouterStateSnapshot,
  UrlTree, CanActivate, Router
} from '@angular/router';
import { Observable } from 'rxjs';
import { AuthService } from './auth.service';

@Injectable()
export class AuthGuard implements CanActivate {

  constructor(public authService: AuthService,public router: Router) {
  }

  canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot) {
    const token = this.authService.getDecodedToken();
    if (token) {
      // check if route is restricted by role
      if (route.data.roles && route.data.roles != token.access) {
        // role not authorised so redirect to home page
        this.router.navigate(['/']);
        return false;
      }

      // authorised so return true
      return true;
    }

    // not logged in so redirect to login page with the return url
    this.router.navigate(['/login'], { queryParams: { returnUrl: state.url } });
    return false;
  }

  //canActivate(
  //  next: ActivatedRouteSnapshot,
  //  state: RouterStateSnapshot): Observable<boolean> | Promise<boolean> | boolean {
  //  if (this.authService.logIn !== true) {
  //    this.router.navigate(['login'])
  //  }
  //  return true;
  //}
 
}
