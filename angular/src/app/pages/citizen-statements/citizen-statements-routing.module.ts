import { RouterModule, Routes } from '@angular/router';
import { CitizenStatementsComponent } from './citizen-statements.component';

import { NgModule } from '@angular/core'
import { StatementDetailComponent } from './statement-detail/statement-detail.component';

const routes: Routes = [
  { path: '', component: CitizenStatementsComponent },
  { path: ':id', component: StatementDetailComponent }
]

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class CitizenStatementsRoutingModule { }
