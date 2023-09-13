import { Component, OnInit, OnDestroy, Input, Output, EventEmitter, OnChanges} from '@angular/core';
import { Subscription } from 'rxjs';
import { listadoPersonasService } from './listadoPersonasService';
import { IPersona } from './IPersona';

@Component({
  selector: 'app-listado-personas',
  templateUrl: './listado-personas.component.html',
  styleUrls: ['./listado-personas.component.css'],
})
export class ListadoPersonasComponent implements OnInit, OnDestroy, OnChanges{
  errorMessage: string = '';
  sub!: Subscription;
  @Input() personas!:IPersona[];
  @Output() cambio: EventEmitter<boolean> =
  new EventEmitter<boolean>();
  constructor(private listadoPersonasService: listadoPersonasService){}
  onClick(): void {
    this.cambio.emit(false);
  }
  ngOnChanges(): void {
    this.actualizar()
  }
  //Cargar el historial
  ngOnInit(): void {

    }
  actualizar() {
    this.sub = this.listadoPersonasService.get10UltimosRegistros().subscribe({
      next: (personas) => {
        this.personas = personas;
      },
    });
  }
  ngOnDestroy(): void {
    this.sub.unsubscribe();
  }
}
