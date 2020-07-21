import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Subscription } from 'rxjs';
import { Company } from '../../Model/Company/Company';
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
  private subscription: Subscription;
  testCompany: Company;
  companies: Company[]
  constructor(private route: ActivatedRoute, private dataService: SearchDataService) {

    //this.subscription = route.params.subscribe(params => this.id = params['id']);
  }

  ngOnInit(): void {
    this.route.paramMap.pipe(
      switchMap(params => params.getAll('id'))
    )
      .subscribe(data => this.id = +data);
    this.loadCompanies();
  }
  loadCompanies() {
    this.dataService.getCompanyByServiceType(this.id)
      .subscribe((data: Company[]) =>
      {
        this.testCompany = data[0]
        this.companies = data;
        console.log(data);
      });
  }
}
