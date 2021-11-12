import { Component, OnInit, ViewChild } from '@angular/core';
import { properties } from '@app/shared/data/data';
import { TableColumn } from '@swimlane/ngx-datatable';
import { NewPropertyComponent } from './new-property/new-property.component';

@Component({
  selector: 'app-properties',
  templateUrl: './properties.component.html',
  styleUrls: ['./properties.component.scss']
})
export class PropertiesComponent implements OnInit {

  @ViewChild('newPropertyModal') newPropertyModal: NewPropertyComponent;
  columns: TableColumn[] = []
  data = properties;

  constructor() { }

  ngOnInit() {
    this
    this.initColumns();
    this.initData();
  }

  initColumns() {
    this.columns = [
      { name: 'Owner' },
      { name: 'Location' },
      { name: 'Address' },
      { name: 'Actions' },
    ];
  }

  initData() {
  }

  newProperty() {
    this.newPropertyModal.show();
  }

}
