import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { EventService } from '../services/event.service';
import { AuthService } from '../services/auth.service';
import { Event } from '../models/event';
import { BookingService } from '../services/booking.service';

@Component({
  selector: 'app-booking',
  standalone: false,
  templateUrl: './booking.component.html',
  styleUrl: './booking.component.css',
})
export class BookingComponent implements OnInit {
  event!: Event;
  tickets: number = 1;
  totalPrice: number = 0;
  booked: boolean = false;
  error: string = '';

  constructor(
    private route: ActivatedRoute,
    private eventService: EventService,
    private bookingService: BookingService,
    private authService: AuthService,
    private router: Router
  ) {}

  ngOnInit(): void {
    const id = this.route.snapshot.paramMap.get('id');
    if (id) {
      this.eventService.getEventById(id).subscribe({
        next: (res) => {
          this.event = res;
          this.updateTotalPrice();
        },
        error: () => {
          this.error = 'Failed to load event';
        },
      });
    }
  }

  updateTotalPrice() {
    if (this.event) {
      this.totalPrice = this.tickets * this.event.price;
    }
  }

  bookNow() {
    if (!this.authService.isLoggedIn()) {
      this.router.navigate(['/login']);
      return;
    }

    const booking = {
      id: this.event.id,
      numberOfTickets: this.tickets,
    };
    console.log(booking);

    this.bookingService.bookTickets(booking).subscribe({
      next: () => {
        this.booked = true;
      },
      error: () => {
        this.error = 'Booking failed. Please try again.';
      },
    });
  }
}
