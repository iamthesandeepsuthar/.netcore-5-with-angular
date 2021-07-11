import { MasterDataService } from './../../../Shared/Service/master-data.service';
import { Component, OnInit } from '@angular/core';
import { MasterViewModel } from 'src/app/Shared/Model/master.model';

@Component({
  selector: 'app-master-data',
  templateUrl: './master-data.component.html',
  styleUrls: ['./master-data.component.css']
})
export class MasterDataComponent implements OnInit {
  objMasterDataModel: MasterViewModel[];
  constructor(private readonly _masterDataService: MasterDataService) { }

  ngOnInit() {
    this.GetList();
  }
  GetList() {

    this._masterDataService.GetAll().subscribe(res => {

      if (res.IsSuccess) {
        this.objMasterDataModel = res.Data as MasterViewModel[];

      }
    },
      error => { });
  }
}
