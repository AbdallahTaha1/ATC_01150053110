import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class AuthService {
  private isLoggedIn = true; // Set to false to test logout state
  private userName = 'Ahmed Salah';

  get isAuthenticated(): boolean {
    return this.isLoggedIn;
  }

  get currentUser(): string {
    return this.userName;
  }

  logout(): void {
    this.isLoggedIn = false;
  }
}
