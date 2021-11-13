import { AppComponentBase } from '@shared/app-component-base';
import {
  Component,
  OnInit,
  Injector,
  Input,
  ElementRef,
  ViewChild,
} from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { properties } from '../../../shared/data/data';
import { NgbActiveModal, NgbModal } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-edit-property',
  templateUrl: './edit-property.component.html',
  styleUrls: ['./edit-property.component.scss'],
})
export class EditPropertyComponent extends AppComponentBase implements OnInit {
  @Input() id;
  @ViewChild('content') content: ElementRef;
  editPropertyForm: FormGroup;
  data = properties;
  name: string;

  constructor(
    private fb: FormBuilder,
    public injector: Injector,
    private modal: NgbActiveModal,
    private modalService: NgbModal
  ) {
    super(injector);
  }

  ngOnInit(): void {
    this.init();
    // this.show(this.id);
  }

  init() {
    this.editPropertyForm = this.fb.group({
      id: [],
      owner: [],
      location: [],
      consumption: [],
      type: [],
    });
  }

  show() {
    // this.data.filter((x) => {
    //   if (x.id === id) {
    //     this.name = x.owner;
    //     this.editPropertyForm.patchValue(x);
    //   }
    // });

    this.modalService.open(this.content);
  }

  close(s: string) {
    this.modal.close(s);
  }

  save() {}
}
