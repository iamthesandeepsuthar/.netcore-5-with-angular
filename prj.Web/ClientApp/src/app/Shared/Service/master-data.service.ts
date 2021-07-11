import { AppSetting } from './../Helper/app-setting';
import { BaseService } from './base.service';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class MasterDataService {

  constructor(private readonly _baseService: BaseService) { }


  GetAll(){
    return this._baseService.get(AppSetting.MasterDataListUrl)
  }
}
