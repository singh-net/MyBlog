import { ListsResolver } from './_resolvers/lists.resolver';
import { ListsComponent } from './members/lists/lists.component';
import { PhotoEditorComponent } from './members/photo-editor/photo-editor.component';
import { PreventUnsavedChanges } from './_guard/prevent-unsaved-changes.guard';
import { MemberEditResolver } from './_resolvers/member-edit.resolver';
import { MemberEditComponent } from './members/member-edit/member-edit.component';
import { MemberDetailResolver } from './_resolvers/member-detail.resolver';
import { MemberDetailComponent } from './members/member-detail/member-detail.component';
import { appRoutes } from './routes';
import { AlertifyService } from './_services/alertify.service';
import { AuthService } from './_services/auth.service';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule, Pipe } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BsDropdownModule, TabsModule, PaginationModule, ButtonsModule } from 'ngx-bootstrap';
import {BsDatepickerModule} from 'ngx-bootstrap/datepicker';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { JwtModule } from '@auth0/angular-jwt';
import { NgxGalleryModule } from '@kolkov/ngx-gallery';


import { AppComponent } from './app.component';
import { NavComponent } from './nav/nav.component';
import { HomeComponent } from './home/home.component';
import { RegisterComponent } from './register/register.component';
import { ErrorInterceptorProvider } from './_services/error.interceptor';
import { AboutComponent } from './about/about.component';
import { ContactComponent } from './contact/contact.component';
import { RouterModule } from '@angular/router';
import { MemberListComponent } from './members/member-list/member-list.component';
import { MemberCardComponent } from './members/member-card/member-card.component';
import { ArticlesComponent } from './articles/articles.component';
import { ArticleDetailComponent } from './articles/article-detail/article-detail.component';
import { ArticlesListComponent } from './articles/articles-list/articles-list.component';
import { MemberListResolver } from './_resolvers/member-list.resolver';
import { FileUploadModule } from 'ng2-file-upload';


export function tokenGetter() {
   return localStorage.getItem('token');
}

@NgModule({
   declarations: [
      AppComponent,
      NavComponent,
      HomeComponent,
      RegisterComponent,
      AboutComponent,
      ContactComponent,
      MemberListComponent,
      MemberCardComponent,
      MemberDetailComponent,
      MemberEditComponent,
      ListsComponent,
      PhotoEditorComponent,
      ArticlesComponent,
      ArticleDetailComponent,
      ArticlesListComponent

   ],
   imports: [
      BrowserModule,
      HttpClientModule,
      FormsModule,
      ReactiveFormsModule,
      FileUploadModule,
      TabsModule.forRoot(),
      BsDropdownModule.forRoot(),
      ButtonsModule.forRoot(),
      PaginationModule.forRoot(),
      BrowserAnimationsModule,
      RouterModule.forRoot(appRoutes),
      NgxGalleryModule,
      BsDatepickerModule.forRoot(),
      JwtModule.forRoot( {
         config: {
            tokenGetter: tokenGetter,
            whitelistedDomains: ['localhost:5010'],
            blacklistedRoutes: ['localhost:5010/api/auth']
         }
      })
   ],
   providers: [
      ErrorInterceptorProvider,
      AuthService,
      AlertifyService,
      MemberDetailResolver,
      MemberListResolver,
      MemberEditResolver,
      PreventUnsavedChanges,
      ListsResolver
   ],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule { }
