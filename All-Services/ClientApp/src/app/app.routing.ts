import { Routes, RouterModule } from '@angular/router';

import { AuthGuard } from './Data/auth-guard.service';
import { HomeComponent } from './home/home.component';

import { LoginComponent } from './Authorization/Login/login.component';
import { RegisterComponent } from './Authorization/Register/register.component';
import { CompanyRegisterComponent } from './Authorization/Register/companyRegister.component';
import { AccountComponent } from './Authorization/Account/account.component';

import { CompanyComponent } from './Company/company.component';
import { SearchComponent } from './Search/search.component';


import { AdminComponent } from './admin/admin.component';
import { UsersComponent } from './admin/Users/users.compoment';
import { CompaniesComponent } from './admin/Companies/companies.component';
import { AccessComponent } from './admin/Accesses/access.component';
import { ServiceTypeComponent } from './admin/ServiceTypes/serviceType.component';
import { ManufacturerComponent } from './admin/Manufacturers/manufacturer.component';
import { RepairsCategoriesComponent } from './admin/RepairsCategories/repairsCategories.component';
import { EquipmentTypesComponent } from './admin/EquipmentTypes/equipmentTypes.component';
import { EquipmentComponent } from './admin/Equipments/equipment.component';

import { AccessEnum } from '../Model/Access';

const adminRoutes: Routes = [
  { path: 'access', component: AccessComponent },
  { path: 'users', component: UsersComponent },
  { path: 'companies', component: CompaniesComponent },
  { path: 'service-type', component: ServiceTypeComponent },
  { path: 'manufacturers', component: ManufacturerComponent },
  { path: 'repairCategories', component: RepairsCategoriesComponent },
  { path: 'equipmentTypes', component: EquipmentTypesComponent },
  { path: 'equipments', component: EquipmentComponent }
];
const userRoutes: Routes = [
 
]
const companyRoutes: Routes = [
 
]
const appRoutes: Routes = [
  { path: '', component: HomeComponent, pathMatch: 'full' },
  { path: 'login', component: LoginComponent },
  { path: 'register', component: RegisterComponent },
  { path: 'company-register', component: CompanyRegisterComponent },
  { path: 'admin', component: AdminComponent, children: adminRoutes, canActivate: [AuthGuard], data: { roles: [AccessEnum.Admin] } },
  { path: 'company', component: CompanyComponent, children: companyRoutes, canActivate: [AuthGuard], data: { roles: [AccessEnum.Company] } },
  { path: 'account', component: AccountComponent, children: adminRoutes, canActivate: [AuthGuard] },
  { path: 'search/:id', component: SearchComponent },
  { path: 'search/search?text=:text&index=:index&count=:count', component: SearchComponent }
];

export const appRoutingModule = RouterModule.forRoot(appRoutes);
