import { Component } from '@angular/core';
import { AuthService } from '../services/auth.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  standalone: false,
  templateUrl: './login.component.html',
  styleUrl: './login.component.css',
})
export class LoginComponent {
  credentials = { email: '', password: '' };
  error: string = '';

  constructor(private authService: AuthService, private router: Router) {}

  login() {
    this.authService.login(this.credentials).subscribe({
      next: (res) => {
        if (res.isAuthenticated) {
          this.authService.saveAuthData(res.jwtToken, res.name, res.roles[0]);
          this.router.navigate(['/']);
        } else {
          this.error = res.message || 'Login failed.';
        }
      },
      error: (err) => {
        console.error(err);
        this.error = 'Invalid email or password';
      },
    });
  }
}
