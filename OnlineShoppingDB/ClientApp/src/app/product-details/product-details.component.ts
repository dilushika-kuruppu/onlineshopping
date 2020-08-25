import { Component, OnInit } from '@angular/core';
import { Product } from '../models/produts';
import { ProductService } from '../servicers/product.service';
import { ActivatedRoute } from '@angular/router';
import { error } from '@angular/compiler/src/util';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-product-details',
  templateUrl: './product-details.component.html',
  styleUrls: ['./product-details.component.css']
})
export class ProductDetailsComponent implements OnInit {
  product: Product;

  cartService: any;
  constructor(private productService: ProductService, private toastr: ToastrService, private route: ActivatedRoute) { }


  ngOnInit() {
    this.route.data.subscribe(data => {
      this.product = data['product'];
    });
  }

  addToCart() {
    console.log(this.product);
    if (this.product.items == null) {
      this.product.items = 1;
    }
    if (this.cartService.addToCart(this.product)) {
      this.toastr.success(' product added to cart ');
    }
    else {
      this.toastr.error(' item already added  ');
    }
    //loadProduct() {
    //  this.productService.getProduct(this.route.snapshot.params['id']).subscribe((product: Product) => {
    //    this.product = product;
    //  },
    //    error => {
    //      console.log(error);
    //    });
    //}

  }

  //loadProduct() {
  //  this.productService.getProduct(this.route.snapshot.params['id']).subscribe((product: Product) => {
  //    this.product = product;
  //  },
  //    error => {
  //      console.log(error);
  //    });
  //}


}
