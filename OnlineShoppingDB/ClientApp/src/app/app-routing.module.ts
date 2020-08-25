import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { LoginComponent } from './login/login.component';
import { HomeComponent } from './home/home.component';
import { RegisterComponent } from './register/register.component';
import { ProductDetailsComponent } from './product-details/product-details.component';
import { ProductDetailsResolvers } from './resolvers/product-details.resolvers';
import { CartComponent } from './cart/cart.component';
import { ProductListComponent } from './product-list/product-list.component';
import { CategoryResolvers } from './resolvers/category.resolvers';
import { PaymentComponent } from './payment/payment.component';
const routes: Routes = [
  {
    path: 'nav-menu', component: NavMenuComponent
  },

  { path: 'product', component: ProductListComponent ,resolve: { category: CategoryResolvers } },
  { path: 'cart', component: CartComponent },
  { path: 'product/:id', component: ProductDetailsComponent, resolve: { product: ProductDetailsResolvers } },
  { path: 'payment', component: PaymentComponent},
  { path: 'login', component: LoginComponent },
  { path: 'register', component: RegisterComponent },
  { path: 'home', component: HomeComponent },
  { path: '**', redirectTo: '/home', pathMatch: 'full' },

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
