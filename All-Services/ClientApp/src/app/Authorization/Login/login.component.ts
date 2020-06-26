import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Router } from "@angular/router";
import { AuthService } from 'src/app/Data/auth.service';
import { FormBuilder, FormGroup, Validators, AsyncValidatorFn } from "@angular/forms";

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  providers: [AuthService]
})
export class LoginComponent implements OnInit {
  loginForm: FormGroup;

  errors: string[];
  successfulSave: boolean;
  IsRemember: boolean;
  invalidLogin: boolean;

  constructor(private fb: FormBuilder, private auth: AuthService, private router: Router) { }

  ngOnInit() {
    this.loginForm = this.fb.group({
      telephone: ['', Validators.required],
      password: ['', Validators.required]
    });
    this.errors = [];
  }
  get f() { return this.loginForm.controls; }

  login() {
    this.errors = [];

    if (this.loginForm.invalid) {
      this.loginForm.controls['telephone'].markAllAsTouched();
      this.loginForm.controls['password'].markAllAsTouched();
      return;
    }
    this.auth.login(this.f.telephone.value, this.f.password.value).subscribe((res: any) => {
      localStorage.setItem('auth_token', res.token);
      this.router.navigate(["/"]);
      this.invalidLogin = false;
    }
      , err => {
        console.log(err)
        this.invalidLogin = true;
        if (err.status === 400) {
          let validationErrorDictionary = err.error.errors;
          if (validationErrorDictionary == null) {
            this.errors.push(err.error.error);
          }
          for (var fieldName in validationErrorDictionary) {
            if (validationErrorDictionary.hasOwnProperty(fieldName)) {
              this.errors.push(validationErrorDictionary[fieldName]);
            }
          }
        } else {
          this.errors.push("Неизвестная ошибка");
        }
      })
  }
}
