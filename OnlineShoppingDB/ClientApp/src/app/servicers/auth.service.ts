import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs/operators';
import { Subject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  baseUrl:string = "http://localhost:4200/api/Auth"
  token: any;
  loginStatus = new Subject<boolean>();

  constructor(private http: HttpClient) { }

  login(model: any) {
 
    return this.http.post(`${this.baseUrl}/login`, model)
      .pipe(
        map((Response, any) => {
          const user = Response;
          if (user) {
            this.token = user['token'];
            localStorage.setItem('token', this.token);
            this.loginStatus.next(true);
          }
        }))
  }

  isLoggedIn() {
    const token = localStorage.getItem('token');
    return !!token;
  }
}
