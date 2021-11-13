import { RouterModule, Routes } from '@angular/router';
import { SuppliersComponent } from './suppliers.component';

import { NgModule } from '@angular/core'
import { SupplierDetailsComponent } from './supplier-details/supplier-details.component';

const routes: Routes = [
  { path: '', component: SuppliersComponent },
  { path: ':id', component: SupplierDetailsComponent}
]

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class SuppliersRoutingModule { }
