import { Injectable } from '@angular/core';
import { CanDeactivate, ActivatedRouteSnapshot, RouterStateSnapshot } from '@angular/router';
import { Page5Component } from '../components/page5/page5.component';

@Injectable()
export class CanDeactivateConfirmGuard implements CanDeactivate<Page5Component> {
    canDeactivate(component: Page5Component) {
        return window.confirm('Are you sure you want to leave?');
    }
}
