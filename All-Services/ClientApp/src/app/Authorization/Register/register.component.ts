import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Router } from "@angular/router";
import { AuthService } from 'src/app/Data/auth.service';
import { FormBuilder, FormGroup, Validators, AsyncValidatorFn } from "@angular/forms";

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  providers: [AuthService]
})
export class RegisterComponent {
  registerForm: FormGroup;
  errors: string[];

  constructor(private fb: FormBuilder, private auth: AuthService, private router: Router) {

    this.registerForm = this.fb.group({
      telephone: ['', Validators.required],
      password: ['', Validators.required],
      confirmPassword: ['', Validators.required],
      email: ['', Validators.required],
      firstName: ['', Validators.required],
      lastName: ['', Validators.required],
      adress: ['', Validators.required]
    });
    this.errors = [];
  }


  register() {
    this.errors = [];

    //if (!this.registerForm.valid) {
    //  this.registerForm.controls['telephone'].markAllAsTouched();
    //  this.registerForm.controls['password'].markAllAsTouched();
    //  this.registerForm.controls['confirmPassword'].markAllAsTouched();
    //  this.registerForm.controls['email'].markAllAsTouched();
    //  this.registerForm.controls['firstName'].markAllAsTouched();
    //  this.registerForm.controls['lastName'].markAllAsTouched();
    //  this.registerForm.controls['adress'].markAllAsTouched();
    //  return;
    //}

    this.auth.register(this.registerForm.value).subscribe((res) => {
      localStorage.setItem('auth_token', res.token);
      this.router.navigate(["/"]);
    },
      err => {
        //console.log(err);
        if (err.status === 400) {
          var validationErrorDictionary = err.error.errors;
          if (validationErrorDictionary == null) {

            this.errors.push(err.error);
          }
          for (var fieldName in validationErrorDictionary) {
            if (validationErrorDictionary.hasOwnProperty(fieldName)) {
              this.errors.push(validationErrorDictionary[fieldName]);
            }
          }
        } else {
          this.errors.push("something went wrong!");
        }
      });
  }
}


