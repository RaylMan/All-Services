import { Component, OnInit, OnDestroy } from '@angular/core';
import { ActivatedRoute, Router, Params, RouteReuseStrategy, NavigationEnd} from '@angular/router';

import { FormBuilder, FormGroup, Validators, AsyncValidatorFn } from "@angular/forms";
import { Company } from '../../Model/Company/Company';
import { SearchCompanyViewModel } from 'src/ViewModels/Company/searchCompanyViewModel';
import { SearchDataService } from '../Data/Search/search.service';
import { ImagesDataService } from '../Data/Files/images.service';
import { switchMap } from 'rxjs/operators';
import { Subject } from 'rxjs';
import { takeUntil } from 'rxjs/operators/';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.css'],
  providers: [SearchDataService]
})
export class SearchComponent implements OnInit  {
  isNotFound: boolean;
  id: any;
  searchText: string;
  searchIndex: number;
  searchCount: number;
  pages: number[] = [1,2,3,4,5];
  companies: SearchCompanyViewModel[]
  searchForm: FormGroup;

  mySubscription: any;

  constructor(private route: ActivatedRoute, private dataService: SearchDataService, private fb: FormBuilder, private pageRouter: Router) {
  }

  ngOnInit(): void {
    this.isNotFound = false;
    this.route.paramMap.pipe(
      switchMap(params => params.getAll('id')))
      .subscribe(data => { this.id = data; });

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

    this.searchForm = this.fb.group({
      searchText: ['']
    });
  }

  loadCompanies() {
    this.dataService.getCompanyByServiceType(this.id)
      .subscribe((data: SearchCompanyViewModel[]) => {
        this.companies = data;
      });
  }
  loadCompaniesSearch(text: string, index: number, count: number) {
    this.dataService.searchCompanies(this.searchText, index, count)
      .subscribe((data: SearchCompanyViewModel[]) => {
        this.companies = data;
        if (data.length === 0) {
          this.isNotFound = true;
        }
      });
  }
  newRoute(text: string, index: number, count: number) {
    this.pageRouter.navigateByUrl('/', { skipLocationChange: true }).then(() => {
      this.pageRouter.navigate(['/search/search'], {
        queryParams: {
          'text': text,
          index: index,
          count: count
        }
      });
    });
  }

  search() {
    this.newRoute(this.searchForm.controls.searchText.value, 0, 20);
  }
  ChangePage(page: number) {
    
  }
}
