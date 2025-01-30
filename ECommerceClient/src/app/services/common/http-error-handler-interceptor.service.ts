import { HttpEvent, HttpHandler, HttpInterceptor, HttpRequest, HttpStatusCode } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { catchError, Observable, of } from 'rxjs';
import { CustomToastrService, ToastrMessageType, ToastrPosition } from '../ui/custom-toastr.service';

@Injectable({
  providedIn: 'root'
})
export class HttpErrorHandlerInterceptorService implements HttpInterceptor {

  constructor(private toastrService: CustomToastrService) { }

  intercept(req: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
    return next.handle(req).pipe(catchError(error => {
      switch(error.status){
        case HttpStatusCode.Unauthorized:
          this.toastrService.message("You don't have a permission for this action","Unauthorized",{
            messageType: ToastrMessageType.Warning,
            position: ToastrPosition.BottomFullWidth
          })
          break;
        case HttpStatusCode.InternalServerError:
          this.toastrService.message("There is a problem about server connection","Internal Server Error",{
            messageType: ToastrMessageType.Warning,
            position: ToastrPosition.BottomFullWidth
          })
          break;
        case HttpStatusCode.BadRequest:
          this.toastrService.message("Invalid request","Bad Request",{
            messageType: ToastrMessageType.Warning,
            position: ToastrPosition.BottomFullWidth
          })
          break;
        case HttpStatusCode.NotFound:
          this.toastrService.message("Page doesn't found","Not found",{
            messageType: ToastrMessageType.Warning,
            position: ToastrPosition.BottomFullWidth
          })
          break;
        default:
          this.toastrService.message("Undefined Error","Undefined Error",{
            messageType: ToastrMessageType.Warning,
            position: ToastrPosition.BottomFullWidth
          })
          break;
      }
      return of(error);
    }));
  }
}
