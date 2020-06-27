import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { ReactiveFormsModule, FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { JwtModule } from "@auth0/angular-jwt";
import { appRoutingModule } from './app.routing';

import { CompanyComponent } from './Company/company.component';
import { ServicesComponent } from './Services/services.component';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';

import { LoginComponent } from './Authorization/Login/login.component';
import { RegisterComponent } from './Authorization/Register/register.component';

import { CompanyRegisterComponent } from './Authorization/Register/companyRegister.component';
import { AccountComponent } from './Authorization/Account/account.component';


import { AdminComponent } from './admin/admin.component';
import { UsersComponent } from './admin/Users/users.compoment';
import { AccessComponent } from './admin/Accesses/access.component';
import { ServiceTypeComponent } from './admin/ServiceTypes/serviceType.component';
import { CompaniesComponent } from './admin/Companies/companies.component';
import { ManufacturerComponent } from './admin/Manufacturers/manufacturer.component';
import { RepairsCategoriesComponent } from './admin/RepairsCategories/repairsCategories.component';
import { EquipmentTypesComponent } from './admin/EquipmentTypes/equipmentTypes.component';
import { EquipmentComponent } from './admin/Equipments/equipment.component';


import { AuthGuard } from './Data/auth-guard.service';
import { AuthInterceptor } from './Data/authconfig.interceptor';


export function tokenGetter() {
  return localStorage.getItem("auth_token");
}
@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    LoginComponent,
    RegisterComponent,
    AdminComponent,
    UsersComponent,
    AccessComponent,
    AccountComponent,
    ServiceTypeComponent,
    ManufacturerComponent, 
    RepairsCategoriesComponent,
    EquipmentTypesComponent,
    EquipmentComponent,
    CompanyRegisterComponent,
    CompaniesComponent,
    CompanyComponent,
    ServicesComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    ReactiveFormsModule,
    FormsModule,
    appRoutingModule,
    JwtModule.forRoot({
      config: {
        tokenGetter: tokenGetter,
        whitelistedDomains: ["localhost:5000"],
        blacklistedRoutes: []
      }
    })
  ],

  providers: [
    AuthGuard,
    {
      provide: HTTP_INTERCEPTORS,
      useClass: AuthInterceptor,
      multi: true
    }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
