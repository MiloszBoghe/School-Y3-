import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NieuwsbriefComponent } from './nieuwsbrief.component';

describe('NieuwsbriefComponent', () => {
  let component: NieuwsbriefComponent;
  let fixture: ComponentFixture<NieuwsbriefComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ NieuwsbriefComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(NieuwsbriefComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
