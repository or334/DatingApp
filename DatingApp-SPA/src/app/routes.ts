import { Routes } from '@angular/router';
import { HomeComponent } from './Home/Home.component';
import { MemberListComponent } from './members/member-list/member-list.component';
import { MessagesComponent } from './messages/messages.component';
import { ListsComponent } from './lists/lists.component';
import { AuthGuard } from './_guards/auth.guard';
import { MemberDetailComponent } from './members/member-list/member-detail/member-detail.component';
import { MemeberDetailResolver } from './_resolvers/member-detail.resolver';
import { MemeberListResolver } from './_resolvers/member-list.resolver';

// tslint:disable-next-line: one-variable-per-declaration
export const appRoutes: Routes = [
  { path: '', component: HomeComponent },
  {
    path: '',
    runGuardsAndResolvers: 'always',
    canActivate: [AuthGuard],
    children: [
      { path: 'members', component: MemberListComponent,  resolve: {users: MemeberListResolver}},
      { path: 'members/:id', component: MemberDetailComponent, resolve: {user: MemeberDetailResolver}},
      { path: 'messages', component: MessagesComponent },
      { path: 'lists', component: ListsComponent }
    ]
  },
  { path: '**', redirectTo: '', pathMatch: 'full' }
];
