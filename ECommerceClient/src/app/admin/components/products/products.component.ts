import { Component, OnInit} from '@angular/core';
import { NgxSpinnerService } from 'ngx-spinner';
import { BaseComponent, SpinnerType } from 'src/app/base/base.component';
import { Product } from 'src/app/contracts/product';
import { HttpClientService } from 'src/app/services/common/http-client.service';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.scss']
})
export class ProductsComponent extends BaseComponent implements OnInit {
  constructor(spinner : NgxSpinnerService, private httpClientService: HttpClientService){
    super(spinner)
  }
  ngOnInit(): void {
    this.showSpinner(SpinnerType.BallAtom);
    this.httpClientService.get<Product[]>({
      controller: "products"
    }).subscribe(data => console.log(data));

    /*this.httpClientService.post({
      controller: "products"
    },{
      name: "kagit",
      stock: 1000,
      price: 5

    }).subscribe();*/

    /*this.httpClientService.put({
      controller: "products",
    }, {
      id : "231370cd5-8050-4d80-95f6-d38e4b85555d",
      name: "Renkli Kalemi",
      stock: 120,
      price: 20

    }).subscribe();*/

    /*this.httpClientService.delete({
      controller : "products",
    }, "22d1155e-3d8f-46f0-a331-aceac0d9d176").subscribe();*/

  }
}
