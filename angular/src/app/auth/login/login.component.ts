import { AppAuthService } from './../../shared/auth/app-auth.service';
import { AuthService } from './../../core/services/auth.service';
import { Component, Injector, OnInit, ViewChild } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Router, ActivatedRoute } from '@angular/router';
import { AbpSessionService } from 'abp-ng2-module';
import { AppComponentBase } from '@app/shared/app-component-base';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent extends AppComponentBase {

  @ViewChild('f') loginForm: NgForm;
  submitting = false;
  constructor(
    injector: Injector,
    public authService: AppAuthService,
    private _sessionService: AbpSessionService) {
    super(injector)
  }


  //  On submit click, reset field value
  onSubmit() {
    this.submitting = true;
    this.authService.authenticate(() => (this.submitting = false));
  }
  get multiTenancySideIsTeanant(): boolean {
    return this._sessionService.tenantId > 0;
  }

  get isSelfRegistrationAllowed(): boolean {
    if (!this._sessionService.tenantId) {
      return false;
    }

    return true;
  }

  onResetPassword() {

  }
}
