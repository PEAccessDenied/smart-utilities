import { RouterModule, Routes } from '@angular/router';
import { SupplierStatementsComponent } from './supplier-statements.component';

import { NgModule } from '@angular/core'
import { StatementDetailComponent } from './statement-detail/statement-detail.component';

const routes: Routes = [
  { path: '', component: SupplierStatementsComponent },
  { path: ':id', component: StatementDetailComponent }
]

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class SupplierStatementsRoutingModule { }
