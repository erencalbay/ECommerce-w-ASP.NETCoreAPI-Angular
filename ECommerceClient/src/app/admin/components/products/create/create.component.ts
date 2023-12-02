import { Component } from '@angular/core';
import { NgxSpinnerService } from 'ngx-spinner';
import { BaseComponent, SpinnerType } from 'src/app/base/base.component';
import { Create_Product } from 'src/app/contracts/product';
import { AlertifyService, MessageType, Position } from 'src/app/services/admin/alertify.service';
import { ProductService } from 'src/app/services/common/models/product.service';

@Component({
  selector: 'app-create',
  templateUrl: './create.component.html',
  styleUrls: ['./create.component.scss']
})
export class CreateComponent extends BaseComponent{
  constructor(spinner: NgxSpinnerService, private productService: ProductService, private alertify: AlertifyService){
    super(spinner)
  }
  create(txtName:HTMLInputElement, txtStock:HTMLInputElement, txtPrice:HTMLInputElement) {
    this.showSpinner(SpinnerType.BallAtom);
    const create_product: Create_Product = new Create_Product();
    create_product.name = txtName.value;
    create_product.stock = parseInt(txtStock.value);
    create_product.price = parseFloat(txtPrice.value);

    /*
    if(!txtName.value) {
      this.alertify.message("Lütfen ürün adini giriniz.", {
        dismissOthers: true,
        messageType: MessageType.Error,
        position: Position.TopRight
      });
      return;
    }

    if(parseInt(txtStock.value) < 0) {
      this.alertify.message("Lütfen stock bilgisini dogru giriniz giriniz.", {
        dismissOthers: true,
        messageType: MessageType.Error,
        position: Position.TopRight
      });
      return;
    }*/

    this.productService.create(create_product, () => {
      this.hideSpinner(SpinnerType.BallAtom)
      this.alertify.message("Item successfuly added.", {
        dismissOthers: true,
        messageType: MessageType.Success,
        position: Position.TopRight
      })
    }, errorMessage => {
      this.alertify.message(errorMessage, {
        dismissOthers: true,
        messageType: MessageType.Error,
        position: Position.TopRight
      })
    });


  }
}
