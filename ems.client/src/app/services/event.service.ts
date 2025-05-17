import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Event } from '../models/event';
import { AuthService } from './auth.service';

@Injectable({
  providedIn: 'root',
})
export class EventService {
  private apiUrl = 'http://localhost:5095/api/Events';

  constructor(private http: HttpClient, private authService: AuthService) {}

  getAllEvents(): Observable<Event[]> {
    return this.http.get<Event[]>(this.apiUrl);
  }

  getEventById(id: number | null): Observable<Event> {
    console.log(`${this.apiUrl}/${id}`);

    return this.http.get<Event>(`${this.apiUrl}/${id}`);
  }

  createEvent(event: any): Observable<any> {
    const token = this.authService.getToken();
    const headers = new HttpHeaders({
      Authorization: `Bearer ${token}`,
    });
    return this.http.post(`${this.apiUrl}`, event, { headers });
  }

  updateEvent(id: number, event: Event): Observable<any> {
    const token = this.authService.getToken();
    const headers = new HttpHeaders({
      Authorization: `Bearer ${token}`,
    });
    event.id = id;
    console.log(event);
    return this.http.put(`${this.apiUrl}`, event, { headers });
  }

  deleteEvent(id: number): Observable<any> {
    const token = this.authService.getToken();
    const headers = new HttpHeaders({
      Authorization: `Bearer ${token}`,
    });
    return this.http.delete(`${this.apiUrl}/${id}`, { headers });
  }
}
