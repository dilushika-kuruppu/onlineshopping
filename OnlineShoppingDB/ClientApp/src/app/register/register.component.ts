import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AuthService } from '../servicers/auth.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  model: any = {};
   

  constructor(private route: Router, private authService: AuthService) { }

  ngOnInit() {
  }
  
  register() {
   
      this.authService.customer(this.model).subscribe(next => {
        this.registeredIn()
        this.route.navigate(['/login']);
        console.log("Register  Successfully");
      }, error => {
        console.log("Failed to Register");
      });
    }
    registeredIn() {
      const email = localStorage.getItem('email');
      return !!email;
    }
  cancel() {
    console.log("canceled");
  }
}
