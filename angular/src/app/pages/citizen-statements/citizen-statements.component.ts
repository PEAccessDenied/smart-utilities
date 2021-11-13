import { Component, OnInit } from '@angular/core';
import { TableColumn } from '@swimlane/ngx-datatable';
import { citizenStatements } from '../../shared/data/statements';

@Component({
  selector: 'app-statements',
  templateUrl: './citizen-statements.component.html',
  styleUrls: ['./citizen-statements.component.scss']
})
export class CitizenStatementsComponent implements OnInit {
  columns: TableColumn[] = []
  data = citizenStatements;
  constructor() { }

  ngOnInit() {
    this.initColumns();
    this.initData();
  }

  initColumns() {
    this.columns = [
      { name: 'Date' },
      { name: 'Full Name' },
      { name: 'Amount Due' },
      { name: 'Status' },
      { name: 'Actions' },
    ];
  }

  initData() {
  }
}
