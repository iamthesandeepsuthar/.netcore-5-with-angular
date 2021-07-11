import { MasterDataComponent } from './master-data/master-data.component';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';


const routes: Routes = [
 // {path:"", component: MasterDataComponent},
  {path:"master-data", component: MasterDataComponent}
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class MasterRoutingModule { 



}
