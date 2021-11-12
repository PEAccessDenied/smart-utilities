import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-new-property',
  templateUrl: './new-property.component.html',
  styleUrls: ['./new-property.component.scss']
})
export class NewPropertyComponent implements OnInit {
  @ViewChild('content') content: ElementRef;
  newPropertyForm: FormGroup;
  constructor(
    private modalService: NgbModal,
    private fb: FormBuilder,
  ) { }

  ngOnInit() {
    this.initializeForm();
  }

  initializeForm() {
    this.newPropertyForm = this.fb.group({});
  }

  close() {
    this.modalService.dismissAll();
  }

  show() {
    this.modalService.open(this.content);
  }

  save() { }

}
