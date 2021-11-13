import { SharedModule } from './../../shared/shared.module';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SuppliersComponent } from './suppliers.component';
import { NewSupplierComponent } from './new-supplier/new-supplier.component';
import { SupplierDetailsComponent} from './supplier-details/supplier-details.component';
import { SuppliersRoutingModule } from './suppliers-routing.module';
import { NewResourceComponent } from './new-resource/new-resource.component';

@NgModule({
  imports: [
    CommonModule,
    SuppliersRoutingModule,
    SharedModule
  ],
  declarations: [SuppliersComponent, NewSupplierComponent, SupplierDetailsComponent, NewResourceComponent],
})
export class SuppliersModule { }
