import { Component, OnInit } from '@angular/core';
import { Product } from '../models/produts';
import { ProductService } from '../servicers/product.service';
import { ActivatedRoute } from '@angular/router';
import { error } from '@angular/compiler/src/util';
<<<<<<< HEAD
import { ToastrService } from 'ngx-toastr';
=======
>>>>>>> ad49b4b0c2207cbde6f0503cba0455cafbd7b9d2

@Component({
  selector: 'app-product-details',
  templateUrl: './product-details.component.html',
  styleUrls: ['./product-details.component.css']
})
export class ProductDetailsComponent implements OnInit {
  product: Product;
<<<<<<< HEAD

  cartService: any;
  constructor(private productService: ProductService, private toastr: ToastrService, private route: ActivatedRoute) { }

=======
  constructor(private productService: ProductService, private route: ActivatedRoute) { }
>>>>>>> ad49b4b0c2207cbde6f0503cba0455cafbd7b9d2

  ngOnInit() {
    this.route.data.subscribe(data => {
      this.product = data['product'];
    });
  }
<<<<<<< HEAD

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

=======
>>>>>>> ad49b4b0c2207cbde6f0503cba0455cafbd7b9d2
  //loadProduct() {
  //  this.productService.getProduct(this.route.snapshot.params['id']).subscribe((product: Product) => {
  //    this.product = product;
  //  },
  //    error => {
  //      console.log(error);
  //    });
  //}

<<<<<<< HEAD

=======
>>>>>>> ad49b4b0c2207cbde6f0503cba0455cafbd7b9d2
}
