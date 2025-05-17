import { Component, OnInit } from '@angular/core';
import { BookingService } from '../services/booking.service';

@Component({
  selector: 'app-booking-history',
  standalone: false,
  templateUrl: './booking-history.component.html',
  styleUrl: './booking-history.component.css',
})
export class BookingHistoryComponent implements OnInit {
  bookings: any[] = [];
  error: string = '';

  constructor(private bookingService: BookingService) {}

  ngOnInit(): void {
    this.bookingService.getUserBookings().subscribe({
      next: (res) => {
        this.bookings = res;
      },
      error: (err) => {
        console.error(err);
        this.error = 'Failed to fetch booking history.';
      },
    });
  }
}
