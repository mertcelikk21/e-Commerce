import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NavBarComponent } from './nav-bar/nav-bar.component';
import { RouterModule } from '@angular/router';
import { NotFoundComponent } from './not-found/not-found.component';
import { ServerErrorComponent } from './server-error/server-error.component';
import { TestErrorComponent } from './test-error/test-error.component';
import { ToastrModule } from 'ngx-toastr';
import { SharedModule } from '../shared/shared.module';







@NgModule({
  declarations: [NavBarComponent, NotFoundComponent, ServerErrorComponent, TestErrorComponent],
  imports: [
    CommonModule,
    RouterModule,
    SharedModule,
    
    ToastrModule.forRoot({
      positionClass:'toastr-bottom-right',
      preventDuplicates:true,
      
    })
  ],
  exports:[NavBarComponent]
})
export class CoreModule { }
