import { FormBuilder, FormGroup, Validators, AsyncValidatorFn } from "@angular/forms";
import { Component, OnInit } from '@angular/core';
import { Router } from "@angular/router";
import { SearchDataService } from 'src/app/Data/Search/search.service'

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  providers: [SearchDataService]
})
export class HomeComponent implements OnInit {
  searchForm: FormGroup;
  constructor(private fb: FormBuilder, private dataService: SearchDataService, private router: Router) { }

  ngOnInit() {
    this.searchForm = this.fb.group({
      searchText: ['']
    });
  }

  search() {
    this.router.navigate(['/search/search'], {
      queryParams: {
        'text': this.searchForm.controls.searchText.value,
        index: 0,
        count: 20
      }
    });

    //this.dataService.searchCompanies(this.searchForm.controls.searchText.value, 0, 20)
    //  .subscribe(data => console.log(data));
  }
}
