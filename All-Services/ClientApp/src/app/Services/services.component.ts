import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Subscription } from 'rxjs';
import { Company } from '../../Model/Company/Company';
import { ServicesDataService } from '../Data/Services/services.service';
import { switchMap } from 'rxjs/operators';

@Component({
  selector: 'app-services',
  templateUrl: './services.component.html',
  providers: [ServicesDataService]
})
export class ServicesComponent implements OnInit {
  
  id: any;
  private subscription: Subscription;
  companies: Company[]
  constructor(private route: ActivatedRoute, private dataService: ServicesDataService) {

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
      .subscribe((data: Company[]) => this.companies = data);
  }
}
