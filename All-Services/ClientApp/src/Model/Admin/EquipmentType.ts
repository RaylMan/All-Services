import { ServiceType } from "./ServiceType";

export class EquipmentType
{
  constructor(
    public id?: number,
    public name?: string,
    public serviceTypeId?: number,
    public serviceType?: ServiceType
  ) { }
}
