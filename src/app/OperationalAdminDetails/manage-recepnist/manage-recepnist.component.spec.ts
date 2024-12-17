import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ManageRecepnistComponent } from './manage-recepnist.component';

describe('ManageRecepnistComponent', () => {
  let component: ManageRecepnistComponent;
  let fixture: ComponentFixture<ManageRecepnistComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ManageRecepnistComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ManageRecepnistComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
