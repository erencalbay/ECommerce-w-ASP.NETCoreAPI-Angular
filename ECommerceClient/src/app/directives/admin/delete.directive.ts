import { Directive, ElementRef, Renderer2, HostListener, Input, Output, EventEmitter } from '@angular/core';
import { HttpClientService } from 'src/app/services/common/http-client.service';
import { ProductService } from 'src/app/services/common/models/product.service';

declare var $ : any;

@Directive({
  selector: '[appDelete]'
})
export class DeleteDirective {

  constructor(
    private element: ElementRef,
    private _renderer: Renderer2,
    private productService: ProductService) 
    { 
      const img = _renderer.createElement("img");
      img.setAttribute("src","../../../../../assets/delete.png");
      img.setAttribute("style", "cursor: pointer;");
      img.width = 32;
      img.height = 32;
      _renderer.appendChild(element.nativeElement, img);
    }

  @Input() id: string;
  @Output() callback : EventEmitter<any> = new EventEmitter();

  @HostListener("click")
  async onclick() {
    const td : HTMLTableCellElement = this.element.nativeElement;
    await this.productService.delete(this.id);
    $(td.parentElement).fadeOut(1000, ()=> {
      this.callback.emit();
    });
  }
}
