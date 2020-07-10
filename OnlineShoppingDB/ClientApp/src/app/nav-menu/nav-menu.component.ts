import { Component, OnInit } from '@angular/core';
import { AuthService } from '../servicers/auth.service';
import { error } from '@angular/compiler/src/util';
import { Router } from '@angular/router';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent implements OnInit {
  isExpanded = false;
  registerMode = false;
  loginMode = false; 

  constructor(private authService: AuthService, private route: Router) {
  }

  ngOnInit() {
    this.authService.loginStatus.subscribe(r => {
      this.loginMode = r;
    });

    this.loginMode = this.authService.isLoggedIn();
  }

  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }

  
}
