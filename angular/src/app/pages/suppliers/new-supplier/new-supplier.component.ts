import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { FormGroup, FormBuilder } from '@angular/forms';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap'

@Component({
  selector: 'app-new-supplier',
  templateUrl: './new-supplier.component.html',
  styleUrls: ['./new-supplier.component.scss']
})
export class NewSupplierComponent implements OnInit {
  @ViewChild('content') content: ElementRef;
  newSupplierForm: FormGroup;
  constructor(
    private fb: FormBuilder, private modalService: NgbModal) { }

  ngOnInit() {
    this.initializeForm();
  }

  initializeForm() {
    this.newSupplierForm = this.fb.group({

    });
  }

  show() {
    this.modalService.open(this.content);
  }

  close() {
    this.modalService.dismissAll();
  }

  save() {

  }
}
