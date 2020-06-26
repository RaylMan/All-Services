import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Router } from "@angular/router";
import { NgForm } from '@angular/forms';
import { AuthService } from 'src/app/Data/auth.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-account',
  templateUrl: './account.component.html',
})
export class AccountComponent implements OnInit {
  currentUser: Object = {};

  constructor(
    public authService: AuthService,
    private actRoute: ActivatedRoute
  ) {}
  ngOnInit() {
    this.authService.getUserProfile().subscribe(res => {
      this.currentUser = res;
      this.authService.getTokenInfo();
    })
  }
}

