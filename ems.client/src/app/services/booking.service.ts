import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { AuthService } from './auth.service';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class BookingService {
  private apiUrl = 'http://localhost:5095/api/booking';

  constructor(private http: HttpClient, private authService: AuthService) {}

  bookTickets(data: { id: number; numberOfTickets: number }): Observable<any> {
    const token = this.authService.getToken();
    const headers = new HttpHeaders({
      Authorization: `Bearer ${token}`,
    });
    console.log(data);

    return this.http.post(this.apiUrl, data, { headers });
  }
}
