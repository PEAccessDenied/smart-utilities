import { SharedModule } from './../../shared/shared.module';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PropertiesComponent } from './properties.component';
import { NewPropertyComponent } from './new-property/new-property.component';
import { PropertiesRoutingModule } from './properties-routing.module';

@NgModule({
  imports: [
    CommonModule,
    PropertiesRoutingModule,
    SharedModule
  ],
  declarations: [PropertiesComponent, NewPropertyComponent]
})
export class PropertiesModule { }
