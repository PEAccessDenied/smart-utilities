import { AddUserComponent } from './add-user/add-user.component';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { AppComponentBase } from '@shared/app-component-base';
import { Component, OnInit, Injector } from '@angular/core';
import { TableColumn } from '@swimlane/ngx-datatable';
import { suppliers } from '@app/shared/data/data';

@Component({
  selector: 'app-users',
  templateUrl: './users.component.html',
  styleUrls: ['./users.component.scss'],
})
export class UsersComponent extends AppComponentBase implements OnInit {
  columns: TableColumn[] = [];
  users = suppliers;
  constructor(private inject: Injector, private modalService: NgbModal) {
    super(inject);
  }

  ngOnInit(): void {
    this.initColumns();
  }

  initColumns() {
    this.columns = [
      { name: 'Company' },
      { name: 'Phone' },
      { name: 'Areas Served' },
      { name: 'Actions' },
    ];
  }

  newUser() {
    this.modalService.open(AddUserComponent, {
      centered: true,
    });
  }
}
