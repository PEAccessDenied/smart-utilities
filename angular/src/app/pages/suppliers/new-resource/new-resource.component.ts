import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-new-resource',
  templateUrl: './new-resource.component.html',
  styleUrls: ['./new-resource.component.scss']
})
export class NewResourceComponent implements OnInit {
  @ViewChild('content') content: ElementRef;

  constructor(private modalService: NgbModal) { }

  ngOnInit() {
  }

  show() {
    this.modalService.open(this.content);
  }
}
