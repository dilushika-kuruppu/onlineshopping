<<<<<<< HEAD
import { Component, OnInit, Input, OnChanges, SimpleChanges } from '@angular/core';
import { Product } from '../models/produts';
import { ProductService } from '../servicers/product.service';
import { Category } from '../models/category';
=======
import { Component, OnInit } from '@angular/core';
import { Product } from '../models/produts';
import { ProductService } from '../servicers/product.service';
>>>>>>> ad49b4b0c2207cbde6f0503cba0455cafbd7b9d2

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
<<<<<<< HEAD
export class ProductComponent implements OnInit, OnChanges {

  @Input() selectedLevel: number;
=======
export class ProductComponent implements OnInit {

>>>>>>> ad49b4b0c2207cbde6f0503cba0455cafbd7b9d2
  products: Product[];

  constructor(private productService: ProductService) { }

  ngOnInit() {
<<<<<<< HEAD

    this.loadProducts();
    //this.products = [];
    //var product = <Product>{};
    //product.name = "TShirt"
    //product.categoryId = 1
    //product.description = "ashdkas dklasjdlas jdklasdkjhaskjd haskjdaslda"
    //product.image = "https://i.ebayimg.com/images/g/134AAOSwFMtcvgcr/s-l300.jpg"
    //this.products.push(product);
  }

  loadProducts() {
    this.productService.getProducts().subscribe(data => {
      console.log(data);
      this.products = data;
    },
      error => {
        this.products = [];
=======
    this.loadProducts();
  }

  loadProducts() {
    this.productService.getProducts().subscribe((products: Product[]) => {
      this.products = products;
    },
      error => {
>>>>>>> ad49b4b0c2207cbde6f0503cba0455cafbd7b9d2
        console.log(error);
      })
  }

<<<<<<< HEAD
  ngOnChanges(change: SimpleChanges) {
    console.log("category changed")
    this.productService.getProductstoCategory(this.selectedLevel).subscribe(data => {
      this.products = data;
    }, er => {
        this.products = [];
    });
  }

=======
>>>>>>> ad49b4b0c2207cbde6f0503cba0455cafbd7b9d2
}
