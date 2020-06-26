import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  baseUrl: "http://localhost:4200/api/auth"
    token: any;

  constructor(private http: HttpClient) { }

  login(model: any) {
    return this.http.post(this.baseUrl + 'login', model)
      .pipe(
        map((Response, any) => {
          const user = Response;
          if (user) {
            this.token = user['token'];
            localStorage.setItem('token', this.token); 
          }
        }))
  }
}
