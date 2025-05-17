import { Component, NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { EventDetailsComponent } from './event-details/event-details.component';
import { EventListComponent } from './event-list/event-list.component';
import { LoginComponent } from './login/login.component';
import { BookingComponent } from './booking/booking.component';
import { RegisterComponent } from './register/register.component';
import { BookingHistoryComponent } from './booking-history/booking-history.component';
import { AdminDashboardComponent } from './admin/admin-dashboard/admin-dashboard.component';
import { AdminEventListComponent } from './admin/admin-event-list/admin-event-list.component';
import { CreateEditEventComponent } from './admin/create-edit-event/create-edit-event.component';

const routes: Routes = [
  { path: 'events/:id', component: EventDetailsComponent },
  { path: '', component: EventListComponent },
  { path: 'login', component: LoginComponent },
  { path: 'register', component: RegisterComponent },
  { path: 'booking/:id', component: BookingComponent },
  { path: 'my-bookings', component: BookingHistoryComponent },
  { path: 'admin', component: AdminDashboardComponent },
  { path: 'admin/events', component: AdminEventListComponent },
  { path: 'admin/events/create', component: CreateEditEventComponent },
  { path: 'admin/events/create/:id', component: CreateEditEventComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
