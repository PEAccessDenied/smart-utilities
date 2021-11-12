import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  constructor() { }


  login() {
    localStorage.setItem('token', 'AIzaSyDKXKdHQdtqgPVl2HI2RnUa_1bjCxRCQo4');
  }

  logout() {
    localStorage.removeItem('token');
    location.reload();
  }
}
