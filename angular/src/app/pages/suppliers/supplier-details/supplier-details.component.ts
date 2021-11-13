import { NewResourceComponent } from './../new-resource/new-resource.component';
import { Component, OnInit, ViewChild } from '@angular/core';
import { resources } from '@app/shared/data/data';
import { TableColumn } from '@swimlane/ngx-datatable';

@Component({
  selector: 'app-supplier-details',
  templateUrl: './supplier-details.component.html',
  styleUrls: ['./supplier-details.component.scss']
})
export class SupplierDetailsComponent implements OnInit {
  @ViewChild('newResourceModal') newResourceModal: NewResourceComponent;
  billingTableColumns: TableColumn[] = [];
  resourcesTableColumns: TableColumn[] = [];
  resourcesData = resources;

  constructor() { }

  ngOnInit() {
    this
    this.initColumns();
    this.initData();
  }

  initColumns() {
    this.resourcesTableColumns = [
      { name: 'Category' },
      { name: 'Resource Type' },
      { name: 'Name'},
      { name: 'Location' },
      { name: 'No. Wards' },
      { name: 'Capacity (Litres)' },
    ];

    this.billingTableColumns = [
      { name: 'Month' },
      { name: 'Capacity' },
      { name: 'Consumption'},
      { name: 'Amount(R)' },
      { name: 'Status' },
    ];
  }

  initData() {
  }

  newResource() {
    this.newResourceModal.show();
  }
}
