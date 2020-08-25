import { Component, OnInit, EventEmitter, Output } from '@angular/core';
import { Router } from '@angular/router';
import { AuthService } from '../servicers/auth.service';
import { AlertifyService } from '../servicers/alertify.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  model: any = {};
  @Output() cancelRegister = new EventEmitter();
    
   

  constructor(private route: Router, private authService: AuthService, private alertify: AlertifyService) { }

  ngOnInit() {
  }
  
  register() {
      this.authService.customer(this.model).subscribe(next => {
        this.registeredIn()
        this.alertify.success("Register  Successfully");
      }, error => {
        this.alertify.error(error);
      });
    }
    registeredIn() {
      const email = localStorage.getItem('email');
      return !!email;
    }
  cancel() {
    this.cancelRegister.emit(false);
    this.alertify.message("canceled");
  }
}
