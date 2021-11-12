import { RouterModule, Routes } from '@angular/router';
import { SmartMetersComponent } from './smart-meters.component';

import { NgModule } from '@angular/core'

const routes: Routes = [
  { path: '', component: SmartMetersComponent },
]

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class SmartMetersRoutingModule { }
