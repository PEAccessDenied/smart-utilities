import { Router } from '@angular/router';
import { AppComponentBase } from '@app/shared/app-component-base';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import {
  Component,
  ElementRef,
  Injector,
  OnInit,
  ViewChild,
} from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-new-property',
  templateUrl: './new-property.component.html',
  styleUrls: ['./new-property.component.scss'],
})
export class NewPropertyComponent extends AppComponentBase implements OnInit {
  @ViewChild('content') content: ElementRef;
  newPropertyForm: FormGroup;
  constructor(
    private modalService: NgbModal,
    private injector: Injector,
    private fb: FormBuilder,
    private route: Router
  ) {
    super(injector);
  }

  ngOnInit() {
    this.initializeForm();
  }

  initializeForm() {
    this.newPropertyForm = this.fb.group({
      owner: [],
      phone: [],
      address: [],
      consumption: [],
      users: [],
      wardNo: [],
    });
  }

  close(s: string) {
    this.modalService.dismissAll();
  }

  save() {
    // this.notify.success('Saved');
    // abp.notify.success('Saved');
    this.modalService.dismissAll();
    this.route.navigate(['properties/details']);
  }
}
