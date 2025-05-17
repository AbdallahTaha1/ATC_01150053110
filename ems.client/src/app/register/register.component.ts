import { Component } from '@angular/core';
import { AuthService } from '../services/auth.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-register',
  standalone: false,
  templateUrl: './register.component.html',
  styleUrl: './register.component.css',
})
export class RegisterComponent {
  user = {
    firstName: '',
    lastName: '',
    email: '',
    password: '',
  };

  error: string | null = null;

  constructor(private authService: AuthService, private router: Router) {}

  register() {
    this.authService.register(this.user).subscribe({
      next: (res) => {
        this.authService.saveAuthData(res.jwtToken, res.name, res.roles[0]);
        this.router.navigate(['/']);
      },
      error: (err) => {
        this.error = err.error?.message || 'Registration failed. Try again.';
      },
    });
  }
}
