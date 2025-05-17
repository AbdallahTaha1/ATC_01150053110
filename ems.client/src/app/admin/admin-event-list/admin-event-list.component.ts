import { Component, OnInit } from '@angular/core';
import { EventService } from '../../services/event.service';
import { Router } from '@angular/router';
import { Event } from '../../models/event';

@Component({
  selector: 'app-admin-event-list',
  standalone: false,
  templateUrl: './admin-event-list.component.html',
  styleUrl: './admin-event-list.component.css',
})
export class AdminEventListComponent implements OnInit {
  events: Event[] = [];
  error = '';

  constructor(private eventService: EventService, private router: Router) {}

  ngOnInit(): void {
    console.log('hello ngOnInit');

    this.loadEvents();
  }

  loadEvents() {
    this.error = '';
    this.eventService.getAllEvents().subscribe({
      next: (data) => {
        this.events = data;
      },
      error: (err) => {
        this.error = 'Failed to load events.';
        console.error(err);
      },
    });
  }

  editEvent(id: number) {
    this.router.navigate(['/admin/events/create', id]);
  }

  deleteEvent(id: number) {
    if (confirm('Are you sure you want to delete this event?')) {
      this.eventService.deleteEvent(id).subscribe({
        next: () => this.loadEvents(),
        error: (err) => alert('Failed to delete event.'),
      });
    }
  }
}
