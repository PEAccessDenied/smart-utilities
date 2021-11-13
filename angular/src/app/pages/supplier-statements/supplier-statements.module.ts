import { SharedModule } from '../../shared/shared.module';
import { SupplierStatementsRoutingModule } from './supplier-statements-routing.module';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SupplierStatementsComponent } from './supplier-statements.component';
import { StatementDetailComponent } from './statement-detail/statement-detail.component';

@NgModule({
  imports: [
    CommonModule,
    SupplierStatementsRoutingModule,
    SharedModule
  ],
  declarations: [
    SupplierStatementsComponent,
    StatementDetailComponent]
})
export class SupplierStatementsModule { }
