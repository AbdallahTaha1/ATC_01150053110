import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { EventService } from '../../services/event.service';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-create-edit-event',
  standalone: false,
  templateUrl: './create-edit-event.component.html',
  styleUrl: './create-edit-event.component.css',
})
export class CreateEditEventComponent {
  eventForm!: FormGroup;
  isEditMode = false;
  eventId: number | null = null;

  constructor(
    private fb: FormBuilder,
    private eventService: EventService,
    private route: ActivatedRoute,
    private router: Router
  ) {}

  ngOnInit() {
    this.eventId = Number(this.route.snapshot.paramMap.get('id'));
    this.isEditMode = !!this.eventId;

    this.eventForm = this.fb.group({
      name: ['', [Validators.required, Validators.maxLength(120)]],
      description: ['', [Validators.required, Validators.maxLength(1500)]],
      venue: ['', Validators.required],
      price: [0, [Validators.required, Validators.min(0)]],
      date: ['', Validators.required],
      numberOfTickets: [0, [Validators.required, Validators.min(1)]],
      categoryId: [null, Validators.required],
      imageUrl: [''],
    });

    if (this.isEditMode) {
      this.eventService.getEventById(this.eventId!).subscribe((event) => {
        this.eventForm.patchValue(event);
      });
    }
  }

  onSubmit() {
    if (this.eventForm.invalid) {
      this.eventForm.markAllAsTouched();
      return;
    }

    if (this.isEditMode) {
      this.eventService
        .updateEvent(this.eventId!, this.eventForm.value)
        .subscribe(() => {
          this.router.navigate(['/admin/events']);
        });
    } else {
      this.eventService.createEvent(this.eventForm.value).subscribe(() => {
        this.router.navigate(['/admin/events']);
      });
    }
  }
}
