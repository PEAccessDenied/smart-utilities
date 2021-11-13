import { Router } from '@angular/router';
import { EditPropertyComponent } from './edit-property/edit-property.component';
import { Component, OnInit, ViewChild } from '@angular/core';
import { properties } from '@app/shared/data/data';
import { TableColumn } from '@swimlane/ngx-datatable';
import { NewPropertyComponent } from './new-property/new-property.component';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-properties',
  templateUrl: './properties.component.html',
  styleUrls: ['./properties.component.scss'],
})
export class PropertiesComponent implements OnInit {
  @ViewChild('newPropertyModal') newPropertyModal: NewPropertyComponent;
  columns: TableColumn[] = [];
  data = properties;

  constructor(private modalService: NgbModal, private route: Router) {}

  ngOnInit() {
    this;
    this.initColumns();
    this.initData();
  }

  initColumns() {
    this.columns = [
      // { name: 'ERF NO' },
      { name: 'Owner' },
      { name: 'Location' },
      { name: 'Address' },
      // { name: 'Type' },
      // { name: 'Users' },
      // { name: 'Consumption' },
      { name: 'Actions' },
    ];
  }

  initData() {}

  show() {
    this.modalService.open(NewPropertyComponent, {
      size: 'md',
    });
  }

  details(data: any) {
    this.route.navigate(['properties/details']);
  }

  edit() {}
}
