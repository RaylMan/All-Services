import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Subscription } from 'rxjs';
import { Company } from '../../Model/Company/Company';
import { SearchCompanyViewModel } from 'src/ViewModels/Company/searchCompanyViewModel';
import { SearchDataService } from '../Data/Search/search.service';
import { ImagesDataService } from '../Data/Files/images.service';
import { switchMap } from 'rxjs/operators';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.css'],
  providers: [SearchDataService]
})
export class SearchComponent implements OnInit {

  id: any;
  searchText: string;
  private subscription: Subscription;
  testCompany: Company;
  companies: SearchCompanyViewModel[]
  constructor(private route: ActivatedRoute, private dataService: SearchDataService) {
  }

  ngOnInit(): void {
    this.route.paramMap.pipe(
      switchMap(params => params.getAll('id'))
    )
      .subscribe(data => { this.id = data; console.log(data + '---') });
    this.loadCompanies();
  }
  loadCompanies() {
    this.dataService.getCompanyByServiceType(this.id)
      .subscribe((data: SearchCompanyViewModel[]) =>
      {
        this.testCompany = data[0]
        this.companies = data;
        console.log(data);
      });
  }
  loadCompaniesSearch() {
    this.dataService.searchCompanies('',0,20)
      .subscribe((data: SearchCompanyViewModel[]) =>
      {
        this.testCompany = data[0]
        this.companies = data;
        console.log(data);
      });
  }
}
