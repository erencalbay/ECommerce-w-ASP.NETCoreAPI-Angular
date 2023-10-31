import { Component } from '@angular/core';
import { CustomToastrService, ToastrMessageType, ToastrPosition } from './services/ui/custom-toastr.service';
declare var $:any

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'ECommerceClient';
  constructor(private toastrService : CustomToastrService){
    toastrService.message("Message", "Info", {
      messageType: ToastrMessageType.Info,
      position: ToastrPosition.TopCenter
    });
  }
}

$.get("https://localhost:7093/api/products", data => {
  console.log(data);
})