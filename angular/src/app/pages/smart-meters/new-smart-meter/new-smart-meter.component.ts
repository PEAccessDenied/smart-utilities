import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { FormGroup } from '@angular/forms';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-new-smart-meter',
  templateUrl: './new-smart-meter.component.html',
  styleUrls: ['./new-smart-meter.component.scss']
})
export class NewSmartMeterComponent implements OnInit {
  @ViewChild('content') content: ElementRef;
  newMeterForm: FormGroup;

  constructor(private modalService: NgbModal) { }

  ngOnInit() {
  }

  close() {
    this.modalService.dismissAll();
  }

  show() {
    this.modalService.open(this.content);
  }

  save() {

  }

}
