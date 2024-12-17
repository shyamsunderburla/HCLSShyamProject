import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddRecepnistComponent } from './add-recepnist.component';

describe('AddRecepnistComponent', () => {
  let component: AddRecepnistComponent;
  let fixture: ComponentFixture<AddRecepnistComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [AddRecepnistComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AddRecepnistComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
