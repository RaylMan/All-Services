import { EquipmentType } from "./EquipmentType";
import { Manufacturer } from "./Manufacturer";

export class Equipment {
  constructor(
    public id?: number,
    public model?: string,
    public equipmentTypeId?: number,
    public manufacturerId?: number,
    public equipmentType?: EquipmentType,
    public manufacturer?: Manufacturer
  ) { }
}
