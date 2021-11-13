import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-statement-detail',
  templateUrl: './statement-detail.component.html',
  styleUrls: ['./statement-detail.component.scss']
})
export class StatementDetailComponent implements OnInit {

  today = new Date();
  constructor() { }

  ngOnInit() {
  }

}
