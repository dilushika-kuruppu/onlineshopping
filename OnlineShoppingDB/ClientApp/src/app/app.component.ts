import { Component, OnInit } from '@angular/core';
import { AuthService } from './servicers/auth.service';
import { JwtHelperService } from '@auth0/angular-jwt';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html'
})
export class AppComponent implements OnInit {
  jwtHelper = new JwtHelperService();

  constructor(private authservice: AuthService) {
  }
  ngOnInit() {
    const token = localStorage.getItem('token');
    if (token) {
      this.authservice.decodedToken = this.jwtHelper.decodeToken(token); 
    }

  }

}
