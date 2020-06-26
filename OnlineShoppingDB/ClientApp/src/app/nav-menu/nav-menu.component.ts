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
  model: any = {};

  constructor(private authService: AuthService) {
  }

  ngOnInit() {
  }
  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }
  login() {
    this.authService.login(this.model).subscribe(next => {
      console.log("Logging Successfully");
    }, error => {
      console.log("Failed to Logging");
    });
  }

  loggedIn() {
    const token = localStorage.getItem('token');
    return !!token;
  }

  logout() {
    localStorage.removeItem('token');
    console.log("Logged Out");
  }
}
