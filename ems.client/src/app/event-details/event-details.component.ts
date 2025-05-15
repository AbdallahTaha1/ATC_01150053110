import { Component, OnInit } from '@angular/core';
import { EventService } from '../services/event.service';
import { ActivatedRoute, Router } from '@angular/router';
import { Event } from '../models/event';

@Component({
  selector: 'app-event-details',
  standalone: false,
  templateUrl: './event-details.component.html',
  styleUrl: './event-details.component.css',
})
export class EventDetailsComponent implements OnInit {
  event?: Event;
  title = 'Event details';
  error: any;

  constructor(
    private eventService: EventService,
    private router: Router,
    private route: ActivatedRoute
  ) {}

  ngOnInit(): void {
    const id = this.route.snapshot.paramMap.get('id');
    if (id) {
      this.eventService.getEventById(id).subscribe({
        next: (response) => {
          this.event = response;
          console.log('Event fetched:', this.event);
        },
        error: (err) => {
          this.error = err;
          console.error('Error fetching event:', err);
          //this.router.navigate(['/events']);
        },
      });
    }
  }

  bookEvent(): void {
    this.router.navigate(['/booking', this.event?.id]);
  }
}
