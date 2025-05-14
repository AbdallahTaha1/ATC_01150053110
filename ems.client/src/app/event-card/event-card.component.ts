import { Component, Input } from '@angular/core';
import { Event } from '../models/event';
import { Router } from '@angular/router';

@Component({
  selector: 'app-event-card',
  standalone: false,
  templateUrl: './event-card.component.html',
  styleUrl: './event-card.component.css',
})
export class EventCardComponent {
  @Input() event!: Event;
  constructor(private router: Router) {}

  goToDetails(eventClick: MouseEvent) {
    // Ignore if user clicked the button
    const target = eventClick.target as HTMLElement;
    if (target.closest('button')) return;

    this.router.navigate(['/events', this.event.id]);
  }

  bookNow(eventClick: MouseEvent) {
    eventClick.stopPropagation(); // Prevent card click from firing
    this.router.navigate(['/booking', this.event.id]);
  }
}
