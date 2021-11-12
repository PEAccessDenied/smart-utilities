import { RouterModule, Routes } from '@angular/router';
import { PropertiesComponent } from './properties.component';

import { NgModule } from '@angular/core'

const routes: Routes = [
  { path: '', component: PropertiesComponent },
]

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class PropertiesRoutingModule { }
