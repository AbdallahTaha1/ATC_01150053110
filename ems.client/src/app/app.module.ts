import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { MatSlideToggleModule } from '@angular/material/slide-toggle';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HeaderComponent } from './header/header.component';
import { FooterComponent } from './footer/footer.component';
import { EventCardComponent } from './event-card/event-card.component';
import { EventDetailsComponent } from './event-details/event-details.component';
import { EventListComponent } from './event-list/event-list.component';
import { LoginComponent } from './login/login.component';
import { BookingComponent } from './booking/booking.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RegisterComponent } from './register/register.component';
import { BookingHistoryComponent } from './booking-history/booking-history.component';
import { AdminDashboardComponent } from './admin/admin-dashboard/admin-dashboard.component';
import { AdminEventListComponent } from './admin/admin-event-list/admin-event-list.component';
import { CreateEditEventComponent } from './admin/create-edit-event/create-edit-event.component';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    FooterComponent,
    EventCardComponent,
    EventDetailsComponent,
    EventListComponent,
    LoginComponent,
    BookingComponent,
    RegisterComponent,
    BookingHistoryComponent,
    AdminDashboardComponent,
    AdminEventListComponent,
    CreateEditEventComponent,
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule,
    MatSlideToggleModule,
    FormsModule,
    ReactiveFormsModule,
  ],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
