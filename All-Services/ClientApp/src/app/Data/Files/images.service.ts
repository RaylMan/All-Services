import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Image } from "src/Model/Image"

@Injectable()
export class ImagesDataService {

  private url = "./api/images";

  constructor(private http: HttpClient) {
  }
  uploadImage(file: File): Observable<Image> {
    const fd = new FormData()
    fd.append('uploadedFile', file, file.name);
    return this.http.post(this.url, fd);
  }
  getDefaultImage(): Observable<Image> {
    return this.http.get(this.url + '/defaultImage');
  }
}
