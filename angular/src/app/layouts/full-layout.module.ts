import { RouterModule } from '@angular/router';
import { SharedModule } from './../shared/shared.module';
import { FullLayoutComponent } from './full-layout.component';
import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';

@NgModule({
  imports: [
    CommonModule,
    RouterModule,
    SharedModule],
  declarations: [FullLayoutComponent],
  exports: [
    RouterModule,
    FullLayoutComponent]
})
export class FullLayoutModule { }
