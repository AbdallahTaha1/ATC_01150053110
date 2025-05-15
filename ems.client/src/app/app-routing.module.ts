import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { EventDetailsComponent } from './event-details/event-details.component';
import { EventListComponent } from './event-list/event-list.component';
import { LoginComponent } from './login/login.component';
import { BookingComponent } from './booking/booking.component';

const routes: Routes = [
  { path: 'events/:id', component: EventDetailsComponent },
  { path: '', component: EventListComponent },
  { path: 'login', component: LoginComponent },
  { path: 'booking/:id', component: BookingComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
