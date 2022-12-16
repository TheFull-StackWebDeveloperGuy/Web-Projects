  import { Component, Inject, Input, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ApiService } from '../service/api.service';
import { CartService } from '../service/cart.service';

@Component({
  selector: 'app-product-card',
  templateUrl: './product-card.component.html',
  styleUrls: ['./product-card.component.css']
})
export class ProductCardComponent implements OnInit {
  constructor(private api: ApiService, private cartService: CartService) { }
  ngOnInit(): void {
    this.api.getProduct()
      .subscribe(res =>{
        this.productList = res;
        this.productList.forEach((a: any) => {
          Object.assign(a, { quantity: 1, total: a.price });


        });

    })

  }
  productList: Array<any> =[
    {
      "Id": 1,
      "Name": "Pork Belly",
      "Price": 10.99,
      "Quantity": 1,
      "Total": 10.99
    },
    {
      "Id": 2,
      "Name": "Pork Butt",
      "Price": 8.99,
      "Quantity": 1,
      "Total": 8.99
    },
    {
      "Id": 3,
      "Name": "Pork Tenderloin",
      "Price": 9.99,
      "Quantity": 1,
      "Total": 9.99
    },
    {
      "Id": 4,
      "Name": "Pork Shoulder",
      "Price": 7.99,
      "Quantity": 1,
      "Total": 7.99
    },
    {
      "Id": 5,
      "Name": "Pork Backbone",
      "Price": 5.99,
      "Quantity": 1,
      "Total": 5.99
    },
    {
      "Id": 6,
      "Name": "Pork Ribs",
      "Price": 8.99,
      "Quantity": 1,
      "Total": 8.99
    },
    {
      "Id": 7,
      "Name": "Pork Leg",
      "Price": 15.99,
      "Quantity": 1,
      "Total": 15.99
    },
    {
      "Id": 8,
      "Name": "Pork Innards",
      "Price": 8.99,
      "Quantity": 1,
      "Total": 8.99
    }
  ]

  addtocart(item: any) {
    this.cartService.addtoCart(item);

  }
  removeItem(item: any) {
    this.cartService.removeCartItem(item);
  }

}

