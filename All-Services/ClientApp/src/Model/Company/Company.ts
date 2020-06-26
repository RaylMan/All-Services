import { User } from "src/Model/User";
import { Telephones } from "src/Model/Company/Telephones";
import { CompanyAddress } from "src/Model/Company/CompanyAddress";
import { CompanyServiceType } from "src/Model/Company/CompanyServiceType";

export class Company {
  constructor(
    public id?: number,
    public UserId?: number,
    public name?: string,
    public email?: string,
    public passwordHash?: string,
    public logoUrl?: string,
    public webSiteUrl?: string,
    public Description?: string,
    public smallDescription?: string,
    public popularity?: number,
    public likes?: number,
    public dislikes?: number,
    public user?: User,
    public telephones?: Telephones[],
    public companyAddress?: CompanyAddress[],
    public companyServiceType?: CompanyServiceType[]
  ) { }
}
