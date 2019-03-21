import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ValelistComponent } from './valelist.component';

describe('ValelistComponent', () => {
  let component: ValelistComponent;
  let fixture: ComponentFixture<ValelistComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ValelistComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ValelistComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
