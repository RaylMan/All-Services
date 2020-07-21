export class SearchCompanyViewModel {
  constructor(
    public companyId?: number,
    public mame?: string,
    public desc?: string,
    public logoUrl?: string,
    public webSiteUrl?: string,
    public telephone?: string,
    public likes?: number,
    public disLikes?: number
  ) { }
}
