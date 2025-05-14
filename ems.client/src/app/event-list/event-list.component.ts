import { Component } from '@angular/core';
import { Event } from '../models/event';

@Component({
  selector: 'app-event-list',
  standalone: false,
  templateUrl: './event-list.component.html',
  styleUrl: './event-list.component.css',
})
export class EventListComponent {
  events: Event[] = [
    {
      id: 1,
      name: 'Cairo Music Fest',
      description: 'Join us for an epic music festival in Cairo!',
      categoryId: 1,
      category: { id: 1, name: 'Music' },
      venue: 'Cairo Opera House',
      pirce: 100,
      imageUrl: '',
      date: '2025-07-12T19:00:00',
      numberOfTickets: 150,
    },
    {
      id: 2,
      name: 'Tech Expo 2025',
      description: 'Explore the future of technology and innovation.',
      categoryId: 2,
      category: { id: 2, name: 'Technology' },
      venue: 'Smart Village, Giza',
      pirce: 75,
      imageUrl: '',
      date: '2025-08-05T10:00:00',
      numberOfTickets: 200,
    },
  ];
}
