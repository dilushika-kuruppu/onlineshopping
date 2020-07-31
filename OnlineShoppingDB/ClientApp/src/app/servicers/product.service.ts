import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { Product } from "../models/produts";
import { HttpClient } from "@angular/common/http";
import { Category } from "../models/category";

@Injectable({
  providedIn: "root"
})

export class ProductService {
  baseUrl = 'api/';
  constructor(private http: HttpClient) {
  }
  getProducts(): Observable<Product[]> {
    return this.http.get<Product[]>(this.baseUrl+ 'products');
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

}
