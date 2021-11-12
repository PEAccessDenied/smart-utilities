import { Component, OnInit, ViewChild } from '@angular/core';
import { suppliers } from '@app/shared/data/data';
import { TableColumn } from '@swimlane/ngx-datatable';
import { NewSupplierComponent } from './new-supplier/new-supplier.component';

@Component({
  selector: 'app-suppliers',
  templateUrl: './suppliers.component.html',
  styleUrls: ['./suppliers.component.scss']
})
export class SuppliersComponent implements OnInit {
  @ViewChild('newSupplierModal') newSupplierModal: NewSupplierComponent;
  columns: TableColumn[] = []
  data = suppliers;

  constructor() { }

  ngOnInit() {
    this
    this.initColumns();
    this.initData();
  }

  initColumns() {
    this.columns = [
      { name: 'Company' },
      { name: 'Phone' },
      { name: 'Areas Served' },
      { name: 'Actions' },
    ];
  }

  initData() {
  }

  newSupplier() {
    this.newSupplierModal.show();
  }
}
