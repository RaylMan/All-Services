import { ServiceType } from "./ServiceType";

export class RepairCategory
{
  constructor(
    public id?: number,
    public name?: string,
    public serviceTypeId?: number,
    public description?: string,
    public serviceType?: ServiceType,
  ) { }
}
