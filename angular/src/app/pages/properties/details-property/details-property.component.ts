import swal from 'sweetalert2';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { Component, OnInit, ViewChild } from '@angular/core';
import { properties, smartMeters } from '@app/shared/data/data';
import { TableColumn } from '@swimlane/ngx-datatable';
import { NewSmartMeterComponent } from '@app/pages/smart-meters/new-smart-meter/new-smart-meter.component';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-details-property',
  templateUrl: './details-property.component.html',
  styleUrls: ['./details-property.component.scss'],
})
export class DetailsPropertyComponent implements OnInit {
  @ViewChild('assignSmartMeterModal')
  assignSmartMeterModal: NewSmartMeterComponent;
  columns: TableColumn[] = [];
  data = properties;
  meters = smartMeters;
  waterCols: TableColumn[] = [];
  electricityCols: TableColumn[] = [];
  users: TableColumn[] = [];

  constructor(private modalService: NgbModal) {}

  ngOnInit(): void {
    this.initColumns();
  }

  initColumns() {
    this.columns = [
      { name: 'ERF NO' },
      { name: 'Owner' },
      { name: 'Location' },
      { name: 'Address' },
      { name: 'Type' },
      { name: 'Users' },
      { name: 'Consumption' },
      { name: 'Actions' },
    ];

    this.waterCols = [
      { name: 'Id' },
      { name: 'Owner' },
      { name: 'DateIssued' },
      { name: 'usage' },
      { name: 'Actions' },
    ];

    this.electricityCols = [
      { name: 'Id' },
      { name: 'Owner' },
      { name: 'DateIssued' },
      { name: 'usage' },
      { name: 'Actions' },
    ];

    this.users = [
      { name: 'Name' },
      { name: 'Identity' },
      { name: 'Role' },
      { name: 'Contact' },
      { name: 'Email Address' },
      { name: '' },
      { name: 'Actions' },
    ];
  }

  assignMeter() {
    // this.assignSmartMeterModal.show();
  }
}
