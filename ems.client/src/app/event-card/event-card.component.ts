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
  defaultImage: string =
    'https://images.unsplash.com/photo-1746950862687-3017c5818710?w=600&auto=format&fit=crop&q=60&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxmZWF0dXJlZC1waG90b3MtZmVlZHwyfHx8ZW58MHx8fHx8';
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
