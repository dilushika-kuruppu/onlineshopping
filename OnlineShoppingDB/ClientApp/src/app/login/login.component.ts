import { Component, OnInit } from '@angular/core';
import { AuthService } from '../servicers/auth.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  model: any = {};

  constructor(private authService: AuthService) {
  }

  ngOnInit() {
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
    return !token;
  }

  logout() {
    localStorage.removeItem('token');
    console.log("Logged Out");
  }

}
