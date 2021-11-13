import { SharedModule } from '../../shared/shared.module';
import { CitizenStatementsRoutingModule } from './citizen-statements-routing.module';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CitizenStatementsComponent } from './citizen-statements.component';
import { StatementDetailComponent } from './statement-detail/statement-detail.component';

@NgModule({
  imports: [
    CommonModule,
    CitizenStatementsRoutingModule,
    SharedModule
  ],
  declarations: [
    CitizenStatementsComponent,
    StatementDetailComponent]
})
export class CitizenStatementsModule { }
