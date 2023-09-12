import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NuevaPersonaComponent } from './nueva-persona.component';

describe('NuevaPersonaComponent', () => {
  let component: NuevaPersonaComponent;
  let fixture: ComponentFixture<NuevaPersonaComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [NuevaPersonaComponent]
    });
    fixture = TestBed.createComponent(NuevaPersonaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
