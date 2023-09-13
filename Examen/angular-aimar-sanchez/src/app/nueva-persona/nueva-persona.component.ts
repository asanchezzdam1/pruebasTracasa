import { Component, OnDestroy, OnInit } from '@angular/core';
import { Validators, FormBuilder, FormGroup } from '@angular/forms';
import { IPersona } from './IPersona';
import { Router } from '@angular/router';
import { Subscription } from 'rxjs';
import { personaService } from './personaService';
import { listadoPersonasService } from '../listado-personas/listadoPersonasService';

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
  sub!: Subscription;
  resultRegistro: string="";
  personas!:IPersona[];

  constructor(public fb: FormBuilder, public router: Router,  private personaService: personaService, public listadoPersonasService:listadoPersonasService) {
    this.myForm = this.fb.group({
      nombre: [
        '',
        [
          Validators.required,
          Validators.maxLength(50),
          Validators.pattern('^[a-zA-Z ]{1,50}$'),
        ],
      ],
      telefono: [
        '',
        [
          Validators.required,
          Validators.maxLength(25),
          Validators.pattern(/^\+[0-9]{1,3}-[0-9]{3,14}$/),
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
  //Rellena con los datos del html un registro DTO
  rellenarRegistro(myForm: FormGroup): void {
    const registroDTO: IPersona = {
      id:"",
      nombre: myForm.value.nombre,
      telefono: myForm.value.telefono,
      fechaNacimiento: myForm.value.fecha

    };
    this.postRegistro(registroDTO);
    // this.router.navigate(['/lista-personas']);
  }
  cargarLista(cambio : boolean): void {
    this.sub = this.listadoPersonasService.get10UltimosRegistros().subscribe({
      next: personas => {
        this.personas = personas;
      },
    });
  }
  //Realiza el POST enviando el registro rellenado
  postRegistro(registroDTO: IPersona): void {
    this.personaService.anadirPersona(registroDTO).subscribe({
      next: (registro) => {
        this.resultRegistro = registro;
        this.cargarLista(true);
      },
    });
  }
}
