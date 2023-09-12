import { Component } from '@angular/core';
import { Validators, FormBuilder, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-nueva-persona',
  templateUrl: './nueva-persona.component.html',
  styleUrls: ['./nueva-persona.component.css'],
})
export class NuevaPersonaComponent {
  nombre: string = '';
  telefono: string = '';
  fecha: string = '';
  myForm!: FormGroup;

  constructor(public fb: FormBuilder) {
    this.myForm = this.fb.group({
      nombre: [
        '',
        [
          Validators.required,
          Validators.maxLength(50),
          Validators.pattern('^[a-zA-Z]{1,50}$'),
        ],
      ],
      telefono: [
        '',
        [
          Validators.required,
          Validators.maxLength(25),
      //     Validators.pattern('^[+]{1}d{1,3}d{1,15}$'),
        ],
      ],
      fecha: [
        '',
        [
          Validators.required,
          Validators.max(new Date(new Date().getFullYear() - 14).getTime()),
          Validators.min(new Date(new Date().getFullYear() - 150).getTime()),
        ],
      ],
    });
  }
}
