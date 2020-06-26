import { Company } from "./Company";
import { ServiceType } from "src/Model/Admin/ServiceType";

export class CompanyServiceType {
  constructor(
    public id?: number,
    public companyId?: number,
    public serviceTypeId?: number,
    public company?: Company,
    public serviceType?: ServiceType
  ) { }
}
