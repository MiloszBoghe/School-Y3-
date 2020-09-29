import { Injectable } from '@angular/core';
import { CanActivate, Router } from '@angular/router';
import { AuthService } from '../services/auth.service';

@Injectable()
export class CanActivateViaAuthGuard implements CanActivate {

    constructor(private authService: AuthService, private router: Router) { }

    canActivate() {
        console.log(this.authService.isLoggedIn());
        if (!this.authService.isLoggedIn()) {
            this.router.navigate(['/login']);
        }
        return this.authService.isLoggedIn();
    }
}
