import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { FormBuilder, FormGroup, Validators, AsyncValidatorFn } from "@angular/forms";
import { SearchCompanyViewModel } from 'src/ViewModels/Company/searchCompanyViewModel';
import { SearchDataService } from '../Data/Search/search.service';
import { switchMap } from 'rxjs/operators';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.css'],
  providers: [SearchDataService]
})
export class SearchComponent implements OnInit {
  isNotFound: boolean;
  id: any;
  searchText: string;
  searchIndex: number;
  searchCount: number ;
  pages: number[] = [1];
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
      this.loadCompanies(this.id, 0, this.searchCount);
    }
    else {
      this.loadCompaniesSearch(this.searchText, this.searchIndex, this.searchCount);
    }

    this.searchForm = this.fb.group({
      searchText: ['']
    });
  }

  loadCompanies(id: number, index: number, count: number) {
    this.dataService.getCompanyByServiceTypeCount(id).subscribe(companiesCount => {
      this.createPagesList(companiesCount);
      this.dataService.getCompanyByServiceType(id, index, count)
        .subscribe((data: SearchCompanyViewModel[]) => {
          this.companies = data;
        });
    });
  }
  loadCompaniesSearch(text: string, index: number, count: number) {
    this.dataService.searchCompaniesCount(text).subscribe(companiesCount => {
      this.createPagesList(companiesCount);
      this.dataService.searchCompanies(text, index, count)
        .subscribe((data: SearchCompanyViewModel[]) => {
          this.companies = data;
          if (data.length === 0) {
            this.isNotFound = true;
          }
        });
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
    this.newRoute(this.searchForm.controls.searchText.value, 0, this.searchCount);
  }
  changePage(page: number) {
    let index = (page - 1) * this.searchCount;

    if (this.id > 0) {
      console.log(this.id + ' ' + index + ' ' + this.searchCount )
      this.loadCompanies(this.id, index, this.searchCount)
    }
    else {
      this.loadCompaniesSearch(this.searchText, index, this.searchCount);
    }
  }
  createPagesList(companiesCount: any) {
    let pagesCount = Math.ceil(companiesCount / this.searchCount);
    this.pages = [];
    for (var i = 1; i <= pagesCount; i++) {
      this.pages.push(i);
    }
  }
}
