import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BsDropdownModule } from 'ngx-bootstrap/dropdown';
import { TabsModule } from 'ngx-bootstrap/tabs';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { ToastrModule } from 'ngx-toastr';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { AuthService } from './servicers/auth.service';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';
import { AppRoutingModule } from './app-routing.module';
import { ErrorInterceptorProvider } from './servicers/error.interceptor';
<<<<<<< HEAD
import { ToastrService } from './servicers/toastr.service';
=======
import { AlertifyService } from './servicers/alertify.service';
>>>>>>> ad49b4b0c2207cbde6f0503cba0455cafbd7b9d2
import { ProductComponent } from './product/product.component';
import { CategoryComponent } from './category/category.component';
import { ProductService } from './servicers/product.service';
import { ProductDetailsComponent } from './product-details/product-details.component';
import { ProductDetailsResolvers } from './resolvers/product-details.resolvers';
<<<<<<< HEAD
import { AngularFontAwesomeModule } from 'angular-font-awesome';
import { PaymentComponent } from './payment/payment.component';
import { PaymentService } from './servicers/payment.service';
=======

>>>>>>> ad49b4b0c2207cbde6f0503cba0455cafbd7b9d2


@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    LoginComponent,
    RegisterComponent,
    ProductComponent,
    CategoryComponent,
    ProductDetailsComponent,
<<<<<<< HEAD
    PaymentComponent,
=======
>>>>>>> ad49b4b0c2207cbde6f0503cba0455cafbd7b9d2
    
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
<<<<<<< HEAD
    AngularFontAwesomeModule,
=======
>>>>>>> ad49b4b0c2207cbde6f0503cba0455cafbd7b9d2
    BsDropdownModule.forRoot(),
    TabsModule.forRoot(),
    ToastrModule.forRoot(),
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
    ]),
    AppRoutingModule
  ],
  providers: [
    AuthService,
    //ErrorInterceptorProvider,
<<<<<<< HEAD
    ToastrService,
    ProductService,
    ProductDetailsResolvers,
    PaymentService,
=======
    AlertifyService,
    ProductService,
    ProductDetailsResolvers,
>>>>>>> ad49b4b0c2207cbde6f0503cba0455cafbd7b9d2
   
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
