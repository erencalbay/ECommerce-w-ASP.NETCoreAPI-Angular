import { Injectable } from '@angular/core';
import { firstValueFrom, Observable } from 'rxjs';
import { Token } from '../../../contracts/token/token';
import { TokenResponse } from '../../../contracts/token/token_response';
import { Create_User } from '../../../contracts/users/create_user';
import { User } from '../../../entities/user';
import { CustomToastrService, ToastrMessageType, ToastrPosition } from '../../ui/custom-toastr.service';
import { HttpClientService } from '../http-client.service';
import { SocialUser } from '@abacritt/angularx-social-login';

@Injectable({
  providedIn: 'root'
})
export class UserService {
  constructor(private httpClientService: HttpClientService, private toastrService: CustomToastrService) { }

  async create(user: User): Promise<Create_User> {
    const observable: Observable<Create_User | User> = this.httpClientService.post<Create_User | User>({
      controller: "users"
    }, user);

    return await firstValueFrom(observable) as Create_User;
  }

  async login(userNameOrEmail: string, password: string, callBackFunction?: () => void): Promise<any> {
    const observable: Observable<any | TokenResponse> = this.httpClientService.post<any | TokenResponse>({
      controller: "users",
      action: "login"
    }, { userNameOrEmail, password })

    const tokenResponse: TokenResponse = await firstValueFrom(observable) as TokenResponse;

    if (tokenResponse) {
      localStorage.setItem("accessToken", tokenResponse.token.accessToken);

      this.toastrService.message("User login succeessful.", "Giriş Başarılı", {
        messageType: ToastrMessageType.Success,
        position: ToastrPosition.TopRight
      })
    }

    callBackFunction();
  }

  async googleLogin(user:SocialUser, callBackFunction?: () => void) : Promise<any> {
    const Observable : Observable<SocialUser | TokenResponse>= this.httpClientService.post<SocialUser | TokenResponse>({
      action: "google-login",
      controller:"users"
    }, user);

    const TokenResponse = await firstValueFrom(Observable) as TokenResponse;

    if(TokenResponse){
      localStorage.setItem("accessToken", TokenResponse.token.accessToken);

      this.toastrService.message("Logging with Google is successful", "Login Successful",
        {messageType: ToastrMessageType.Success,
          position: ToastrPosition.TopRight
        });
    }

    callBackFunction();

  }
}