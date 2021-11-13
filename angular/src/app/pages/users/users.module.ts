import { SharedModule } from '../../shared/shared.module';
import { RouterModule, Routes } from '@angular/router';
import { UsersComponent } from './users.component';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AddUserComponent } from './add-user/add-user.component';
import { UserDetailsComponent } from './user-details/user-details.component';

const routes = [
  {
    path: '',
    component: UsersComponent,
  },
];
@NgModule({
  declarations: [UsersComponent, AddUserComponent, UserDetailsComponent],
  imports: [CommonModule, SharedModule, RouterModule.forChild(routes)],
})
export class UsersModule {}
