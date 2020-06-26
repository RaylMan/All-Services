export class RegisterCompanyViewModel {
  constructor(
    public userId?: number,
    public mame?: string,
    public email?: string,
    public logoUrl?: string,
    public webSiteUrl?: string,
    public description?: string,
    public smallDescription?: string,

    public telephones?: [string],
    public types?: [number],
    public addresses?: [string]
  ) { }
}
