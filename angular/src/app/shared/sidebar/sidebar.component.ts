import { Component, OnInit } from '@angular/core';
import { ROUTES } from './sidebar-routes.config';
import { Router, Event, NavigationStart, NavigationEnd, NavigationError } from '@angular/router';
import { SidebarService } from "../sidebar/sidebar.service";

import * as $ from 'jquery';


@Component({
  selector: 'app-sidebar',
  templateUrl: './sidebar.component.html',
})

export class SidebarComponent implements OnInit {

  public menuItems: any[];

  constructor(public sidebarService: SidebarService, private router: Router) {

    router.events.subscribe((event: Event) => {

      if (event instanceof NavigationStart) {
        // Show loading indicator
      }

      if (event instanceof NavigationEnd && $(window).width() < 1025 && (document.readyState == 'complete' || false)) {

        this.toggleSidebar();
        // Hide loading indicator

      }

      if (event instanceof NavigationError) {
        // Hide loading indicator

        // Present error to user
        console.log(event.error);
      }
    });

  }


  toggleSidebar() {
    this.sidebarService.setSidebarState(!this.sidebarService.getSidebarState());

  }

  getSideBarState() {
    return this.sidebarService.getSidebarState();
  }

  hideSidebar() {
    this.sidebarService.setSidebarState(true);
  }


  ngOnInit() {
    this.menuItems = ROUTES.filter(menuItem => menuItem);
    $.getScript('./assets/js/app-sidebar.js');

  }

  get activeRoute(): string {
    return this.router.url.split('/')[1]
  }
}
