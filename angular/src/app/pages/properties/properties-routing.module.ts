import { RouterModule, Routes } from '@angular/router';
import { PropertiesComponent } from './properties.component';

import { NgModule } from '@angular/core';
import { DetailsPropertyComponent } from './details-property/details-property.component';

const routes: Routes = [
  {
    path: '',
    component: PropertiesComponent,
  },
  {
    path: 'details',
    component: DetailsPropertyComponent,
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class PropertiesRoutingModule {}
