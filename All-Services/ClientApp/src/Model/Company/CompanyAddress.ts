import { Company } from "./Company";

export class CompanyAddress {
  constructor(
    public id?: number,
    public companyId?: number,
    public address?: string,
    public company?: Company,
  ) { }
}
