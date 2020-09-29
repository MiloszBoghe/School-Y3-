import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { Page1Component } from '../components/page1/page1.component';
import { Page2Component } from '../components/page2/page2.component';
import { Sub1Component } from '../components/sub1/sub1.component';
import { Page3Component } from '../components/page3/page3.component';
import { Page4Component } from '../components/page4/page4.component';
import { CanActivateViaAuthGuard } from './auth-activator.service';
import { Page5Component } from '../components/page5/page5.component';
import { CanDeactivateConfirmGuard } from './confirm-deactivator.service';
import { LoginComponent } from '../components/login/login.component';
import { Error404Component } from '../components/error404/error404.component';

const routes: Routes = [
  {
      path: '',
      redirectTo: 'page1',
      pathMatch: 'full'
  },
  {
      path: 'page1',
      component: Page1Component
  },
  {
      path: 'page2',
      component: Page2Component,
      children: [
          { path: 'sub1', component: Sub1Component },
        ],
  },
  {
      path: 'page3/:param1',
      component: Page3Component
  },
  {
      path: 'page4',
      component: Page4Component,
      canActivate: [CanActivateViaAuthGuard]
  },
  {
      path: 'page5/:par1/:par2',
      component: Page5Component,
      canDeactivate: [CanDeactivateConfirmGuard]
  },
  {
      path: 'login',
      component: LoginComponent
  },
  {
      path: '**',
      component: Error404Component
  }

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
  providers: [CanActivateViaAuthGuard, CanDeactivateConfirmGuard]
})
export class AppRoutingModule { }
