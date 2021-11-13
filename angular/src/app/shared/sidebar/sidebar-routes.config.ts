import { title } from 'process';
import { RouteInfo } from './sidebar.metadata';

//Sidebar menu Routes and data
export const ROUTES: RouteInfo[] = [
  {
    path: 'dashboard',
    title: 'Dashboard',
    icon: 'zmdi zmdi-view-dashboard',
    class: '',
    badge: '',
    badgeClass: '',
    isExternalLink: false,
    submenu: [],
  },
  {
    path: '', title: 'Statements', icon: 'zmdi zmdi-file-text', class: 'sub', badge: '', badgeClass: '', isExternalLink: false,
    submenu: [
      { path: 'supplier-statements', title: 'Suppliers', icon: 'zmdi zmdi-group-work', class: '', badge: '', badgeClass: '', isExternalLink: false, submenu: [] },
      { path: 'citizen-statements', title: 'Citizens', icon: 'zmdi zmdi-file-text', class: '', badge: '', badgeClass: '', isExternalLink: false, submenu: [] }
    ]
  },
  {
    path: 'suppliers',
    title: 'Suppliers',
    icon: 'zmdi zmdi-group-work',
    class: '',
    badge: '',
    badgeClass: '',
    isExternalLink: false,
    submenu: [],
  },
  {
    path: 'properties',
    title: 'Properties',
    icon: 'zmdi zmdi-city-alt',
    class: '',
    badge: '',
    badgeClass: '',
    isExternalLink: false,
    submenu: [],
  },
  {
    path: 'smart-meters',
    title: 'Smart Meters',
    icon: 'zmdi zmdi-remote-control',
    class: '',
    badge: '',
    badgeClass: '',
    isExternalLink: false,
    submenu: [],
  },
  {
    path: 'users',
    title: 'Users',
    icon: 'zmdi zmdi-accounts-alt',
    class: '',
    badge: '',
    badgeClass: '',
    isExternalLink: false,
    submenu: [],
  },
  {
    path: 'reports',
    title: 'Reports',
    icon: 'zmdi zmdi-chart',
    class: '',
    badge: '',
    badgeClass: '',
    isExternalLink: false,
    submenu: [],
  },
  {
    path: 'settings',
    title: 'Settings',
    icon: 'zmdi zmdi-settings',
    class: '',
    badge: '',
    badgeClass: '',
    isExternalLink: false,
    submenu: [],
  },
];
