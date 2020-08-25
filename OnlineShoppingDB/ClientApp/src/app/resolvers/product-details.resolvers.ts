import { Injectable } from "@angular/core";
<<<<<<< HEAD
import { Product } from "../models/products";
=======
import { Product } from "../models/produts";
>>>>>>> ad49b4b0c2207cbde6f0503cba0455cafbd7b9d2
import { Resolve, Router, ActivatedRouteSnapshot } from "@angular/router";
import { ProductService } from "../servicers/product.service";
import { Observable, of, throwError } from "rxjs";
import { catchError } from "rxjs/operators";
import { error } from "selenium-webdriver";

@Injectable()

export class ProductDetailsResolvers implements Resolve<Product>{

  constructor(private productService: ProductService, private router: Router) {
  }
  resolve(route: ActivatedRouteSnapshot): Observable<Product> {
    return this.productService.getProduct(route.params['id']).pipe(
      catchError(error => {
        console.log("problem retiving data");
        this.router.navigate(['./product']);
        return throwError(error);
      })
    );
  }
}
