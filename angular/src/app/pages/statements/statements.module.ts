import { SharedModule } from './../../shared/shared.module';
import { StatementsRoutingModule } from './statements-routing.module';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { StatementsComponent } from './statements.component';
import { StatementDetailComponent } from './statement-detail/statement-detail.component';

@NgModule({
  imports: [
    CommonModule,
    StatementsRoutingModule,
    SharedModule
  ],
  declarations: [
    StatementsComponent,
    StatementDetailComponent]
})
export class StatementsModule { }
