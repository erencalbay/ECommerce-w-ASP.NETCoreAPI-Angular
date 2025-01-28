import { inject } from '@angular/core';
import { CanActivateFn, Router } from '@angular/router';
import { NgxSpinnerService } from 'ngx-spinner';
import { SpinnerType } from 'src/app/base/base.component';
import { _isAuthenticated} from 'src/app/services/common/auth.service';
import { CustomToastrService, ToastrMessageType, ToastrPosition } from 'src/app/services/ui/custom-toastr.service';

export const authGuard: CanActivateFn = (route, state) => {

  const router = inject(Router);
  const toastrService = inject(CustomToastrService);
  const spinner = inject(NgxSpinnerService);

  spinner.show(SpinnerType.BallAtom);

  if (!_isAuthenticated) {
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
