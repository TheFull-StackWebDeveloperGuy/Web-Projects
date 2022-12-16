import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { map } from 'rxjs/operators';
import { ProductCardComponent } from '../product-card/product-card.component';
@Injectable({
  providedIn: 'root'
})
export class ApiService {

  constructor(private http: HttpClient) { }

  getProduct() {
    return this.http.get<any>("ProductList")
      .pipe(map((res: any) => {
        return res;
      }))
  }
}
