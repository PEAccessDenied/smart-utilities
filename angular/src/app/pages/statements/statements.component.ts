import { Component, OnInit } from '@angular/core';
import { TableColumn } from '@swimlane/ngx-datatable';
import { statements } from '../../shared/data/statements';

@Component({
  selector: 'app-statements',
  templateUrl: './statements.component.html',
  styleUrls: ['./statements.component.scss']
})
export class StatementsComponent implements OnInit {
  columns: TableColumn[] = []
  data = statements;
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
