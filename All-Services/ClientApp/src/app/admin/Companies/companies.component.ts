import { Component, OnInit } from '@angular/core';
import { Company } from 'src/Model/Company/Company';
import { CompanyDataService } from 'src/app/Data/Admin/companies.data.service';

@Component({
  selector: 'admin-users',
  templateUrl: './companies.component.html',
  providers: [CompanyDataService]
})
export class CompaniesComponent implements OnInit {
  company: Company;
  companies: Company[];
  constructor(private dataService: CompanyDataService) { }
  ngOnInit() {
    this.loadCompanies();
  }
  loadCompanies() {
    this.dataService.getCompanies()
      .subscribe((data: Company[]) => this.companies = data);
  }
  delete(c: Company) {
    if (confirm('Вы действительно хотите удалить запись?')) {
      this.dataService.deleteCompany(c.id)
        .subscribe(data => this.loadCompanies(),
          error => {
            alert(error.error.error);
          }
        );
    }
  }
}
