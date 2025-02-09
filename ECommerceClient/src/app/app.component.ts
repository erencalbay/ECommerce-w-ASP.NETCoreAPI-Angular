import { Component, ViewChild } from '@angular/core';
import { CustomToastrService, ToastrMessageType, ToastrPosition } from './services/ui/custom-toastr.service';
import { AuthService } from './services/common/auth.service';
import { Router } from '@angular/router';
import { DynamicLoadComponentDirective } from './directives/common/dynamic-load-component.directive';
import * as bootstrap from 'bootstrap'
import { ComponentType, DynamicLoadComponentService } from './services/common/model/dynamic-load-component.service';

declare var $:any

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  @ViewChild(DynamicLoadComponentDirective, { static: true })
  dynamicLoadComponentDirective: DynamicLoadComponentDirective;
  constructor(public authService: AuthService, private toastrService: CustomToastrService, private router: Router, private dynamicLoadComponentService: DynamicLoadComponentService) {
    authService.identityCheck();
  }


  signOut(){
    localStorage.removeItem("accessToken");
    this.authService.identityCheck();
    this.router.navigate([""]);
    this.toastrService.message("Logged out", "Logged out",{
      messageType: ToastrMessageType.Warning,
      position: ToastrPosition.TopRight
    })
  }
  loadComponent() {
    this.dynamicLoadComponentService.loadComponent(ComponentType.BasketsComponent, this.dynamicLoadComponentDirective.viewContainerRef);
  }
}
