import { inject } from '@angular/core';
import { CanActivateFn, Router } from '@angular/router';
import { JwtHelperService } from '@auth0/angular-jwt';
import { NgxSpinnerService } from 'ngx-spinner';
import { SpinnerType } from 'src/app/base/base.component';
import { CustomToastrService, ToastrMessageType, ToastrPosition } from 'src/app/services/ui/custom-toastr.service';

export const authGuard: CanActivateFn = (route, state) => {
  const token: string = localStorage.getItem("accessToken");

  const router = inject(Router);
  const jwtHelper = inject(JwtHelperService);
  const toastrService = inject(CustomToastrService);
  const spinner = inject(NgxSpinnerService);

  spinner.show(SpinnerType.BallAtom);

  let expired: boolean;
  try {
    expired = jwtHelper.isTokenExpired(token);
  } catch {
    expired = true;
  }

  if (!token || expired) {
    router.navigate(["login"], { queryParams: { returnUrl: state.url } });
    toastrService.message("You must be login!", "Unauthorized access", {
      messageType: ToastrMessageType.Warning,
      position: ToastrPosition.TopRight,
    });

    spinner.hide(SpinnerType.BallAtom); 
    return false; 
  }

  spinner.hide(SpinnerType.BallAtom); 
  return true; 
};
