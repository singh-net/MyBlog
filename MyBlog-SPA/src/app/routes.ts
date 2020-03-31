import { AuthGuard } from './_guard/auth.guard';
import { ContactComponent } from './contact/contact.component';
import { AboutComponent } from './about/about.component';
import { HomeComponent } from './home/home.component';
import { Routes } from '@angular/router';

export const appRoutes: Routes = [
    { path: '', component: HomeComponent  },

    {
        path: '',
        runGuardsAndResolvers: 'always',
        canActivate: [AuthGuard],
        children: [
            { path: 'about', component: AboutComponent},
            { path: 'contact', component: ContactComponent },
        ]
    },

    { path: '**', redirectTo: '', pathMatch: 'full'}
];
