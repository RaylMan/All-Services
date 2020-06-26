import { Component, OnInit} from '@angular/core';
import { AuthService } from 'src/app/Data/auth.service';
import { JwtHelperService } from '@auth0/angular-jwt';



@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent implements OnInit {
  isExpanded = false;
  constructor(private authService: AuthService, private jwtHelper: JwtHelperService) { }

  ngOnInit() {

  }

  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }
  logOut() {
    this.authService.logout();
  }
  isUserAuthenticated() {
    let token: string = localStorage.getItem("auth_token");
    if (token && !this.jwtHelper.isTokenExpired(token)) {
      return true;
    }
    else {
      return false;
    }
  }
  isAdmin() {
    return this.authService.isAdmin();
  }
  isCompany() {
    return this.authService.isCompany();
  }
  verify() {
    if (this.authService.logIn) {
      console.log('Вошли');
      this.authService.getTokenInfo();
    }
    else {
      console.log('Не вошли')
    }
  }
  
}
