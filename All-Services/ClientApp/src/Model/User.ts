import { Access } from "src/Model/Access";

export class User {
  constructor(
    public id?: number,
    public accessId?: number,
    public timestamp?: string,
    public telephone?: string,
    public email?: string,
    public passwordHash?: string,
    public firstName?: string,
    public lastName?: string,
    public adress?: string,
    public access?: Access
  ) { }
}
