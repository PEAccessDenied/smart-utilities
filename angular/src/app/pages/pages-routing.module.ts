import { FullLayoutComponent } from './../layouts/full-layout.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AppRouteGuard } from '@app/shared/auth/auth-route-guard';

const routes: Routes = [
  {
    path: '',
    component: FullLayoutComponent,
    canActivate: [AppRouteGuard],
    children: [
      {
        path: '',
        redirectTo: 'dashboard',
        pathMatch: 'full',
      },
      {
        path: 'dashboard',
        loadChildren: () =>
          import('./dashboard/dashboard.module').then((m) => m.DashboardModule),
      },
      {
        path: 'supplier-statements',
        loadChildren: () =>
          import('./supplier-statements/supplier-statements.module').then(
            (m) => m.SupplierStatementsModule
          ),
      },
      {
        path: 'citizen-statements',
        loadChildren: () =>
          import('./citizen-statements/citizen-statements.module').then(
            (m) => m.CitizenStatementsModule
          ),
      },
      {
        path: 'suppliers',
        loadChildren: () =>
          import('./suppliers/suppliers.module').then((m) => m.SuppliersModule),
      },
      {
        path: 'properties',
        loadChildren: () =>
          import('./properties/properties.module').then(
            (m) => m.PropertiesModule
          ),
      },
      {
        path: 'smart-meters',
        loadChildren: () =>
          import('./smart-meters/smart-meters.module').then(
            (m) => m.SmartMetersModule
          ),
      },
      {
        path: 'reports',
        loadChildren: () =>
          import('./reports/reports.module').then((m) => m.ReportsModule),
      },
      {
        path: 'settings',
        loadChildren: () =>
          import('./settings/settings.module').then((m) => m.SettingsModule),
      },
    ],
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class PagesRoutingModule {}
