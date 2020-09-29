import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { StijlComponent } from './stijl.component';

describe('StijlComponent', () => {
  let component: StijlComponent;
  let fixture: ComponentFixture<StijlComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ StijlComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(StijlComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
