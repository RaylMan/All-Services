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
  searchIndex: number;
  searchCount: number;
  companies: SearchCompanyViewModel[]
  constructor(private route: ActivatedRoute, private dataService: SearchDataService) {
  }

  ngOnInit(): void {
    this.route.paramMap.pipe(
      switchMap(params => params.getAll('id')))
      .subscribe(data => { this.id = data;});

    this.route.queryParams.subscribe(params => {
      this.searchText = params['text'];
      this.searchIndex = params['index'];
      this.searchCount = params['count'];
    });
    if (this.id > 0) {
      this.loadCompanies();
    }
    else {
      this.loadCompaniesSearch(this.searchText, this.searchIndex, this.searchCount);
    }
    
  }
  loadCompanies() {
    this.dataService.getCompanyByServiceType(this.id)
      .subscribe((data: SearchCompanyViewModel[]) =>
      {
        this.companies = data;
      });
  }
  loadCompaniesSearch(text: string, index: number, count: number ) {
    this.dataService.searchCompanies(this.searchText, index, count)
      .subscribe((data: SearchCompanyViewModel[]) =>
      {
        this.companies = data;
      });
  }
}
