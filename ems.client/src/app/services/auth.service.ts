import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root',
})
export class AuthService {
  private apiUrl = 'http://localhost:5095/api/Account';

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

  register(user: {
    firstName: string;
    lastName: string;
    email: string;
    password: string;
  }) {
    return this.http.post<{
      name: string;
      email: string;
      roles: string[];
      jwtToken: string;
      jwtTokenExpiresOn: string;
      message: string;
      isAuthenticated: boolean;
    }>(`${this.apiUrl}/registerUser`, user);
  }

  saveAuthData(token: string, userName: string, role: string) {
    localStorage.setItem('auth_token', token);
    localStorage.setItem('user_name', userName);
    localStorage.setItem('userRole', role);
  }

  getToken(): string | null {
    return localStorage.getItem('auth_token');
  }

  getUserName(): string | null {
    return localStorage.getItem('user_name');
  }

  getUserRole(): string | null {
    return localStorage.getItem('userRole');
  }

  isLoggedIn(): boolean {
    return !!this.getToken();
  }

  logout(): void {
    localStorage.removeItem('auth_token');
    localStorage.removeItem('user_name');
    localStorage.removeItem('userRole');
    this.router.navigate(['/']);
  }
}
