import { Company } from "./Company";

export class Telephones {
  constructor(
    public id?: number,
    public companyId?: number,
    public telephone?: string,
    public company?: Company
  ) { }
}
