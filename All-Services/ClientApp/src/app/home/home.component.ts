import { FormBuilder, FormGroup, Validators, AsyncValidatorFn } from "@angular/forms";
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent implements OnInit {
  searchForm: FormGroup;
  constructor(private fb: FormBuilder) { }

  ngOnInit() {
    this.searchForm = this.fb.group({
      searchText: ['']
    });
  }

  search() {
    console.log(this.searchForm.controls['searchText'].value);
  }
}
