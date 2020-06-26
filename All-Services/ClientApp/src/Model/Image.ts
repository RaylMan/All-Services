import { CompanyImage } from "./Company/CompanyImage";

export class Image {
  constructor(
    public id?: number,
    public name?: string,
    public path?: string,
    public timestamp?: string,
    public companyImages?: CompanyImage[]
  ) { }
}
