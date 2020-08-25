import { Injectable } from "@angular/core";
<<<<<<< HEAD

import { Observable, throwError } from "rxjs";
import { Product } from "../models/products";
import { HttpClient } from "@angular/common/http";
import { Category } from "../models/category";
import { catchError } from "rxjs/operators";
import { ToastrService } from "ngx-toastr";

=======
import { Observable } from "rxjs";
import { Product } from "../models/produts";
import { HttpClient } from "@angular/common/http";
import { Category } from "../models/category";
>>>>>>> ad49b4b0c2207cbde6f0503cba0455cafbd7b9d2

@Injectable({
  providedIn: "root"
})

export class ProductService {
  baseUrl = 'api/';
<<<<<<< HEAD


  constructor(private http: HttpClient, private toastr: ToastrService) {
  }
  getProducts(): Observable<Product[]> {
    return this.http.get<Product[]>(this.baseUrl + 'products');
=======
  constructor(private http: HttpClient) {
  }
  getProducts(): Observable<Product[]> {
    return this.http.get<Product[]>(this.baseUrl+ 'products');
>>>>>>> ad49b4b0c2207cbde6f0503cba0455cafbd7b9d2
  }
  getProduct(id): Observable<Product> {
    return this.http.get<Product>(this.baseUrl + id);
  }
  getCategory(): Observable<Category[]> {
    return this.http.get<Category[]>(this.baseUrl + 'categories');
  }

  getProductstoCategory(id): Observable<Product[]> {
    return this.http.get<Product[]>(this.baseUrl + 'product/category/' + id.categotyId);
  }

<<<<<<< HEAD


  handleError(error) {

    let errorMessage = '';

    if (error.error instanceof ErrorEvent) {

      // client-side error

      errorMessage = `Error: ${error.error.message}`;

    } else {

      // server-side error

      errorMessage = `Error Code: ${error.status}\nMessage: ${error.message}`;

    }
    this.toastr.error(errorMessage);

    return throwError(error);

  }

=======
>>>>>>> ad49b4b0c2207cbde6f0503cba0455cafbd7b9d2
}
