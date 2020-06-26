import { Component, OnInit } from '@angular/core';
import { AuthService } from '../servicers/auth.service';
import { error } from '@angular/compiler/src/util';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent implements OnInit {
  isExpanded = false;
 

  constructor() {
  }

  ngOnInit() {
  }

  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }
  
}
