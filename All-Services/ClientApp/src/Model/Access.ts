export class Access {
  constructor(
    public id?: number,
    public accessName?: string,
    public timestamp?: string
  ) { }
}

export enum  AccessEnum {
  Admin = 'Admin',
  User = 'User',
  Company = 'Company'
}
