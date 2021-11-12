import { NewSmartMeterComponent } from './new-smart-meter/new-smart-meter.component';
import { Component, OnInit, ViewChild } from '@angular/core';
import { TableColumn } from '@swimlane/ngx-datatable';
import { smartMeters } from '@app/shared/data/data';

@Component({
  selector: 'app-smart-meters',
  templateUrl: './smart-meters.component.html',
  styleUrls: ['./smart-meters.component.scss']
})
export class SmartMetersComponent implements OnInit {
  @ViewChild('assignSmartMeterModal') assignSmartMeterModal: NewSmartMeterComponent;
  columns: TableColumn[] = []
  data = smartMeters;

  constructor() { }

  ngOnInit() {
    this
    this.initColumns();
    this.initData();
  }

  initColumns() {
    this.columns = [
      { name: 'Id' },
      { name: 'Owner' },
      { name: 'DateIssued' },
      { name: 'usage' },
      { name: 'Actions' },
    ];
  }

  initData() {
  }

  newProperty() {
    this.assignSmartMeterModal.show();
  }

}
