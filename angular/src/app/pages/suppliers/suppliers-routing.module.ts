import { RouterModule, Routes } from '@angular/router';
import { SuppliersComponent } from './suppliers.component';

import { NgModule } from '@angular/core'

const routes: Routes = [
  { path: '', component: SuppliersComponent },
]

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class SuppliersRoutingModule { }
