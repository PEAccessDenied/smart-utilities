import { Component, OnInit } from '@angular/core';
import { TableColumn } from '@swimlane/ngx-datatable';
import { supplierStatements } from '../../shared/data/statements';

@Component({
  selector: 'app-statements',
  templateUrl: './supplier-statements.component.html',
  styleUrls: ['./supplier-statements.component.scss']
})
export class SupplierStatementsComponent implements OnInit {
  columns: TableColumn[] = []
  data = supplierStatements;
  constructor() { }

  ngOnInit() {
    this.initColumns();
    this.initData();
  }

  initColumns() {
    this.columns = [
      { name: 'Date' },
      { name: 'Full Name' },
      { name: 'Amount' },
      { name: 'Status' },
      { name: 'Actions' },
    ];
  }

  initData() {
  }
}
