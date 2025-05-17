import { Component } from '@angular/core';
import { AuthService } from '../services/auth.service';

@Component({
  selector: 'app-header',
  standalone: false,
  templateUrl: './header.component.html',
  styleUrl: './header.component.css',
})
export class HeaderComponent {
  constructor(public authService: AuthService) {}

  get isAdmin(): boolean {
    const role = this.authService.getUserRole();
    return role === 'Admin';
  }

  get userName(): string | null {
    return this.authService.getUserName();
  }

  logout() {
    this.authService.logout();
  }
}
