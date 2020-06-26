import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Component, OnInit, ViewChild, TemplateRef } from '@angular/core';
import { Router } from "@angular/router";
import { AuthService } from 'src/app/Data/auth.service';
import { FormBuilder, FormGroup, Validators, AsyncValidatorFn, FormArray, FormControl, } from "@angular/forms";
import { Telephones } from "src/Model/Company/Telephones";
import { ServiceType } from "src/Model/Admin/ServiceType";
import { ServiceTypeDataService } from "src/app/Data/Admin/servicetype.data.service";
import { ImagesDataService } from "src/app/Data/Files/images.service";
import { Image } from "src/Model/Image";
import { Observable } from 'rxjs';


@Component({
  selector: 'company-register',
  templateUrl: './companyRegister.component.html',
  providers: [AuthService, ServiceTypeDataService, ImagesDataService]
})

export class CompanyRegisterComponent implements OnInit {
  fileName: string;
  registerForm: FormGroup;
  errors: string[];
  serviceTypes: ServiceType[]
  selectedFile: File = null;

  constructor(private fb: FormBuilder, private auth: AuthService, private router: Router, private serviceTypeData: ServiceTypeDataService, private imageService: ImagesDataService) {
    this.fileName = 'Выбрать файл...';
    this.registerForm = this.fb.group({
      userId: [auth.getTokenId()],
      telephones: new FormArray([new FormControl('', Validators.required)]),
      addresses: new FormArray([new FormControl()]),
      types: new FormArray([new FormControl('', Validators.required)]),
      name: ['TestCompany', Validators.required],
      description: ['Полное описание', Validators.required],
      logoUrl: [''],
      smallDescription: ['Краткое описание', Validators.required],
      webSiteUrl: ['11'],
      telephone: ['11', Validators.required],
      email: ['test-company@email.com', Validators.required]
    });
    this.errors = [];
  }
  ngOnInit() {
    this.loadTypes();
  }
  loadTypes() {
    this.serviceTypeData.getTypes()
      .subscribe((data: ServiceType[]) => this.serviceTypes = data);
  }
  addTelephone() {
    (this.registerForm.controls['telephones'] as FormArray).push(new FormControl('', Validators.required));
  }
  deleteTelephone(index) {
    (this.registerForm.controls['telephones'] as FormArray).removeAt(index)
  }
  addAddress() {
    (this.registerForm.controls['addresses'] as FormArray).push(new FormControl());
  }
  deleteAddress(index) {
    (this.registerForm.controls['addresses'] as FormArray).removeAt(index)
  }
  addType() {
    (this.registerForm.controls['types'] as FormArray).push(new FormControl('', Validators.required));
  }
  deleteType(index) {
    (this.registerForm.controls['types'] as FormArray).removeAt(index)
  }
  onFileSelected(event) {
    this.selectedFile = <File>event.target.files[0]
    this.fileName = this.selectedFile.name;
  }

  saveImage(): Observable<Image> {
    
    if (this.selectedFile != null) {
      return this.imageService.uploadImage(this.selectedFile);
    } else {
      return this.imageService.getDefaultImage();
    }
  }

  checkTypes(): boolean {
    for (let type of this.registerForm.controls['types'].value) {
      if (type == "") {
        this.errors.push('Необходимо выбрать услугу')
        return false;
      }
    }
    return true;
  }
  checkTelephones(): boolean {
    for (let telephone of this.registerForm.controls['telephones'].value) {
      if (telephone == "") {
        this.errors.push('Необходимо указать номер телефона')
        return false;
      }
    }
    return true;
  }
  register() {
    this.errors = [];

    let validTypes = this.checkTypes();
    let validTelephones = this.checkTelephones();
    if (!(validTypes && validTelephones)) {
      return;
    }
    
    if (this.registerForm.controls['telephones'].value[0] == null) {
      this.errors.push('Необходимо указать телефон')
      return;
    }
    if (this.registerForm.controls['types'].value[0] == null) {
      this.errors.push('Необходимо указать услугу')
      return;
    }
    let loadImageStream = this.saveImage();

    loadImageStream.subscribe(image => {
      this.registerForm.controls['logoUrl'].setValue(image.path);
      this.auth.registerCompany(this.registerForm.value).subscribe((res) => {
        this.router.navigate(['company']);},
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
    })
  }
}
