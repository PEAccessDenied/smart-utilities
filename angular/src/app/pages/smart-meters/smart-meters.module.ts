import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SmartMetersComponent } from './smart-meters.component';
import { SmartMetersRoutingModule } from './smart-meters-routing.module';
import { NewSmartMeterComponent } from './new-smart-meter/new-smart-meter.component';
import { SharedModule } from '@app/shared/shared.module';

@NgModule({
  imports: [
    CommonModule,
    SmartMetersRoutingModule,
    SharedModule,
  ],
  declarations: [SmartMetersComponent, NewSmartMeterComponent]
})
export class SmartMetersModule { }
