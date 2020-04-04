import { ListsResolver } from './_resolvers/lists.resolver';
import { ListsComponent } from './members/lists/lists.component';
import { RegisterComponent } from './register/register.component';
import { PreventUnsavedChanges } from './_guard/prevent-unsaved-changes.guard';
import { MemberEditResolver } from './_resolvers/member-edit.resolver';
import { MemberEditComponent } from './members/member-edit/member-edit.component';
import { MemberDetailResolver } from './_resolvers/member-detail.resolver';
import { ArticlesListComponent } from './articles/articles-list/articles-list.component';
import { ArticleDetailComponent } from './articles/article-detail/article-detail.component';
import { ArticlesComponent } from './articles/articles.component';
import { MemberDetailComponent } from './members/member-detail/member-detail.component';
import { MemberListComponent } from './members/member-list/member-list.component';
import { AuthGuard } from './_guard/auth.guard';
import { ContactComponent } from './contact/contact.component';
import { AboutComponent } from './about/about.component';
import { HomeComponent } from './home/home.component';
import { Routes } from '@angular/router';
import { MemberListResolver } from './_resolvers/member-list.resolver';

export const appRoutes: Routes = [
    { path: '', component: HomeComponent  },
    { path: 'articles', component: ArticlesListComponent },
    { path: 'articles/:id/:status', component: ArticleDetailComponent },
    { path: 'register', component: RegisterComponent },
    { path: 'about', component: AboutComponent},
    { path: 'contact', component: ContactComponent },

    {
        path: '',
        runGuardsAndResolvers: 'always',
        canActivate: [AuthGuard],
        children: [
            { path: 'members', component: MemberListComponent, resolve: { users: MemberListResolver} },
            { path: 'members/:id', component: MemberDetailComponent, resolve: { user: MemberDetailResolver} },
            { path: 'member/edit', component: MemberEditComponent, 
                resolve: { user: MemberEditResolver}, canDeactivate: [PreventUnsavedChanges] },
            { path: 'lists', component: ListsComponent, resolve: {users: ListsResolver}},
        ]
    },

    { path: '**', redirectTo: '', pathMatch: 'full'}
];
