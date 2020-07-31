import { Component, OnInit } from '@angular/core';
import { Product } from '../models/produts';
import { ProductService } from '../servicers/product.service';
import { ActivatedRoute } from '@angular/router';
import { error } from '@angular/compiler/src/util';

@Component({
  selector: 'app-product-details',
  templateUrl: './product-details.component.html',
  styleUrls: ['./product-details.component.css']
})
export class ProductDetailsComponent implements OnInit {
  product: Product;
  constructor(private productService: ProductService, private route: ActivatedRoute) { }

  ngOnInit() {
    this.route.data.subscribe(data => {
      this.product = data['product'];
    });
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
