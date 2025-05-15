import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root',
})
export class AuthService {
  private apiUrl = 'http://localhost:5095/api/Account'; // Update to your login endpoint

  constructor(private http: HttpClient, private router: Router) {}

  login(credentials: { email: string; password: string }) {
    return this.http.post<{
      name: string;
      email: string;
      roles: string[];
      jwtToken: string;
      jwtTokenExpiresOn: string;
      message: string;
      isAuthenticated: boolean;
    }>(`${this.apiUrl}/authenticate`, credentials);
  }

  saveAuthData(token: string, userName: string) {
    localStorage.setItem('auth_token', token);
    localStorage.setItem('user_name', userName);
  }

  getToken(): string | null {
    return localStorage.getItem('auth_token');
  }

  getUserName(): string | null {
    return localStorage.getItem('user_name');
  }

  isLoggedIn(): boolean {
    return !!this.getToken();
  }

  logout(): void {
    localStorage.removeItem('auth_token');
    localStorage.removeItem('user_name');
    this.router.navigate(['/']);
  }
}
