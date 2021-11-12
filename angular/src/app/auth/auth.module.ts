import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { AuthRoutingModule } from './auth-routing.module';
import { LoginComponent } from './login/login.component';
import { AppAuthService } from '@app/shared/auth/app-auth.service';
import { TokenAuthServiceProxy } from '@app/shared/service-proxies/service-proxies';

@NgModule({
  declarations: [
    LoginComponent
  ],
  imports: [
    CommonModule,
    AuthRoutingModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [AppAuthService, TokenAuthServiceProxy]
})
export class AuthModule { }
