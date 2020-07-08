import { Component, OnInit } from '@angular/core';
import { AuthService } from '../servicers/auth.service';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  model: any = {};

  constructor(private route: Router, private authService: AuthService) {
  }

  ngOnInit() {
  }

  login() {
    this.authService.login(this.model).subscribe(next => {
      this.loggedIn()
      this.route.navigate(['/home']);
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
