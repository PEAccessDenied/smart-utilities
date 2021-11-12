import { SharedModule } from './../../shared/shared.module';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SuppliersComponent } from './suppliers.component';
import { NewSupplierComponent } from './new-supplier/new-supplier.component';
import { SuppliersRoutingModule } from './suppliers-routing.module';

@NgModule({
  imports: [
    CommonModule,
    SuppliersRoutingModule,
    SharedModule
  ],
  declarations: [SuppliersComponent, NewSupplierComponent],
})
export class SuppliersModule { }
