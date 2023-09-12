import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule,ReactiveFormsModule  } from '@angular/forms';

import { AppComponent } from './app.component';
import { ListadoPersonasComponent } from './listado-personas/listado-personas.component';
import { NavBarComponent } from './nav-bar/nav-bar.component';
import { NuevaPersonaComponent } from './nueva-persona/nueva-persona.component';
import { InicioComponent } from './inicio/inicio.component';

import { RouterModule, Routes } from '@angular/router';

const appRoutes: Routes = [
  { path: 'nueva-persona', component: NuevaPersonaComponent },
  { path: 'lista-personas', component: ListadoPersonasComponent },
  { path: 'inicio', component: InicioComponent },
  { path: '', redirectTo: 'inicio', pathMatch: 'full' },
  { path: '**', redirectTo: 'inicio', pathMatch: 'full' },
];
@NgModule({
  declarations: [
    AppComponent,
    ListadoPersonasComponent,
    NavBarComponent,
    NuevaPersonaComponent,
    InicioComponent,
  ],
  imports: [BrowserModule, RouterModule.forRoot(appRoutes), FormsModule, ReactiveFormsModule], 
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
