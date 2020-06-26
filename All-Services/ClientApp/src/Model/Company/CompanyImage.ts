import { Company } from "./Company";

export class CompanyImage
{
  constructor(
    public id?: number,
    public companyId?: number,
    public url?: string,
    public company?: Company
  ) { }
}
